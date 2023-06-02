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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

            clsPila FilaDePersonas = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            
            if (txtCodigo.Text!= null && txtNombre.Text != null && txtTramite.Text != null)
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;

                FilaDePersonas.Agregar(ObjNodo);
                FilaDePersonas.Recorrer(dgvPila);
                FilaDePersonas.Recorrer(lstPila);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, llenar todos los campos");
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblEliminarCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblEliminarNombre.Text = FilaDePersonas.Primero.Nombre;
                lblEliminarTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvPila);
                FilaDePersonas.Recorrer(lstPila);
            }
            else
            {
                lblEliminarCodigo.Text = "";
                lblEliminarNombre.Text = "";
                lblEliminarTramite.Text = "";
            }
        }
    }
}
