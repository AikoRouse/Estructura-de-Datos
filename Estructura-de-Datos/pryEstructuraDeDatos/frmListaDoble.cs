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
    public partial class frmListaDoble : Form
    {
        clsListaDoble Lista = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(dgvListaD);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cmbCodigo);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (Lista.Primero != null)
            {
                Int32 codigo = Convert.ToInt32(cmbCodigo.Text);
                Lista.Eliminar(codigo);
                Lista.Recorrer(dgvListaD);
                Lista.Recorrer(cmbCodigo);
                Lista.Recorrer(lstListaDoble);
                btnEliminar.Enabled = false;
                
            }

        }
       

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvListaD);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cmbCodigo);
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.RecorrerDes(dgvListaD);
            Lista.RecorrerDes(lstListaDoble);
            Lista.RecorrerDes(cmbCodigo);
        }
    }
}
