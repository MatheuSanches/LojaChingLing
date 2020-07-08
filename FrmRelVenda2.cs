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
    public partial class FrmRelVenda2 : Form
    {
        SqlConnection con = Conexao.obterConexao();
        public FrmRelVenda2()
        {
            InitializeComponent();
        }

        public string cartao { get; set; }

        private void FrmRelVenda2_Load(object sender, EventArgs e)
        {
            if (!this.Equals(""))
            {
                label2.Text = this.cartao;
            }
            string idcartao = "SELECT MAX(Id_venda) AS Id_venda FROM venda WHERE cartao = @cartao";
            SqlCommand cmd = new SqlCommand(idcartao, con);
            cmd.Parameters.AddWithValue("@cartao", label2.Text.Trim());
            Conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                label4.Text = rd["Id_venda"].ToString();
            }
            else
            {
                MessageBox.Show("Não consegui!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int idvenda = Convert.ToInt32(label4.Text.Trim());
            this.RelVendaTableAdapter.Fill(this.DSVenda2.RelVenda, idvenda);
            this.reportViewer1.RefreshReport();
        }
    }
}
