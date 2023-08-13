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
            this.labelReina = new System.Windows.Forms.Label();
            this.pictureBoxReina = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            // labelReina
            // 
            this.labelReina.AutoSize = true;
            this.labelReina.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReina.Location = new System.Drawing.Point(373, 186);
            this.labelReina.Name = "labelReina";
            this.labelReina.Size = new System.Drawing.Size(93, 35);
            this.labelReina.TabIndex = 7;
            this.labelReina.Text = "label5";
            // 
            // pictureBoxReina
            // 
            this.pictureBoxReina.Location = new System.Drawing.Point(45, 85);
            this.pictureBoxReina.Name = "pictureBoxReina";
            this.pictureBoxReina.Size = new System.Drawing.Size(289, 247);
            this.pictureBoxReina.TabIndex = 5;
            this.pictureBoxReina.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormGanadoraReina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelReina);
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
        private System.Windows.Forms.Label labelReina;
    }
}