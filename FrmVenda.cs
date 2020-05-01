using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LojaCL
{
    public partial class FrmVenda : Form
    {
        SqlConnection con = Conexao.obterConexao();
        public FrmVenda()
        {
            InitializeComponent();
        }

        public void CarregacbxCliente()
        {
            string cli = "select cpf, nome from cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "nome");
            cbxCliente.ValueMember = "cpf";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["nome"];
            Conexao.fecharConexao();
        } 

        public void CarregacbxProduto()
        {
            string pro = "select Id, nome from produto";
            SqlCommand cmd = new SqlCommand(pro, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "nome");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["nome"];
            Conexao.fecharConexao();
        }
        
         private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            if (cbxCliente.DisplayMember == "")
            {
                cbxProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtValor.Enabled = false;
                txtValorTotal.Enabled = false;
                btnNovoItem.Enabled = false;
                btnFinalizar.Enabled = false;
                btnEcluirItem.Enabled = false;
                btnEditarItem.Enabled = false;
            }
            CarregacbxCliente();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            cbxProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            btnNovoItem.Enabled = true;
            btnFinalizar.Enabled = true;
            btnEcluirItem.Enabled = true;
            btnEditarItem.Enabled = true;
            CarregacbxProduto();
            dgvVenda.Columns.Add("ID", "ID");
            dgvVenda.Columns.Add("Produto", "Produto");
            dgvVenda.Columns.Add("Quantidade", "Quantidade");
            dgvVenda.Columns.Add("Valor", "Valor");
            dgvVenda.Columns.Add("Total", "Total");
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand("LocalizarProduto", con);
            cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexao.obterConexao();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtValor.Text = rd["valor"].ToString();
                txtId.Text = rd["Id"].ToString();
                Conexao.fecharConexao();
            } else
            {
                MessageBox.Show("Nenhum registro encontrado!", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Conexao.fecharConexao();
            }
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow item = new DataGridViewRow();
            item.CreateCells(dgvVenda);
            item.Cells[0].Value = txtId.Text;
            item.Cells[1].Value = cbxProduto.Text;
            item.Cells[2].Value = txtQuantidade.Text;
            item.Cells[3].Value = txtValor.Text;
            item.Cells[4].Value = Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text);
            dgvVenda.Rows.Add(item);
            cbxProduto.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
            //Realizar a soma usando um contador...
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtValorTotal.Text = Convert.ToString(soma);
        }

        private void dgvVenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvVenda.Rows[e.RowIndex];
            cbxProduto.Text = row.Cells[1].Value.ToString();
            txtQuantidade.Text = row.Cells[2].Value.ToString();
            txtValor.Text = row.Cells[3].Value.ToString();
            int linha = dgvVenda.CurrentRow.Index;
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows[linha].Cells[1].Value = cbxProduto.Text;
            dgvVenda.Rows[linha].Cells[2].Value = txtQuantidade.Text;
            dgvVenda.Rows[linha].Cells[3].Value = txtValor.Text;
            dgvVenda.Rows[linha].Cells[4].Value = Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text);
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtValorTotal.Text = Convert.ToString(soma);
            cbxProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void btnEcluirItem_Click(object sender, EventArgs e)
        {
            int linha = dgvVenda.CurrentRow.Index;
            dgvVenda.Rows.RemoveAt(linha);
            dgvVenda.Refresh();
            decimal soma = 0;
            foreach (DataGridViewRow dr in dgvVenda.Rows)
                soma += Convert.ToDecimal(dr.Cells[4].Value);
            txtValorTotal.Text = Convert.ToString(soma);
            cbxProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            SqlConnection con = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand("InserirVenda", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@valor_pago", SqlDbType.Decimal).Value = Convert.ToDecimal(txtValorTotal.Text);
            cmd.Parameters.AddWithValue("@id_cliente", SqlDbType.NChar).Value = cbxCliente.SelectedValue;
            cmd.ExecuteNonQuery();
            string idvenda = "select IDENT_CURRENT('venda') as id_venda";
            SqlCommand cmdvenda = new SqlCommand(idvenda, con);
            Int32 idvenda2 = Convert.ToInt32(cmdvenda.ExecuteScalar());
            foreach (DataGridViewRow dr in dgvVenda.Rows)
            {
                SqlCommand cmditens = new SqlCommand("InserirItens", con);
                cmditens.CommandType = CommandType.StoredProcedure;
                //aqui começo a subtrair do meu estoque
                string ven = "update produto set quantidade = (quantidade - @quantidade2) from produto where Id = @id_produto2";
                SqlCommand cmditemvenda = new SqlCommand(ven, con);
                cmditemvenda.Parameters.AddWithValue("@quantidade2", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                cmditemvenda.Parameters.AddWithValue("@id_produto2", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                //termina a subtração do estoque
                cmditens.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[2].Value);
                cmditens.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                cmditens.Parameters.AddWithValue("@id_venda", SqlDbType.Int).Value = idvenda2;
                cmditens.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[3].Value);
                cmditens.Parameters.AddWithValue("@valor_total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                Conexao.obterConexao();
                cmditens.ExecuteNonQuery();
                cmditemvenda.ExecuteNonQuery();
                Conexao.fecharConexao();
            }
            MessageBox.Show("Venda realizada com sucesso!", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbxProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            cbxProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtValorTotal.Enabled = false;
            btnNovoItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnEcluirItem.Enabled = false;
            btnFinalizar.Enabled = false;
            dgvVenda.Enabled = false;
            //limpando o DataGridView
            dgvVenda.Rows.Clear();
            dgvVenda.Refresh();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            SqlConnection con = Conexao.obterConexao();
            SqlCommand cmd = new SqlCommand("LocalizarProduto", con);
            cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = cmd.ExecuteReader();
            int valor1 = 0;
            bool conversaoSucedida = int.TryParse(txtQuantidade.Text, out valor1);
            if (rd.Read())
            {
                int valor2 = Convert.ToInt32(rd["quantidade"].ToString());
                if (valor1 > valor2)
                {
                    MessageBox.Show("Não possui quantidade suficiente em estoque!", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Conexao.fecharConexao();
                    txtQuantidade.Text = "";
                    txtQuantidade.Focus();
                }
            }
        }
    }
}
