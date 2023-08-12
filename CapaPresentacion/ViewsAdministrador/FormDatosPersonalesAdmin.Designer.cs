using CapaDatos;
using System.Windows.Forms;
using System;

namespace CapaPresentacion.ViewsAdministrador
{
    partial class FormDatosPersonalesAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersonales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEst);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dgvDatosPersonales);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnEliminarDP);
            this.panel1.Controls.Add(this.btnEditarDP);
            this.panel1.Controls.Add(this.btnGuardarDP);
            this.panel1.Controls.Add(this.dtpFechaReg);
            this.panel1.Controls.Add(this.dtpFechaNac);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTi);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.txtDir);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 480);
            this.panel1.TabIndex = 1;
            // 
            // cmbEst
            // 
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbEst.Location = new System.Drawing.Point(138, 366);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(121, 21);
            this.cmbEst.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Estado";
            // 
            // dgvDatosPersonales
            // 
            this.dgvDatosPersonales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosPersonales.Location = new System.Drawing.Point(392, 58);
            this.dgvDatosPersonales.Name = "dgvDatosPersonales";
            this.dgvDatosPersonales.Size = new System.Drawing.Size(387, 393);
            this.dgvDatosPersonales.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(269, 9);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(229, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Datos Personales";
            // 
            // btnEliminarDP
            // 
            this.btnEliminarDP.Location = new System.Drawing.Point(263, 441);
            this.btnEliminarDP.Name = "btnEliminarDP";
            this.btnEliminarDP.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarDP.TabIndex = 20;
            this.btnEliminarDP.Text = "Eliminar";
            this.btnEliminarDP.UseVisualStyleBackColor = true;
            this.btnEliminarDP.Click += new System.EventHandler(this.btnEliminarDP_Click);
            // 
            // btnEditarDP
            // 
            this.btnEditarDP.Location = new System.Drawing.Point(149, 441);
            this.btnEditarDP.Name = "btnEditarDP";
            this.btnEditarDP.Size = new System.Drawing.Size(75, 23);
            this.btnEditarDP.TabIndex = 19;
            this.btnEditarDP.Text = "Editar";
            this.btnEditarDP.UseVisualStyleBackColor = true;
            this.btnEditarDP.Click += new System.EventHandler(this.btnEditarDP_Click);
            // 
            // btnGuardarDP
            // 
            this.btnGuardarDP.Location = new System.Drawing.Point(26, 441);
            this.btnGuardarDP.Name = "btnGuardarDP";
            this.btnGuardarDP.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarDP.TabIndex = 18;
            this.btnGuardarDP.Text = "Guardar";
            this.btnGuardarDP.UseVisualStyleBackColor = true;
            this.btnGuardarDP.Click += new System.EventHandler(this.btnGuardarDP_Click);
            // 
            // dtpFechaReg
            // 
            this.dtpFechaReg.Location = new System.Drawing.Point(138, 401);
            this.dtpFechaReg.Name = "dtpFechaReg";
            this.dtpFechaReg.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReg.TabIndex = 17;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(138, 109);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha de Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Url de Foto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // txtTi
            // 
            this.txtTi.Location = new System.Drawing.Point(138, 326);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(100, 20);
            this.txtTi.TabIndex = 7;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(138, 280);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 20);
            this.txtUrl.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(138, 236);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(138, 194);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 4;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(138, 152);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(100, 20);
            this.txtDir.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // FormDatosPersonalesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.panel1);
            this.Name = "FormDatosPersonalesAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDatosPersonalesAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosPersonales)).EndInit();
            this.ResumeLayout(false);

        }




        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DateTimePicker dtpFechaReg;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminarDP;
        private System.Windows.Forms.Button btnEditarDP;
        private System.Windows.Forms.Button btnGuardarDP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDatosPersonales;
        private ComboBox cmbEst;
        private Label label10;
    }
}