using CapaDatos;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsAdministrador
{
    public partial class FormCandidataAdmin : Form
    {
        private CN_GetData ObjectCN = new CN_GetData();
        Boolean isInsert = true;
        int id_candidata = 0;

        public FormCandidataAdmin()
        {
            InitializeComponent();
            GetComboDatosPersonales();
            GetComboIdReinado();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormCandidataAdmin_Load(object sender, EventArgs e)
        {
            CargarDatosCandidatas();        
        }
        private void CargarDatosCandidatas()
        {
            dgvCandidata.DataSource = ObjectCN.GetCandidata();
        }
        private void GetComboDatosPersonales()
        {
           
            foreach (DataRow row in ObjectCN.GetComboDatosPerosnales().Rows)
            {
                string columna1 = row["id_datosPersonales"].ToString();
                string columna2 = row["nombres"].ToString();
                cmbID_DP.Items.Add(columna1+" "+columna2);
                //Console.WriteLine($"Columna1: {columna1}, Columna2: {columna2}");
            }
            
        }

        private void GetComboIdReinado()
        {

            foreach (DataRow row in ObjectCN.GetReinado().Rows)
            {
                string columna1 = row["id_reinado"].ToString();
                string columna2 = row["nombreReinado"].ToString();
                cmb_ID_RE.Items.Add(columna1);
                cmb_ID_RE.Items.Add(columna2);
                //Console.WriteLine($"Columna1: {columna1}, Columna2: {columna2}");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInsert == true)
                {
                    ObjectCN.InsertarCandidata(cmbID_DP.Text,cmb_ID_RE.Text, txtPasa.Text, txtHabi.Text, txtInt.Text, txtAsp.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se guardo correctamente");
                }
                else
                {
                    ObjectCN.ActualizarCandidata(id_candidata.ToString(), cmbID_DP.Text, cmb_ID_RE.Text, txtPasa.Text, txtHabi.Text, txtInt.Text, txtAsp.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se actualizo correctamente");
                    isInsert = true;
                }
                CargarDatosCandidatas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCandidata.SelectedRows.Count > 0)
            {
                int indice = dgvCandidata.CurrentCell.RowIndex;
                cmbID_DP.Text = dgvCandidata.Rows[indice].Cells[1].Value.ToString();
                cmb_ID_RE.Text = dgvCandidata.Rows[indice].Cells[2].Value.ToString();
                txtPasa.Text = dgvCandidata.Rows[indice].Cells[3].Value.ToString();
                txtHabi.Text = dgvCandidata.Rows[indice].Cells[4].Value.ToString();
                txtInt.Text = dgvCandidata.Rows[indice].Cells[5].Value.ToString();
                txtAsp.Text = dgvCandidata.Rows[indice].Cells[6].Value.ToString();
                cmbEst.Text = dgvCandidata.Rows[indice].Cells[7].Value.ToString();
                dtpFechaRe.Text = dgvCandidata.Rows[indice].Cells[8].Value.ToString();
                id_candidata = int.Parse(dgvCandidata.Rows[indice].Cells[0].Value.ToString());
                isInsert = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCandidata.SelectedRows.Count > 0)
            {
                int indice = dgvCandidata.CurrentCell.RowIndex;
                id_candidata = int.Parse(dgvCandidata.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    ObjectCN.EliminarCandidata(id_candidata.ToString());
                    MessageBox.Show("Se elimino correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                CargarDatosCandidatas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void cmbEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtAsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHabi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPasa_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_ID_RE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbID_DP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCandidata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpFechaRe_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
