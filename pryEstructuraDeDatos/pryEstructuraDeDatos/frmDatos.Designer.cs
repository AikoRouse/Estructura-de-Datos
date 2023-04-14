namespace pryEstructuraDeDatos
{
    partial class frmDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(223, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Camila Alej. Peralta Roure";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDni.Location = new System.Drawing.Point(223, 79);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(116, 17);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI: 42855094";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.BackColor = System.Drawing.Color.Transparent;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarrera.Location = new System.Drawing.Point(223, 117);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(159, 17);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Analista de Sistemas";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Transparent;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMateria.Location = new System.Drawing.Point(223, 159);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(153, 17);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Estructura de Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::pryEstructuraDeDatos.Properties.Resources._6ecb17a8_6f75_4ced_b2d4_ad3c7217406a;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(463, 221);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Programador";
            this.Load += new System.EventHandler(this.frmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblMateria;
    }
}