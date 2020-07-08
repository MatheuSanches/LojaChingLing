using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaCL
{
    public partial class FrmRelCartao : Form
    {
        public FrmRelCartao()
        {
            InitializeComponent();
        }

        private void FrmRelCartao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DBLojaDSMaster.cartaovenda'. Você pode movê-la ou removê-la conforme necessário.
            this.cartaovendaTableAdapter.Fill(this.DBLojaDSMaster.cartaovenda);

            this.reportViewer1.RefreshReport();
        }
    }
}
