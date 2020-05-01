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

        public void CarregadgvPriPedi() 
        {
            SqlConnection con = Conexao.obterConexao();
            String query = "select * from cartaovenda";
            SqlCommand cmd = new SqlCommand(query, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            //Usa para prencher DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Adiciona um DataTable carregado em memória
            DataTable cartao = new DataTable();
            da.Fill(cartao);
            dgvPriPedi.DataSource = cartao;
            //Quando for criar um controle em tempo de execução é muito importante atribuir um nome pare ele, e também definir as principais propriedades dele
            DataGridViewButtonColumn fechar = new DataGridViewButtonColumn();
            fechar.Name = "FecharConta";
            fechar.HeaderText = "Fechar Conta";
            fechar.Text = "Fechar Conta";
            fechar.UseColumnTextForButtonValue = true;
            int columIndex = 4;
            dgvPriPedi.Columns.Insert(columIndex, fechar);
            Conexao.fecharConexao();
            dgvPriPedi.CellClick += dgvPriPedi_CellClick;
            int colunas = dgvPriPedi.Columns.Count;
            if(colunas > 5)
            {
                dgvPriPedi.Columns.Remove("FecharConta");
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregadgvPriPedi();
        }

        private void dgvPriPedi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvPriPedi.Columns["FecharConta"].Index)
                {
                    if(Application.OpenForms["FrmVenda"] == null) 
                    {
                        FrmVenda ven = new FrmVenda();
                        ven.Show();
                    }
                }
            }
            catch
            {

            }
        }

        private void cartaoDeVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudCartaoVenda cv = new FrmCrudCartaoVenda();
            cv.Show();
        }
    }
}
