using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class frmConsultaBD : Form
    {
        public frmConsultaBD()
        {
            InitializeComponent();
        }

        clsConsultarBD objConsultaBD = new clsConsultarBD();

        private void btnListar_Click(object sender, EventArgs e)
        {
            string varSQL  = txtConsulta.Text;
            objConsultaBD.Listar(dgvBdD, varSQL);
        }
    }
}
