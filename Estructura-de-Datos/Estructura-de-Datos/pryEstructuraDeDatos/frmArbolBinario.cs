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
    public partial class frmArbolBinario : Form
    {
        ArbolBinario Arbol = new ArbolBinario();
        public bool asc = true;
        public string recorrer;
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Arbol.Busqueda(Convert.ToInt32(txtCodigo.Text)) == false)
            {
                clsNodo objNodo = new clsNodo();

                objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                objNodo.Nombre = txtNombre.Text;
                objNodo.Tramite = txtTramite.Text;
               

                Arbol.Agregar(objNodo);

                if (rbInOrden.Checked)
                {

                    Arbol.Recorrer(dgvArbolBinario);
                    Arbol.Recorrer(lstArbolBinario);
                    Arbol.Recorrer(cmbCodigo);
                    Arbol.Recorrer(tvArbol);
                    txtCodigo.Focus();


                }
                if (rbAscendente.Checked)
                {
                    Arbol.Recorrer(lstArbolBinario);
                    Arbol.Recorrer(dgvArbolBinario);
                    Arbol.Recorrer(cmbCodigo);
                    Arbol.Recorrer(tvArbol);
                    txtCodigo.Focus();

                }
                else
                {
                    Arbol.RecorrerDes(lstArbolBinario);
                    Arbol.RecorrerDes(dgvArbolBinario);
                    Arbol.RecorrerDes(cmbCodigo);
                    Arbol.RecorrerDes(tvArbol);
                    txtCodigo.Focus();

                }
                if (rbPreOrden.Checked)
                {
                    Arbol.RecorrerPreOrden(dgvArbolBinario);
                    Arbol.RecorrerPreOrden(lstArbolBinario);
                    Arbol.RecorrerPreOrden(cmbCodigo);
                    Arbol.RecorrerPreOrden(tvArbol);
                    txtCodigo.Focus();


                }
                if (rbPostOrden.Checked)
                {
                    Arbol.RecorrerPostOrden(dgvArbolBinario);
                    Arbol.RecorrerPostOrden(lstArbolBinario);
                    Arbol.RecorrerPostOrden(cmbCodigo);
                    Arbol.RecorrerPostOrden(tvArbol);
                    txtCodigo.Focus();

                }

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            else
            {
                MessageBox.Show("El Codigo ingresado esta Repetido");
            }
        }

        public void SeleccionRecorrido()
        {
            if (rbInOrden.Checked)
            {
                recorrer = "InOrden";
                if (rbAscendente.Checked)
                {
                    asc = true;
                }
                else if (rbDescendente.Checked)
                {
                    asc = false;
                }
            }
            else if (rbPostOrden.Checked)
            {
                recorrer = "PostOrden";
            }
            else if (rbPreOrden.Checked)
            {
                recorrer = "PreOrden";
            }

        }

        public void RecorrerElementos()
        {
            if (Arbol.Raiz != null)
            {
                Arbol.Recorrer(lstArbolBinario, asc, recorrer);
                Arbol.Recorrer(cmbCodigo, asc, recorrer);
                Arbol.Recorrer(dgvArbolBinario, recorrer, asc);
                Arbol.Recorrer(tvArbol);
                tvArbol.ExpandAll();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((Arbol.Raiz != null) && (cmbCodigo.SelectedIndex != -1))
            {
                Arbol.Eliminar(Convert.ToInt32(cmbCodigo.SelectedItem));
                SeleccionRecorrido();
                RecorrerElementos();


                if (Arbol.Raiz == null)
                {
                    dgvArbolBinario.Rows.Clear();
                    cmbCodigo.Items.Clear();
                    lstArbolBinario.Items.Clear();
                    tvArbol.Nodes.Clear();

                }

            }
            else
            {
                MessageBox.Show("No se encuentran datos");
            }
            txtCodigo.Focus();
        }

        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            rbInOrden.Checked = true;
            rbAscendente.Checked = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void Validar()
        {
            if (txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty && txtTramite.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedText == null)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

       
    }
}
