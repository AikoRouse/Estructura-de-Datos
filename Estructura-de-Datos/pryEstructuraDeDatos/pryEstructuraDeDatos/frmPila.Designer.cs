namespace pryEstructuraDeDatos
{
    partial class frmPila
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.lblEliminarTramite = new System.Windows.Forms.Label();
            this.lblEliminarNombre = new System.Windows.Forms.Label();
            this.lblEliminarCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblTramiteE = new System.Windows.Forms.Label();
            this.lblNombreE = new System.Windows.Forms.Label();
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
            this.gbListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbEliminar.SuspendLayout();
            this.gbAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListar
            // 
            this.gbListar.Controls.Add(this.dataGridView1);
            this.gbListar.Controls.Add(this.lstCola);
            this.gbListar.Location = new System.Drawing.Point(11, 227);
            this.gbListar.Name = "gbListar";
            this.gbListar.Size = new System.Drawing.Size(643, 273);
            this.gbListar.TabIndex = 7;
            this.gbListar.TabStop = false;
            this.gbListar.Text = "Listado en una Lista y una Grilla";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dataGridView1.Location = new System.Drawing.Point(223, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(410, 244);
            this.dataGridView1.TabIndex = 1;
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
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(6, 21);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(211, 244);
            this.lstCola.TabIndex = 0;
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.lblEliminarTramite);
            this.gbEliminar.Controls.Add(this.lblEliminarNombre);
            this.gbEliminar.Controls.Add(this.lblEliminarCodigo);
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Controls.Add(this.lblTramiteE);
            this.gbEliminar.Controls.Add(this.lblNombreE);
            this.gbEliminar.Controls.Add(this.lblCodigoE);
            this.gbEliminar.Location = new System.Drawing.Point(440, 3);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(214, 218);
            this.gbEliminar.TabIndex = 6;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar elemento";
            // 
            // lblEliminarTramite
            // 
            this.lblEliminarTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEliminarTramite.Location = new System.Drawing.Point(102, 143);
            this.lblEliminarTramite.Name = "lblEliminarTramite";
            this.lblEliminarTramite.Size = new System.Drawing.Size(100, 23);
            this.lblEliminarTramite.TabIndex = 10;
            // 
            // lblEliminarNombre
            // 
            this.lblEliminarNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEliminarNombre.Location = new System.Drawing.Point(102, 85);
            this.lblEliminarNombre.Name = "lblEliminarNombre";
            this.lblEliminarNombre.Size = new System.Drawing.Size(100, 23);
            this.lblEliminarNombre.TabIndex = 9;
            // 
            // lblEliminarCodigo
            // 
            this.lblEliminarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEliminarCodigo.Location = new System.Drawing.Point(99, 28);
            this.lblEliminarCodigo.Name = "lblEliminarCodigo";
            this.lblEliminarCodigo.Size = new System.Drawing.Size(100, 23);
            this.lblEliminarCodigo.TabIndex = 8;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(53, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblTramiteE
            // 
            this.lblTramiteE.AutoSize = true;
            this.lblTramiteE.Location = new System.Drawing.Point(27, 144);
            this.lblTramiteE.Name = "lblTramiteE";
            this.lblTramiteE.Size = new System.Drawing.Size(56, 16);
            this.lblTramiteE.TabIndex = 6;
            this.lblTramiteE.Text = "Tramite:";
            // 
            // lblNombreE
            // 
            this.lblNombreE.AutoSize = true;
            this.lblNombreE.Location = new System.Drawing.Point(27, 86);
            this.lblNombreE.Name = "lblNombreE";
            this.lblNombreE.Size = new System.Drawing.Size(59, 16);
            this.lblNombreE.TabIndex = 5;
            this.lblNombreE.Text = "Nombre:";
            // 
            // lblCodigoE
            // 
            this.lblCodigoE.AutoSize = true;
            this.lblCodigoE.Location = new System.Drawing.Point(27, 28);
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
            this.gbAgregar.Location = new System.Drawing.Point(234, 3);
            this.gbAgregar.Name = "gbAgregar";
            this.gbAgregar.Size = new System.Drawing.Size(200, 218);
            this.gbAgregar.TabIndex = 5;
            this.gbAgregar.TabStop = false;
            this.gbAgregar.Text = "Agregar elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(93, 144);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 22);
            this.txtTramite.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(43, 174);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDeDatos.Properties.Resources.WhatsApp_Image_2023_03_31_at_10_31_10;
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(664, 510);
            this.Controls.Add(this.gbListar);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbAgregar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPila";
            this.Text = "Pila";
            this.gbListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbAgregar.ResumeLayout(false);
            this.gbAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.Label lblEliminarTramite;
        private System.Windows.Forms.Label lblEliminarNombre;
        private System.Windows.Forms.Label lblEliminarCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTramiteE;
        private System.Windows.Forms.Label lblNombreE;
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
    }
}