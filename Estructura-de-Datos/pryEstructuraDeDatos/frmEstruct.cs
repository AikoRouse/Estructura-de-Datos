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
    public partial class frmEstruct : Form
    {
        public frmEstruct()
        {
            InitializeComponent();
        }

        private void datosDelProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();
            frmDatos.Show();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();   
            frmListaSimple.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frmLD = new frmListaDoble();
            frmLD.Show();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario frmArbol = new frmArbolBinario();
            frmArbol.Show();
        }
    }
}
