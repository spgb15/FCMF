namespace CapaPresentacion.ViewsEstudiante
{
    partial class FormEstudianteVisitaCandidatas
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
            this.btn_der = new System.Windows.Forms.PictureBox();
            this.btn_izq = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.btn_Portafolio = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_der)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_izq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_der
            // 
            this.btn_der.BackColor = System.Drawing.Color.Transparent;
            this.btn_der.Image = global::CapaPresentacion.Properties.Resources.boton_de_flecha_derecha_del_teclado;
            this.btn_der.Location = new System.Drawing.Point(930, 191);
            this.btn_der.Name = "btn_der";
            this.btn_der.Size = new System.Drawing.Size(102, 139);
            this.btn_der.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_der.TabIndex = 2;
            this.btn_der.TabStop = false;
            this.btn_der.Click += new System.EventHandler(this.btn_der_Click_1);
            // 
            // btn_izq
            // 
            this.btn_izq.BackColor = System.Drawing.Color.Transparent;
            this.btn_izq.Image = global::CapaPresentacion.Properties.Resources.pngwing_com;
            this.btn_izq.Location = new System.Drawing.Point(12, 191);
            this.btn_izq.Name = "btn_izq";
            this.btn_izq.Size = new System.Drawing.Size(102, 139);
            this.btn_izq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_izq.TabIndex = 1;
            this.btn_izq.TabStop = false;
            this.btn_izq.Click += new System.EventHandler(this.btn_izq_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(153, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(531, 151);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(94, 25);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre:";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(531, 281);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(228, 25);
            this.Edad.TabIndex = 5;
            this.Edad.Text = "Fecha de Nacimiento: ";
            // 
            // btn_Portafolio
            // 
            this.btn_Portafolio.BackgroundImage = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.btn_Portafolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Portafolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Portafolio.Location = new System.Drawing.Point(536, 395);
            this.btn_Portafolio.Name = "btn_Portafolio";
            this.btn_Portafolio.Size = new System.Drawing.Size(459, 88);
            this.btn_Portafolio.TabIndex = 6;
            this.btn_Portafolio.Text = "Entrar al portafolio! 😊😍";
            this.btn_Portafolio.UseVisualStyleBackColor = true;
            this.btn_Portafolio.Click += new System.EventHandler(this.btn_Portafolio_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(632, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(313, 30);
            this.txtNombre.TabIndex = 7;
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtEdad.Location = new System.Drawing.Point(765, 278);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(140, 30);
            this.txtEdad.TabIndex = 8;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.Location = new System.Drawing.Point(24, 492);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(202, 38);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "← Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // FormEstudianteVisitaCandidatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btn_Portafolio);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_der);
            this.Controls.Add(this.btn_izq);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEstudianteVisitaCandidatas";
            this.Text = "FormEstudianteVisitaCandidatas";
            this.Load += new System.EventHandler(this.FormEstudianteVisitaCandidatas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_der)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_izq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_izq;
        private System.Windows.Forms.PictureBox btn_der;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Button btn_Portafolio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnRegresar;
    }
}