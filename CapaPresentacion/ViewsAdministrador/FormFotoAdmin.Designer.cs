namespace CapaPresentacion.ViewsAdministrador
{
    partial class FormFotoAdmin
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
            this.cmbIdAlbum = new System.Windows.Forms.ComboBox();
            this.cmbIdCan = new System.Windows.Forms.ComboBox();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.dgvFoto = new System.Windows.Forms.DataGridView();
            this.dtpFechaRe = new System.Windows.Forms.DateTimePicker();
            this.txtTitu = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtUrlF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIdAlbum
            // 
            this.cmbIdAlbum.FormattingEnabled = true;
            this.cmbIdAlbum.Location = new System.Drawing.Point(198, 88);
            this.cmbIdAlbum.Name = "cmbIdAlbum";
            this.cmbIdAlbum.Size = new System.Drawing.Size(121, 21);
            this.cmbIdAlbum.TabIndex = 0;
            // 
            // cmbIdCan
            // 
            this.cmbIdCan.FormattingEnabled = true;
            this.cmbIdCan.Location = new System.Drawing.Point(198, 115);
            this.cmbIdCan.Name = "cmbIdCan";
            this.cmbIdCan.Size = new System.Drawing.Size(121, 21);
            this.cmbIdCan.TabIndex = 1;
            // 
            // cmbEst
            // 
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Location = new System.Drawing.Point(198, 220);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(121, 21);
            this.cmbEst.TabIndex = 2;
            // 
            // dgvFoto
            // 
            this.dgvFoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoto.Location = new System.Drawing.Point(430, 31);
            this.dgvFoto.Name = "dgvFoto";
            this.dgvFoto.Size = new System.Drawing.Size(358, 311);
            this.dgvFoto.TabIndex = 3;
            // 
            // dtpFechaRe
            // 
            this.dtpFechaRe.Location = new System.Drawing.Point(198, 247);
            this.dtpFechaRe.Name = "dtpFechaRe";
            this.dtpFechaRe.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRe.TabIndex = 4;
            // 
            // txtTitu
            // 
            this.txtTitu.Location = new System.Drawing.Point(198, 142);
            this.txtTitu.Name = "txtTitu";
            this.txtTitu.Size = new System.Drawing.Size(100, 20);
            this.txtTitu.TabIndex = 5;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(198, 168);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 6;
            // 
            // txtUrlF
            // 
            this.txtUrlF.Location = new System.Drawing.Point(198, 194);
            this.txtUrlF.Name = "txtUrlF";
            this.txtUrlF.Size = new System.Drawing.Size(100, 20);
            this.txtUrlF.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "id_album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "id de Candidata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "url de la foto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha de Registro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Datos de Foto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(33, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(150, 319);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(262, 319);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormFotoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrlF);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtTitu);
            this.Controls.Add(this.dtpFechaRe);
            this.Controls.Add(this.dgvFoto);
            this.Controls.Add(this.cmbEst);
            this.Controls.Add(this.cmbIdCan);
            this.Controls.Add(this.cmbIdAlbum);
            this.Name = "FormFotoAdmin";
            this.Text = "FormFotoAdmin";
            this.Load += new System.EventHandler(this.FormFotoAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdAlbum;
        private System.Windows.Forms.ComboBox cmbIdCan;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.DataGridView dgvFoto;
        private System.Windows.Forms.DateTimePicker dtpFechaRe;
        private System.Windows.Forms.TextBox txtTitu;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtUrlF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}