namespace CapaPresentacion.ViewsAdministrador
{
    partial class FormCandidataAdmin
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCandidata = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbID_DP = new System.Windows.Forms.ComboBox();
            this.cmb_ID_RE = new System.Windows.Forms.ComboBox();
            this.txtPasa = new System.Windows.Forms.TextBox();
            this.txtHabi = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtAsp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEst = new System.Windows.Forms.ComboBox();
            this.dtpFechaRe = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(21, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(143, 314);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(269, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCandidata
            // 
            this.dgvCandidata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidata.Location = new System.Drawing.Point(435, 54);
            this.dgvCandidata.Name = "dgvCandidata";
            this.dgvCandidata.Size = new System.Drawing.Size(345, 283);
            this.dgvCandidata.TabIndex = 3;
            this.dgvCandidata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidata_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "id datos Personales";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id reinado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pasatiempos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Habilidades";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Intereses";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Aspiraciones";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fecha de Registro";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbID_DP
            // 
            this.cmbID_DP.FormattingEnabled = true;
            this.cmbID_DP.Location = new System.Drawing.Point(143, 54);
            this.cmbID_DP.Name = "cmbID_DP";
            this.cmbID_DP.Size = new System.Drawing.Size(121, 21);
            this.cmbID_DP.TabIndex = 12;
            this.cmbID_DP.SelectedIndexChanged += new System.EventHandler(this.cmbID_DP_SelectedIndexChanged);
            // 
            // cmb_ID_RE
            // 
            this.cmb_ID_RE.FormattingEnabled = true;
            this.cmb_ID_RE.Location = new System.Drawing.Point(143, 81);
            this.cmb_ID_RE.Name = "cmb_ID_RE";
            this.cmb_ID_RE.Size = new System.Drawing.Size(121, 21);
            this.cmb_ID_RE.TabIndex = 13;
            this.cmb_ID_RE.SelectedIndexChanged += new System.EventHandler(this.cmb_ID_RE_SelectedIndexChanged);
            // 
            // txtPasa
            // 
            this.txtPasa.Location = new System.Drawing.Point(143, 109);
            this.txtPasa.Name = "txtPasa";
            this.txtPasa.Size = new System.Drawing.Size(100, 20);
            this.txtPasa.TabIndex = 14;
            this.txtPasa.TextChanged += new System.EventHandler(this.txtPasa_TextChanged);
            // 
            // txtHabi
            // 
            this.txtHabi.Location = new System.Drawing.Point(143, 136);
            this.txtHabi.Name = "txtHabi";
            this.txtHabi.Size = new System.Drawing.Size(100, 20);
            this.txtHabi.TabIndex = 15;
            this.txtHabi.TextChanged += new System.EventHandler(this.txtHabi_TextChanged);
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(143, 163);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 20);
            this.txtInt.TabIndex = 16;
            this.txtInt.TextChanged += new System.EventHandler(this.txtInt_TextChanged);
            // 
            // txtAsp
            // 
            this.txtAsp.Location = new System.Drawing.Point(143, 190);
            this.txtAsp.Name = "txtAsp";
            this.txtAsp.Size = new System.Drawing.Size(100, 20);
            this.txtAsp.TabIndex = 17;
            this.txtAsp.TextChanged += new System.EventHandler(this.txtAsp_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Datos de Candidatas";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbEst
            // 
            this.cmbEst.FormattingEnabled = true;
            this.cmbEst.Items.AddRange(new object[] {
            "A",
            "I"});
            this.cmbEst.Location = new System.Drawing.Point(143, 216);
            this.cmbEst.Name = "cmbEst";
            this.cmbEst.Size = new System.Drawing.Size(121, 21);
            this.cmbEst.TabIndex = 21;
            this.cmbEst.SelectedIndexChanged += new System.EventHandler(this.cmbEst_SelectedIndexChanged);
            // 
            // dtpFechaRe
            // 
            this.dtpFechaRe.Location = new System.Drawing.Point(143, 243);
            this.dtpFechaRe.Name = "dtpFechaRe";
            this.dtpFechaRe.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRe.TabIndex = 22;
            this.dtpFechaRe.ValueChanged += new System.EventHandler(this.dtpFechaRe_ValueChanged);
            // 
            // FormCandidataAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
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
            this.Name = "FormCandidataAdmin";
            this.Text = "FormCandidataAdmin";
            this.Load += new System.EventHandler(this.FormCandidataAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCandidata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbID_DP;
        private System.Windows.Forms.ComboBox cmb_ID_RE;
        private System.Windows.Forms.TextBox txtPasa;
        private System.Windows.Forms.TextBox txtHabi;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtAsp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEst;
        private System.Windows.Forms.DateTimePicker dtpFechaRe;
    }
}