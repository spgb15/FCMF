using System.Drawing;

namespace CapaPresentacion.ViewsEstudiante
{
    partial class HomeEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeEstudiante));
            this.btn_MissFotogenica = new System.Windows.Forms.Button();
            this.btn_Miss = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MissFotogenica
            // 
            this.btn_MissFotogenica.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_MissFotogenica.BackgroundImage = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.btn_MissFotogenica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MissFotogenica.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_MissFotogenica.FlatAppearance.BorderSize = 3;
            this.btn_MissFotogenica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MissFotogenica.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MissFotogenica.ForeColor = System.Drawing.Color.Black;
            this.btn_MissFotogenica.Location = new System.Drawing.Point(83, 297);
            this.btn_MissFotogenica.Name = "btn_MissFotogenica";
            this.btn_MissFotogenica.Size = new System.Drawing.Size(211, 60);
            this.btn_MissFotogenica.TabIndex = 1;
            this.btn_MissFotogenica.Text = "Miss Fotogenia";
            this.btn_MissFotogenica.UseVisualStyleBackColor = false;
            // 
            // btn_Miss
            // 
            this.btn_Miss.BackgroundImage = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.btn_Miss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Miss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Miss.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Miss.FlatAppearance.BorderSize = 3;
            this.btn_Miss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Miss.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Miss.Location = new System.Drawing.Point(512, 297);
            this.btn_Miss.Name = "btn_Miss";
            this.btn_Miss.Size = new System.Drawing.Size(211, 60);
            this.btn_Miss.TabIndex = 4;
            this.btn_Miss.Text = "Miss FCMF";
            this.btn_Miss.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.BRD_Foto_MissFotogenia;
            this.pictureBox2.Location = new System.Drawing.Point(83, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 198);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CapaPresentacion.Properties.Resources.BRD_Foto_MissFCMF;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.BRD_Foto_MissFCMF;
            this.pictureBox3.Location = new System.Drawing.Point(512, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenidos a la elección de Reina del Facultad de Ciencias Matemáticas y Físicas" +
    " y Miss Fotogenia\n\nElige el reinado por el que quieres votar";
            // 
            // HomeEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Miss);
            this.Controls.Add(this.btn_MissFotogenica);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeEstudiante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeEstudiante_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_MissFotogenica;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Miss;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}