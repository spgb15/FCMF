namespace CapaPresentacion.ViewsGestor
{
    partial class FormCandidataGestor
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
            this.dtpFechaRe = new System.Windows.Forms.DateTimePicker();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAsp = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtHabi = new System.Windows.Forms.TextBox();
            this.txtPasa = new System.Windows.Forms.TextBox();
            this.cmb_ID_RE = new System.Windows.Forms.ComboBox();
            this.cmbID_DP = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCandidata = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaRe
            // 
            this.dtpFechaRe.Location = new System.Drawing.Point(135, 241);
            this.dtpFechaRe.Name = "dtpFechaRe";
            this.dtpFechaRe.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRe.TabIndex = 43;
            // 
            // cmbEst
            // 
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbEst.Location = new System.Drawing.Point(135, 214);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(121, 21);
            this.cmbEst.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Datos de Candidatas";
            // 
            // txtAsp
            // 
            this.txtAsp.Location = new System.Drawing.Point(135, 188);
            this.txtAsp.Name = "txtAsp";
            this.txtAsp.Size = new System.Drawing.Size(100, 20);
            this.txtAsp.TabIndex = 40;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(135, 161);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 20);
            this.txtInt.TabIndex = 39;
            // 
            // txtHabi
            // 
            this.txtHabi.Location = new System.Drawing.Point(135, 134);
            this.txtHabi.Name = "txtHabi";
            this.txtHabi.Size = new System.Drawing.Size(100, 20);
            this.txtHabi.TabIndex = 38;
            // 
            // txtPasa
            // 
            this.txtPasa.Location = new System.Drawing.Point(135, 107);
            this.txtPasa.Name = "txtPasa";
            this.txtPasa.Size = new System.Drawing.Size(100, 20);
            this.txtPasa.TabIndex = 37;
            // 
            // cmb_ID_RE
            // 
            this.cmb_ID_RE.FormattingEnabled = true;
            this.cmb_ID_RE.Location = new System.Drawing.Point(135, 79);
            this.cmb_ID_RE.Name = "cmb_ID_RE";
            this.cmb_ID_RE.Size = new System.Drawing.Size(121, 21);
            this.cmb_ID_RE.TabIndex = 36;
            // 
            // cmbID_DP
            // 
            this.cmbID_DP.FormattingEnabled = true;
            this.cmbID_DP.Location = new System.Drawing.Point(135, 52);
            this.cmbID_DP.Name = "cmbID_DP";
            this.cmbID_DP.Size = new System.Drawing.Size(121, 21);
            this.cmbID_DP.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Fecha de Registro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Aspiraciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Intereses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Habilidades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pasatiempos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id reinado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "id datos Personales";
            // 
            // dgvCandidata
            // 
            this.dgvCandidata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidata.Location = new System.Drawing.Point(427, 52);
            this.dgvCandidata.Name = "dgvCandidata";
            this.dgvCandidata.Size = new System.Drawing.Size(345, 283);
            this.dgvCandidata.TabIndex = 26;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(261, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(135, 312);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormCandidataGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 354);
            this.Controls.Add(this.dtpFechaRe);
            this.Controls.Add(this.cmbEst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAsp);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtHabi);
            this.Controls.Add(this.txtPasa);
            this.Controls.Add(this.cmb_ID_RE);
            this.Controls.Add(this.cmbID_DP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCandidata);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormCandidataGestor";
            this.Text = "FormCandidataGestor";
            this.Load += new System.EventHandler(this.FormCandidataGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaRe;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAsp;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtHabi;
        private System.Windows.Forms.TextBox txtPasa;
        private System.Windows.Forms.ComboBox cmb_ID_RE;
        private System.Windows.Forms.ComboBox cmbID_DP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCandidata;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
    }
}