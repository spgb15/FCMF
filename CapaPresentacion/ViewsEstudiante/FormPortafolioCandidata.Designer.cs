﻿namespace CapaPresentacion.ViewsEstudiante
{
    partial class FormPortafolioCandidata
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
            this.Foto_Candidata = new System.Windows.Forms.PictureBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.telef = new System.Windows.Forms.Label();
            this.dirr = new System.Windows.Forms.Label();
            this.lbl_aspiraciones = new System.Windows.Forms.Label();
            this.lbl_interes = new System.Windows.Forms.Label();
            this.lbl_habilidades = new System.Windows.Forms.Label();
            this.pasatiemp = new System.Windows.Forms.Label();
            this.lbl_comentario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_comentarioRec = new System.Windows.Forms.Label();
            this.dgvComentario = new System.Windows.Forms.DataGridView();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtPasatiempos = new System.Windows.Forms.TextBox();
            this.txtHabilidades = new System.Windows.Forms.TextBox();
            this.txtIntereses = new System.Windows.Forms.TextBox();
            this.txtAspiraciones = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btn_izq = new System.Windows.Forms.Button();
            this.btn_der = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_Candidata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Login_Fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1104, 615);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Foto_Candidata
            // 
            this.Foto_Candidata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Foto_Candidata.Location = new System.Drawing.Point(25, 43);
            this.Foto_Candidata.Margin = new System.Windows.Forms.Padding(4);
            this.Foto_Candidata.Name = "Foto_Candidata";
            this.Foto_Candidata.Size = new System.Drawing.Size(329, 328);
            this.Foto_Candidata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto_Candidata.TabIndex = 1;
            this.Foto_Candidata.TabStop = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(20, 434);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(94, 25);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            this.lbl_nombre.UseMnemonic = false;
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(375, 42);
            this.fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(219, 25);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "Fecha de nacimiento:";
            this.fecha.UseMnemonic = false;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(794, 88);
            this.email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 25);
            this.email.TabIndex = 14;
            this.email.Text = "Mail:";
            // 
            // telef
            // 
            this.telef.AutoSize = true;
            this.telef.BackColor = System.Drawing.Color.Transparent;
            this.telef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telef.Location = new System.Drawing.Point(794, 43);
            this.telef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telef.Name = "telef";
            this.telef.Size = new System.Drawing.Size(104, 25);
            this.telef.TabIndex = 13;
            this.telef.Text = "Teléfono:";
            // 
            // dirr
            // 
            this.dirr.AutoSize = true;
            this.dirr.BackColor = System.Drawing.Color.Transparent;
            this.dirr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirr.Location = new System.Drawing.Point(392, 88);
            this.dirr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dirr.Name = "dirr";
            this.dirr.Size = new System.Drawing.Size(109, 25);
            this.dirr.TabIndex = 12;
            this.dirr.Text = "Dirección:";
            // 
            // lbl_aspiraciones
            // 
            this.lbl_aspiraciones.AutoSize = true;
            this.lbl_aspiraciones.BackColor = System.Drawing.Color.Transparent;
            this.lbl_aspiraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aspiraciones.Location = new System.Drawing.Point(392, 281);
            this.lbl_aspiraciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aspiraciones.Name = "lbl_aspiraciones";
            this.lbl_aspiraciones.Size = new System.Drawing.Size(144, 25);
            this.lbl_aspiraciones.TabIndex = 18;
            this.lbl_aspiraciones.Text = "Aspiraciones:";
            // 
            // lbl_interes
            // 
            this.lbl_interes.AutoSize = true;
            this.lbl_interes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_interes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interes.Location = new System.Drawing.Point(392, 232);
            this.lbl_interes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_interes.Name = "lbl_interes";
            this.lbl_interes.Size = new System.Drawing.Size(108, 25);
            this.lbl_interes.TabIndex = 17;
            this.lbl_interes.Text = "Intereses:";
            // 
            // lbl_habilidades
            // 
            this.lbl_habilidades.AutoSize = true;
            this.lbl_habilidades.BackColor = System.Drawing.Color.Transparent;
            this.lbl_habilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_habilidades.Location = new System.Drawing.Point(392, 185);
            this.lbl_habilidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_habilidades.Name = "lbl_habilidades";
            this.lbl_habilidades.Size = new System.Drawing.Size(132, 25);
            this.lbl_habilidades.TabIndex = 16;
            this.lbl_habilidades.Text = "Habilidades:";
            // 
            // pasatiemp
            // 
            this.pasatiemp.AutoSize = true;
            this.pasatiemp.BackColor = System.Drawing.Color.Transparent;
            this.pasatiemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasatiemp.Location = new System.Drawing.Point(392, 134);
            this.pasatiemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pasatiemp.Name = "pasatiemp";
            this.pasatiemp.Size = new System.Drawing.Size(143, 25);
            this.pasatiemp.TabIndex = 15;
            this.pasatiemp.Text = "Pasatiempos:";
            // 
            // lbl_comentario
            // 
            this.lbl_comentario.AutoSize = true;
            this.lbl_comentario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_comentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comentario.Location = new System.Drawing.Point(392, 331);
            this.lbl_comentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_comentario.Name = "lbl_comentario";
            this.lbl_comentario.Size = new System.Drawing.Size(130, 25);
            this.lbl_comentario.TabIndex = 20;
            this.lbl_comentario.Text = "Comentario:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(534, 334);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 27);
            this.textBox1.TabIndex = 21;
            // 
            // lbl_comentarioRec
            // 
            this.lbl_comentarioRec.AutoSize = true;
            this.lbl_comentarioRec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_comentarioRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comentarioRec.Location = new System.Drawing.Point(392, 382);
            this.lbl_comentarioRec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_comentarioRec.Name = "lbl_comentarioRec";
            this.lbl_comentarioRec.Size = new System.Drawing.Size(242, 25);
            this.lbl_comentarioRec.TabIndex = 22;
            this.lbl_comentarioRec.Text = "Comentarios Recientes:";
            // 
            // dgvComentario
            // 
            this.dgvComentario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComentario.Location = new System.Drawing.Point(391, 425);
            this.dgvComentario.Margin = new System.Windows.Forms.Padding(4);
            this.dgvComentario.Name = "dgvComentario";
            this.dgvComentario.ReadOnly = true;
            this.dgvComentario.RowHeadersWidth = 51;
            this.dgvComentario.Size = new System.Drawing.Size(689, 157);
            this.dgvComentario.TabIndex = 23;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(905, 44);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(175, 27);
            this.txtTel.TabIndex = 25;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(859, 90);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(221, 27);
            this.txtMail.TabIndex = 26;
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(508, 90);
            this.txtDir.Name = "txtDir";
            this.txtDir.ReadOnly = true;
            this.txtDir.Size = new System.Drawing.Size(279, 27);
            this.txtDir.TabIndex = 27;
            // 
            // txtPasatiempos
            // 
            this.txtPasatiempos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasatiempos.Location = new System.Drawing.Point(543, 136);
            this.txtPasatiempos.Name = "txtPasatiempos";
            this.txtPasatiempos.ReadOnly = true;
            this.txtPasatiempos.Size = new System.Drawing.Size(537, 27);
            this.txtPasatiempos.TabIndex = 28;
            // 
            // txtHabilidades
            // 
            this.txtHabilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabilidades.Location = new System.Drawing.Point(532, 187);
            this.txtHabilidades.Name = "txtHabilidades";
            this.txtHabilidades.ReadOnly = true;
            this.txtHabilidades.Size = new System.Drawing.Size(548, 27);
            this.txtHabilidades.TabIndex = 29;
            // 
            // txtIntereses
            // 
            this.txtIntereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntereses.Location = new System.Drawing.Point(508, 234);
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.ReadOnly = true;
            this.txtIntereses.Size = new System.Drawing.Size(572, 27);
            this.txtIntereses.TabIndex = 30;
            // 
            // txtAspiraciones
            // 
            this.txtAspiraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAspiraciones.Location = new System.Drawing.Point(544, 283);
            this.txtAspiraciones.Name = "txtAspiraciones";
            this.txtAspiraciones.ReadOnly = true;
            this.txtAspiraciones.Size = new System.Drawing.Size(536, 27);
            this.txtAspiraciones.TabIndex = 31;
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(619, 43);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(168, 27);
            this.txtFecha.TabIndex = 32;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNombre.Location = new System.Drawing.Point(129, 434);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(225, 30);
            this.txtNombre.TabIndex = 33;
            // 
            // btn_izq
            // 
            this.btn_izq.Location = new System.Drawing.Point(39, 386);
            this.btn_izq.Name = "btn_izq";
            this.btn_izq.Size = new System.Drawing.Size(95, 42);
            this.btn_izq.TabIndex = 34;
            this.btn_izq.Text = "Anterior";
            this.btn_izq.UseVisualStyleBackColor = true;
            this.btn_izq.Click += new System.EventHandler(this.btn_izq_Click);
            // 
            // btn_der
            // 
            this.btn_der.Location = new System.Drawing.Point(279, 386);
            this.btn_der.Name = "btn_der";
            this.btn_der.Size = new System.Drawing.Size(85, 42);
            this.btn_der.TabIndex = 35;
            this.btn_der.Text = "Siguiente";
            this.btn_der.UseVisualStyleBackColor = true;
            this.btn_der.Click += new System.EventHandler(this.btn_der_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 44);
            this.button1.TabIndex = 36;
            this.button1.Text = "←Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPortafolioCandidata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_der);
            this.Controls.Add(this.btn_izq);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtAspiraciones);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.txtHabilidades);
            this.Controls.Add(this.txtPasatiempos);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.dgvComentario);
            this.Controls.Add(this.lbl_comentarioRec);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_comentario);
            this.Controls.Add(this.lbl_aspiraciones);
            this.Controls.Add(this.lbl_interes);
            this.Controls.Add(this.lbl_habilidades);
            this.Controls.Add(this.pasatiemp);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telef);
            this.Controls.Add(this.dirr);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.Foto_Candidata);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPortafolioCandidata";
            this.Text = "FormPortafolioCandidata";
            this.Load += new System.EventHandler(this.FormPortafolioCandidata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_Candidata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Foto_Candidata;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label telef;
        private System.Windows.Forms.Label dirr;
        private System.Windows.Forms.Label lbl_aspiraciones;
        private System.Windows.Forms.Label lbl_interes;
        private System.Windows.Forms.Label lbl_habilidades;
        private System.Windows.Forms.Label pasatiemp;
        private System.Windows.Forms.Label lbl_comentario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_comentarioRec;
        private System.Windows.Forms.DataGridView dgvComentario;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtPasatiempos;
        private System.Windows.Forms.TextBox txtHabilidades;
        private System.Windows.Forms.TextBox txtIntereses;
        private System.Windows.Forms.TextBox txtAspiraciones;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btn_izq;
        private System.Windows.Forms.Button btn_der;
        private System.Windows.Forms.Button button1;
    }
}