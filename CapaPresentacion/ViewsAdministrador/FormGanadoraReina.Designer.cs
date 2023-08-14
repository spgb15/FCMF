namespace CapaPresentacion.ViewsEstudiante
{
    partial class FormGanadoraReina
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxReina = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNombreReina = new System.Windows.Forms.TextBox();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ganadora de Reina de la Facultad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Puntaje";
            // 
            // pictureBoxReina
            // 
            this.pictureBoxReina.Location = new System.Drawing.Point(79, 85);
            this.pictureBoxReina.Name = "pictureBoxReina";
            this.pictureBoxReina.Size = new System.Drawing.Size(289, 247);
            this.pictureBoxReina.TabIndex = 5;
            this.pictureBoxReina.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNombreReina
            // 
            this.txtNombreReina.Enabled = false;
            this.txtNombreReina.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreReina.Location = new System.Drawing.Point(422, 114);
            this.txtNombreReina.Name = "txtNombreReina";
            this.txtNombreReina.Size = new System.Drawing.Size(227, 34);
            this.txtNombreReina.TabIndex = 8;
            this.txtNombreReina.UseSystemPasswordChar = true;
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntuacion.Location = new System.Drawing.Point(516, 193);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(100, 31);
            this.txtPuntuacion.TabIndex = 9;
            // 
            // FormGanadoraReina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.txtNombreReina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxReina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGanadoraReina";
            this.Text = "FormGanadorasConcurso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxReina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreReina;
        private System.Windows.Forms.TextBox txtPuntuacion;
    }
}