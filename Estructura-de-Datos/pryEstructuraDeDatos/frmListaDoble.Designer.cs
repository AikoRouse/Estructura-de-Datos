namespace pryEstructuraDeDatos
{
    partial class frmListaDoble
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbListar = new System.Windows.Forms.GroupBox();
            this.dgvListaD = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigoE = new System.Windows.Forms.Label();
            this.gbAgregar = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaD)).BeginInit();
            this.gbEliminar.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dgvListaD);
            this.gbListar.Controls.Add(this.lstListaDoble);
            this.gbListar.Location = new System.Drawing.Point(9, 287);
            this.gbListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Name = "gbListar";
            this.gbListar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Size = new System.Drawing.Size(794, 273);
            this.gbListar.TabIndex = 15;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaD
            // 
            this.dgvListaD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvListaD.Location = new System.Drawing.Point(272, 21);
            this.dgvListaD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListaD.Name = "dgvListaD";
            this.dgvListaD.RowHeadersWidth = 51;
            this.dgvListaD.RowTemplate.Height = 24;
            this.dgvListaD.Size = new System.Drawing.Size(516, 244);
            this.dgvListaD.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Tramite
            // 
            this.Tramite.Frozen = true;
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            this.Tramite.Width = 125;
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.ItemHeight = 16;
            this.lstListaDoble.Location = new System.Drawing.Point(5, 21);
            this.lstListaDoble.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(260, 244);
            this.lstListaDoble.TabIndex = 0;
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.cmbCodigo);
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Controls.Add(this.lblCodigoE);
            this.gbEliminar.Location = new System.Drawing.Point(590, 11);
            this.gbEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEliminar.Size = new System.Drawing.Size(213, 175);
            this.gbEliminar.TabIndex = 14;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar elemento";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(25, 68);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(160, 24);
            this.cmbCodigo.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(70, 121);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Location = new System.Drawing.Point(11, 36);
            this.lblCodigoE.Name = "lblCodigoE";
            this.lblCodigoE.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoE.TabIndex = 4;
            this.lblCodigoE.Text = "Código:";
            // 
            // gbAgregar
            // 
            this.gbAgregar.Controls.Add(this.txtTramite);
            this.gbAgregar.Controls.Add(this.txtNombre);
            this.gbAgregar.Controls.Add(this.txtCodigo);
            this.gbAgregar.Controls.Add(this.btnAgregar);
            this.gbAgregar.Controls.Add(this.lblTramite);
            this.gbAgregar.Controls.Add(this.lblNombre);
            this.gbAgregar.Controls.Add(this.lblCodigo);
            this.gbAgregar.Location = new System.Drawing.Point(384, 26);
            this.gbAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAgregar.Size = new System.Drawing.Size(200, 257);
            this.gbAgregar.TabIndex = 13;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(93, 159);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 22);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 43);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(43, 217);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(17, 159);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 43);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDeDatos.Properties.Resources.ListaDoble;
            this.pictureBox1.Location = new System.Drawing.Point(14, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 155);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDescendente);
            this.groupBox1.Controls.Add(this.rbAscendente);
            this.groupBox1.Location = new System.Drawing.Point(590, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listar Datos";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(23, 56);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(109, 20);
            this.rbDescendente.TabIndex = 3;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            this.rbDescendente.CheckedChanged += new System.EventHandler(this.rbDescendente_CheckedChanged);
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(23, 30);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(100, 20);
            this.rbAscendente.TabIndex = 2;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            this.rbAscendente.CheckedChanged += new System.EventHandler(this.rbAscendente_CheckedChanged);
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(823, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbAgregar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doblemente Enlazada";
            this.gbListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaD)).EndInit();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.DataGridView dgvListaD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoE;
        private System.Windows.Forms.GroupBox gbAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
    }
}