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
            this.fondo = new System.Windows.Forms.PictureBox();
            this.Subtitulo = new System.Windows.Forms.Label();
            this.titulo_1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
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
            this.btn_MissFotogenica.Click += new System.EventHandler(this.btn_MissFotogenica_Click);
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
            this.btn_Miss.Click += new System.EventHandler(this.btn_Miss_Click);
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
            // fondo
            // 
            this.fondo.BackColor = System.Drawing.Color.Transparent;
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Image = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(800, 450);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            this.fondo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Subtitulo
            // 
            this.Subtitulo.AutoSize = true;
            this.Subtitulo.BackColor = this.BackColor;
            this.Subtitulo.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtitulo.ForeColor = System.Drawing.Color.Black;
            this.Subtitulo.Location = new System.Drawing.Point(201, 397);
            this.Subtitulo.Name = "Subtitulo";
            this.Subtitulo.Size = new System.Drawing.Size(458, 31);
            this.Subtitulo.TabIndex = 7;
            this.Subtitulo.Text = "Elige el reinado por el que quieres votar\r\n";
            // 
            // titulo_1
            // 
            this.titulo_1.AutoSize = true;
            this.titulo_1.BackColor = this.BackColor;
            this.titulo_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titulo_1.Font = new System.Drawing.Font("Sitka Small", 10F, System.Drawing.FontStyle.Bold);
            this.titulo_1.ForeColor = System.Drawing.Color.White;
            this.titulo_1.Location = new System.Drawing.Point(23, 20);
            this.titulo_1.Name = "titulo_1";
            this.titulo_1.Size = new System.Drawing.Size(740, 20);
            this.titulo_1.TabIndex = 6;
            this.titulo_1.Text = "Bienvenidos a la elección de Reina de la Facultad de Ciencias Matemáticas y Físicas" +
    " y Miss Fotogenia\r\n";
            // 
            // HomeEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Subtitulo);
            this.Controls.Add(this.titulo_1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_Miss);
            this.Controls.Add(this.btn_MissFotogenica);
            this.Controls.Add(this.fondo);
            this.Name = "HomeEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeEstudiante";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeEstudiante_FormClosing);
            this.Load += new System.EventHandler(this.HomeEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Button btn_MissFotogenica;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_Miss;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Subtitulo;
        private System.Windows.Forms.Label titulo_1;
    }
}