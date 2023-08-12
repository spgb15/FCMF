namespace CapaPresentacion.ViewsGestor
{
    partial class FormDatosPersonalesGestor
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
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDatosPersonales = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminarDP = new System.Windows.Forms.Button();
            this.btnEditarDP = new System.Windows.Forms.Button();
            this.btnGuardarDP = new System.Windows.Forms.Button();
            this.dtpFechaReg = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTi = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersonales)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEst
            // 
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbEst.Location = new System.Drawing.Point(136, 369);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(121, 21);
            this.cmbEst.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Estado";
            // 
            // dgvDatosPersonales
            // 
            this.dgvDatosPersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPersonales.Location = new System.Drawing.Point(390, 61);
            this.dgvDatosPersonales.Name = "dgvDatosPersonales";
            this.dgvDatosPersonales.Size = new System.Drawing.Size(387, 393);
            this.dgvDatosPersonales.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(267, 12);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(229, 31);
            this.label9.TabIndex = 53;
            this.label9.Text = "Datos Personales";
            // 
            // btnEliminarDP
            // 
            this.btnEliminarDP.Location = new System.Drawing.Point(261, 444);
            this.btnEliminarDP.Name = "btnEliminarDP";
            this.btnEliminarDP.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDP.TabIndex = 49;
            this.btnEliminarDP.Text = "Eliminar";
            this.btnEliminarDP.UseVisualStyleBackColor = true;
            this.btnEliminarDP.Click += new System.EventHandler(this.btnEliminarDP_Click);
            // 
            // btnEditarDP
            // 
            this.btnEditarDP.Location = new System.Drawing.Point(24, 444);
            this.btnEditarDP.Name = "btnEditarDP";
            this.btnEditarDP.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDP.TabIndex = 48;
            this.btnEditarDP.Text = "Editar";
            this.btnEditarDP.UseVisualStyleBackColor = true;
            this.btnEditarDP.Click += new System.EventHandler(this.btnEditarDP_Click);
            // 
            // btnGuardarDP
            // 
            this.btnGuardarDP.Location = new System.Drawing.Point(147, 444);
            this.btnGuardarDP.Name = "btnGuardarDP";
            this.btnGuardarDP.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDP.TabIndex = 47;
            this.btnGuardarDP.Text = "Guardar";
            this.btnGuardarDP.UseVisualStyleBackColor = true;
            this.btnGuardarDP.Click += new System.EventHandler(this.btnGuardarDP_Click);
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.Location = new System.Drawing.Point(136, 404);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReg.TabIndex = 46;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(136, 112);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Fecha de Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Url de Foto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // txtTi
            // 
            this.txtTi.Location = new System.Drawing.Point(136, 329);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(100, 20);
            this.txtTi.TabIndex = 37;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(136, 283);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 20);
            this.txtUrl.TabIndex = 36;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(136, 239);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 35;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(136, 197);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 34;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(136, 155);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(100, 20);
            this.txtDir.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre";
            // 
            // FormDatosPersonalesGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 492);
            this.Controls.Add(this.cmbEst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDatosPersonales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminarDP);
            this.Controls.Add(this.btnEditarDP);
            this.Controls.Add(this.btnGuardarDP);
            this.Controls.Add(this.dtpFechaReg);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTi);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FormDatosPersonalesGestor";
            this.Text = "FormDatosPersonalesGestor";
            this.Load += new System.EventHandler(this.FormDatosPersonalesGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersonales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDatosPersonales;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminarDP;
        private System.Windows.Forms.Button btnEditarDP;
        private System.Windows.Forms.Button btnGuardarDP;
        private System.Windows.Forms.DateTimePicker dtpFechaReg;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTi;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
    }
}