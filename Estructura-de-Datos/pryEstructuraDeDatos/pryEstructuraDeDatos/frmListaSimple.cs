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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple ListaSimple = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;

            ListaSimple.Agregar(ObjNodo);
            ListaSimple.Recorrer(dgvLista);
            ListaSimple.Recorrer(lstListaSimple);
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void lblCodigoE_Click(object sender, EventArgs e)
        {

        }
    }
}
