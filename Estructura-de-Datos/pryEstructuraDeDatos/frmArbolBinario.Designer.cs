namespace pryEstructuraDeDatos
{
    partial class frmArbolBinario
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
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstArbolBinario = new System.Windows.Forms.ListBox();
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
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrden = new System.Windows.Forms.RadioButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.gbEliminar.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dgvArbolBinario);
            this.gbListar.Controls.Add(this.lstArbolBinario);
            this.gbListar.Location = new System.Drawing.Point(9, 239);
            this.gbListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Name = "gbListar";
            this.gbListar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListar.Size = new System.Drawing.Size(860, 300);
            this.gbListar.TabIndex = 14;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvArbolBinario.Location = new System.Drawing.Point(272, 21);
            this.dgvArbolBinario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.RowHeadersWidth = 51;
            this.dgvArbolBinario.RowTemplate.Height = 24;
            this.dgvArbolBinario.Size = new System.Drawing.Size(559, 260);
            this.dgvArbolBinario.TabIndex = 1;
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
            // lstArbolBinario
            // 
            this.lstArbolBinario.FormattingEnabled = true;
            this.lstArbolBinario.ItemHeight = 16;
            this.lstArbolBinario.Location = new System.Drawing.Point(5, 21);
            this.lstArbolBinario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstArbolBinario.Name = "lstArbolBinario";
            this.lstArbolBinario.Size = new System.Drawing.Size(260, 260);
            this.lstArbolBinario.TabIndex = 0;
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.cmbCodigo);
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Controls.Add(this.lblCodigoE);
            this.gbEliminar.Location = new System.Drawing.Point(570, 17);
            this.gbEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEliminar.Size = new System.Drawing.Size(213, 218);
            this.gbEliminar.TabIndex = 13;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar elemento";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(23, 101);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(160, 24);
            this.cmbCodigo.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Lavender;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(53, 174);
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
            this.lblCodigoE.Location = new System.Drawing.Point(19, 63);
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
            this.gbAgregar.Location = new System.Drawing.Point(365, 17);
            this.gbAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAgregar.Size = new System.Drawing.Size(200, 218);
            this.gbAgregar.TabIndex = 12;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(93, 144);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 22);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 86);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Lavender;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(43, 174);
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
            this.lblTramite.Location = new System.Drawing.Point(17, 144);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(876, 241);
            this.tvArbol.Margin = new System.Windows.Forms.Padding(4);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(240, 297);
            this.tvArbol.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbPostOrden);
            this.groupBox1.Controls.Add(this.rbPreOrden);
            this.groupBox1.Controls.Add(this.rbInOrden);
            this.groupBox1.Location = new System.Drawing.Point(790, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(187, 218);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(33, 148);
            this.rbPostOrden.Margin = new System.Windows.Forms.Padding(4);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(92, 20);
            this.rbPostOrden.TabIndex = 2;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "PostOrden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(33, 96);
            this.rbPreOrden.Margin = new System.Windows.Forms.Padding(4);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(86, 20);
            this.rbPreOrden.TabIndex = 1;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "PreOrden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbInOrden
            // 
            this.rbInOrden.AutoSize = true;
            this.rbInOrden.Location = new System.Drawing.Point(33, 44);
            this.rbInOrden.Margin = new System.Windows.Forms.Padding(4);
            this.rbInOrden.Name = "rbInOrden";
            this.rbInOrden.Size = new System.Drawing.Size(75, 20);
            this.rbInOrden.TabIndex = 0;
            this.rbInOrden.TabStop = true;
            this.rbInOrden.Text = "InOrden";
            this.rbInOrden.UseVisualStyleBackColor = true;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.rbDescendente);
            this.gbDatos.Controls.Add(this.rbAscendente);
            this.gbDatos.Location = new System.Drawing.Point(985, 17);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(131, 218);
            this.gbDatos.TabIndex = 17;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(6, 109);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(109, 20);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.TabStop = true;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Location = new System.Drawing.Point(6, 63);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(100, 20);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDeDatos.Properties.Resources.ArbolBInario;
            this.pictureBox1.Location = new System.Drawing.Point(14, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1136, 554);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.gbListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.ListBox lstArbolBinario;
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
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrden;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
    }
}