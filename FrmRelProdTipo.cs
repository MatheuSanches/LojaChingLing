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
    public partial class FrmRelProdTipo : Form
    {
        SqlConnection con = Conexao.obterConexao();
        public FrmRelProdTipo()
        {
            InitializeComponent();
            CarregaCbxProduto();
        }

        public void CarregaCbxProduto()
        {
            String pro = "SELECT tipo FROM produto GROUP BY tipo";
            SqlCommand cmd = new SqlCommand(pro, con);
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "tipo");
            comboBox1.ValueMember = "tipo";
            comboBox1.DisplayMember = "tipo";
            comboBox1.DataSource = ds.Tables["tipo"];
            Conexao.fecharConexao();
        }

        private void FrmRelProdTipo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DBLojaDSMaster.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.DBLojaDSMaster.produto);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Tipo", comboBox1.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("Tipo", (string)null));
            this.reportViewer1.RefreshReport();
        }
    }
}
