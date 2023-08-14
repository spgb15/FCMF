namespace CapaPresentacion.ViewsAdministrador
{
    partial class FormGanadoraFotogenia
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxFotogenia = new System.Windows.Forms.PictureBox();
            this.labelFotogenia = new System.Windows.Forms.Label();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.txtNombreFotogenia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotogenia)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ganadora de Miss Fotogenia";
            // 
            // pictureBoxFotogenia
            // 
            this.pictureBoxFotogenia.Location = new System.Drawing.Point(52, 88);
            this.pictureBoxFotogenia.Name = "pictureBoxFotogenia";
            this.pictureBoxFotogenia.Size = new System.Drawing.Size(278, 238);
            this.pictureBoxFotogenia.TabIndex = 2;
            this.pictureBoxFotogenia.TabStop = false;
            // 
            // labelFotogenia
            // 
            this.labelFotogenia.AutoSize = true;
            this.labelFotogenia.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFotogenia.Location = new System.Drawing.Point(385, 195);
            this.labelFotogenia.Name = "labelFotogenia";
            this.labelFotogenia.Size = new System.Drawing.Size(99, 31);
            this.labelFotogenia.TabIndex = 3;
            this.labelFotogenia.Text = "Puntaje";
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Enabled = false;
            this.txtPuntaje.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntaje.Location = new System.Drawing.Point(521, 195);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(100, 31);
            this.txtPuntaje.TabIndex = 4;
            // 
            // txtNombreFotogenia
            // 
            this.txtNombreFotogenia.Enabled = false;
            this.txtNombreFotogenia.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFotogenia.Location = new System.Drawing.Point(421, 111);
            this.txtNombreFotogenia.Name = "txtNombreFotogenia";
            this.txtNombreFotogenia.Size = new System.Drawing.Size(233, 34);
            this.txtNombreFotogenia.TabIndex = 5;
            // 
            // FormGanadoraFotogenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreFotogenia);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.labelFotogenia);
            this.Controls.Add(this.pictureBoxFotogenia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGanadoraFotogenia";
            this.Text = "FormGanadoraFotogenia";
            this.Load += new System.EventHandler(this.FormGanadoraFotogenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotogenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxFotogenia;
        private System.Windows.Forms.Label labelFotogenia;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.TextBox txtNombreFotogenia;
    }
}