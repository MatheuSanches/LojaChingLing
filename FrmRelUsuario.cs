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
    public partial class FrmRelUsuario : Form
    {
        public FrmRelUsuario()
        {
            InitializeComponent();
        }

        private void FrmRelUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DBLojaDSMaster.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.DBLojaDSMaster.usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
