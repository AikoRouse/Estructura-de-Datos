﻿using System;
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

        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.Show();
        }
    }
}
