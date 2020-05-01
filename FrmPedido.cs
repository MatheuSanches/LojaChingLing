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
    public partial class FrmPedido : Form
    {
        SqlConnection con = Conexao.obterConexao();
        public FrmPedido()
        {
            InitializeComponent();
        }

        static int botaoclicado = 0;

        //Método que irá carregar o combobox do cartão de venda
        public void CarregaCbxCartao()
        {
            String car = "select * from cartaovenda";
            SqlCommand cmd = new SqlCommand(car, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(car, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "numero");
            cbxCartao.ValueMember = "Id";
            cbxCartao.DisplayMember = "numero";
            cbxCartao.DataSource = ds.Tables["numero"];
            Conexao.fecharConexao();
        }

        //Método que irá carregar o Combobox produto.
        public void CarregaCbxProduto()
        {
            String pro = "select Id,nome from produto";
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



        private void lblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            botaoclicado = 0;
            //Estes controles irão ficar inativos, até o usuário clicar em "Abrir Pedido".
            cbxProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            btnNovoItem.Enabled = false;
            btnFinalizar.Enabled = false;
            btnExcluirItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnAtualizarPedido.Enabled = false;
            CarregaCbxCartao();
            cbxCartao.Text = "";
        }

        private void cbxCartao_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Localizar_CartaoVenda", con);
            cmd.Parameters.AddWithValue("@Id", cbxCartao.SelectedValue);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexao.obterConexao();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                txtUsuario.Text = rd["usuario"].ToString();
                Conexao.fecharConexao();
                rd.Dispose();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!", "Falha na Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conexao.fecharConexao();
                rd.Dispose();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            cbxProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            dgvPedido.Enabled = true;
            btnNovoItem.Enabled = true;
            btnFinalizar.Enabled = true;
            btnExcluirItem.Enabled = true;
            btnEditarItem.Enabled = true;
            btnAtualizarPedido.Enabled = false;
            CarregaCbxProduto();
            cbxProduto.Text = "";
            dgvPedido.Columns.Add("ID", "IDProduto");
            dgvPedido.Columns.Add("Usuario", "Usuario");
            dgvPedido.Columns.Add("Produto", "Produto");
            dgvPedido.Columns.Add("Quantidade", "Quantidade");
            dgvPedido.Columns.Add("Valor", "Valor");
            dgvPedido.Columns.Add("Total", "Total");
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                rd.Dispose();
            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!", "Falha na Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Conexao.fecharConexao();
                rd.Dispose();
            }
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            if (botaoclicado == 1)
            {
                SqlCommand pedidos2 = new SqlCommand("InserirPedidos", con);
                pedidos2.CommandType = CommandType.StoredProcedure;
                pedidos2.Parameters.AddWithValue("@id_cartaovenda", SqlDbType.Int).Value = cbxCartao.SelectedValue;
                pedidos2.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = cbxProduto.SelectedValue;
                pedidos2.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = txtUsuario.Text;
                pedidos2.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(txtQuantidade.Text);
                pedidos2.Parameters.AddWithValue("@dia_hora", SqlDbType.DateTime).Value = DateTime.Now;
                pedidos2.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(txtValor.Text);
                pedidos2.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                Conexao.obterConexao();
                pedidos2.ExecuteNonQuery();
                Conexao.fecharConexao();
                btnLocalizar_Click(sender, e);
                MessageBox.Show("Pedido Atualizado com sucesso!");
                botaoclicado = 0;
            }
            else
            {
                //Carregando o item pedido para o datagrid, incluindo o valor e o total do pedido
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvPedido);
                item.Cells[0].Value = txtId.Text;
                item.Cells[1].Value = txtUsuario.Text;
                item.Cells[2].Value = cbxProduto.Text;
                item.Cells[3].Value = txtQuantidade.Text;
                item.Cells[4].Value = txtValor.Text;
                item.Cells[5].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvPedido.Rows.Add(item);
                cbxProduto.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                decimal soma = 0;
                //Passando por todos os itens do Datagridview, e realizando a soma total
                foreach (DataGridViewRow dr in dgvPedido.Rows)
                    soma += Convert.ToDecimal(dr.Cells[5].Value);
                txtValorTotal.Text = Convert.ToString(soma);
            }
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvPedido.Rows[e.RowIndex];
            cbxProduto.Text = row.Cells[2].Value.ToString();
            txtQuantidade.Text = row.Cells[3].Value.ToString();
            txtValor.Text = row.Cells[4].Value.ToString();
            int linha = dgvPedido.CurrentRow.Index;
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            int linha = dgvPedido.CurrentRow.Index;
            dgvPedido.Rows[linha].Cells[0].Value = txtId.Text;
            dgvPedido.Rows[linha].Cells[2].Value = cbxProduto.Text;
            dgvPedido.Rows[linha].Cells[3].Value = txtQuantidade.Text;
            dgvPedido.Rows[linha].Cells[4].Value = txtValor.Text;
            dgvPedido.Rows[linha].Cells[5].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
            decimal soma = 0;
            //Passando por todos os itens do Datagridview, e realizando a soma total
            foreach (DataGridViewRow dr in dgvPedido.Rows)
                soma += Convert.ToDecimal(dr.Cells[5].Value);
            txtValorTotal.Text = Convert.ToString(soma);
            cbxProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            int linha = dgvPedido.CurrentRow.Index;
            string query = "delete from pedido where (id_cartaovenda = @id_cartaovenda and id_produto = @id_produto)";
            SqlCommand cmd = new SqlCommand(query, con);
            DataGridViewRow row = dgvPedido.Rows[linha];
            cmd.Parameters.AddWithValue("@id_cartaovenda", cbxCartao.SelectedValue);
            cmd.Parameters.AddWithValue("@id_produto", row.Cells[0].Value);
            Conexao.obterConexao();
            cmd.ExecuteNonQuery();
            Conexao.fecharConexao();
            dgvPedido.Rows.RemoveAt(linha);
            dgvPedido.Refresh();
            decimal soma = 0;
            //Passando por todos os itens do Datagridview, e realizando a soma total
            foreach (DataGridViewRow dr in dgvPedido.Rows)
                soma += Convert.ToDecimal(dr.Cells[5].Value);
            txtValorTotal.Text = Convert.ToString(soma);
            cbxProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Conexao.obterConexao();
            SqlCommand cartao = new SqlCommand("AtualizarStatusCartaoVenda", con);
            cartao.CommandType = CommandType.StoredProcedure;
            cartao.Parameters.AddWithValue("@Id", SqlDbType.Int).Value = cbxCartao.SelectedValue;
            foreach (DataGridViewRow dr in dgvPedido.Rows)
            {
                SqlCommand pedidos = new SqlCommand("InserirPedidos", con);
                pedidos.CommandType = CommandType.StoredProcedure;
                pedidos.Parameters.AddWithValue("@id_cartaovenda", SqlDbType.Int).Value = cbxCartao.SelectedValue;
                pedidos.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                pedidos.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = dr.Cells[1].Value;
                pedidos.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[3].Value);
                pedidos.Parameters.AddWithValue("@dia_hora", SqlDbType.DateTime).Value = DateTime.Now;
                pedidos.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                pedidos.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[5].Value);
                Conexao.obterConexao();
                pedidos.ExecuteNonQuery();
                cartao.ExecuteNonQuery();
                Conexao.fecharConexao();
            }
            MessageBox.Show("Pedido realizado com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbxProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            cbxProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtValorTotal.Enabled = false;
            btnNovoItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
            btnFinalizar.Enabled = false;
            dgvPedido.Enabled = false;
            //limpando o DataGridView
            dgvPedido.Rows.Clear();
            dgvPedido.Refresh();
            FrmPrincipal obj = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];
            obj.CarregadgvPriPedi();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            botaoclicado = 1;
            cbxProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            btnNovoItem.Enabled = true;
            btnExcluirItem.Enabled = true;
            btnEditarItem.Enabled = true;
            btnFinalizar.Enabled = false;
            btnAtualizarPedido.Enabled = true;
            CarregaCbxProduto();
            try
            {
                SqlConnection con = Conexao.obterConexao();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "LocalizarPedidoGrid";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cartaovenda", cbxCartao.SelectedValue);
                Conexao.obterConexao();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvPedido.ReadOnly = true;
                    dgvPedido.DataSource = ds.Tables[0];
                    Conexao.fecharConexao();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado!", "Sem registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Conexao.fecharConexao();
                }
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvPedido.Rows)
                {
                    soma += Convert.ToDecimal(dr.Cells[5].Value);
                    txtValorTotal.Text = Convert.ToString(soma);
                }
                botaoclicado = 0;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }

        }

        private void btnAtualizarPedido_Click(object sender, EventArgs e)
        {
            Conexao.obterConexao();
            foreach (DataGridViewRow dr in dgvPedido.Rows)
            {
                SqlCommand pedidos = new SqlCommand("AtualizarPedidos", con);
                pedidos.CommandType = CommandType.StoredProcedure;
                pedidos.Parameters.AddWithValue("@id_cartaovenda", SqlDbType.Int).Value = cbxCartao.SelectedValue;
                pedidos.Parameters.AddWithValue("@id_produto", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[0].Value);
                pedidos.Parameters.AddWithValue("@usuario", SqlDbType.NChar).Value = dr.Cells[1].Value;
                pedidos.Parameters.AddWithValue("@quantidade", SqlDbType.Int).Value = Convert.ToInt32(dr.Cells[3].Value);
                pedidos.Parameters.AddWithValue("@dia_hora", SqlDbType.DateTime).Value = DateTime.Now;
                pedidos.Parameters.AddWithValue("@valor", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[4].Value);
                pedidos.Parameters.AddWithValue("@total", SqlDbType.Decimal).Value = Convert.ToDecimal(dr.Cells[5].Value);
                Conexao.obterConexao();
                pedidos.ExecuteNonQuery();
                Conexao.fecharConexao();
            }
            MessageBox.Show("Pedido atualizado com sucesso!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbxProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
            cbxProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtValorTotal.Enabled = false;
            btnNovoItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
            btnFinalizar.Enabled = false;
            dgvPedido.Enabled = false;
            dgvPedido.DataSource = null;
            FrmPrincipal obj = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];
            obj.CarregadgvPriPedi();
        }
    }
}