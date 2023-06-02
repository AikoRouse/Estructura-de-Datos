namespace pryEstructuraDeDatos
{
    partial class frmConsultaBD
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
            this.lblConsulta = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dgvBdD = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdD)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(12, 19);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(90, 13);
            this.lblConsulta.TabIndex = 0;
            this.lblConsulta.Text = "Consulta en SQL:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(16, 44);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(564, 151);
            this.txtConsulta.TabIndex = 1;
            // 
            // dgvBdD
            // 
            this.dgvBdD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBdD.Location = new System.Drawing.Point(16, 230);
            this.dgvBdD.Name = "dgvBdD";
            this.dgvBdD.Size = new System.Drawing.Size(564, 224);
            this.dgvBdD.TabIndex = 2;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(505, 201);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmConsultaBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 476);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvBdD);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblConsulta);
            this.Name = "frmConsultaBD";
            this.Text = "frmConsultaBD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBdD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dgvBdD;
        private System.Windows.Forms.Button btnListar;
    }
}