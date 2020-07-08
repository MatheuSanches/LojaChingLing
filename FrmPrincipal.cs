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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void CarregadgvPripedi()
        {
            SqlConnection con = Conexao.obterConexao();
            String query = "select * from cartaovenda";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            //SQLDataAdapter, usado para preencher o DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Adiciona um DataTable carregado em memória
            DataTable cartao = new DataTable();
            da.Fill(cartao);
            //Fonte de dados
            dgvPripedi.DataSource = cartao;
            //Quando for criar um controle em tempo de execução, é importante atribuir um nome para ele, e definir as principais propriedades do controle
            DataGridViewButtonColumn fechar = new DataGridViewButtonColumn();
            fechar.Name = "FecharConta";
            fechar.HeaderText = "Fechar Conta";
            fechar.Text = "Fechar Conta";
            fechar.UseColumnTextForButtonValue = true;
            int columIndex = 4;
            dgvPripedi.Columns.Insert(columIndex, fechar);
            Conexao.fecharConexao();
            dgvPripedi.CellClick += dgvPripedi_CellClick;
            int colunas = dgvPripedi.Columns.Count;
            if(colunas > 5)
            {
                dgvPripedi.Columns.Remove("FecharConta");
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudCliente cli = new FrmCrudCliente();
            cli.Show();
        }

        private void testarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Conexao.obterConexao();
                String query = "select * from cliente";
                SqlCommand cmd = new SqlCommand(query, con);
                Conexao.obterConexao();
                DataSet ds = new DataSet();
                MessageBox.Show("Conectado ao Banco de Dados com Sucesso!", "Teste de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
                Conexao.fecharConexao();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudProduto pro = new FrmCrudProduto();
            pro.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenda ven = new FrmVenda();
            ven.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudUsuario usu = new FrmCrudUsuario();
            usu.Show();
        }

        private void cartãoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudCartaoVenda ven = new FrmCrudCartaoVenda();
            ven.Show();
        }

        private void dgvPripedi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == dgvPripedi.Columns["FecharConta"].Index)
                {
                    if(Application.OpenForms["FrmVenda"] == null)
                    {
                        string numero = dgvPripedi[1, e.RowIndex].Value.ToString();
                        FrmVenda ven = new FrmVenda(numero);
                        ven.Show();
                    }
                }
            }
            catch
            {

            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregadgvPripedi();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido ped = new FrmPedido();
            ped.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelCliente relcli = new FrmRelCliente();
            relcli.Show();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelProduto relprod = new FrmRelProduto();
            relprod.Show();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelUsuario relusu = new FrmRelUsuario();
            relusu.Show();
        }

        private void cartãoDeVendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRelCartao relca = new FrmRelCartao();
            relca.Show();
        }

        private void produtoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelProdTipo relprotipo = new FrmRelProdTipo();
            relprotipo.Show();
        }
    }
}
