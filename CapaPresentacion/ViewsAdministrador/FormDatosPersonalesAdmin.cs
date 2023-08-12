using CapaNegocios;
using CapaDatos;
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
    public partial class FormDatosPersonalesAdmin : Form
    {
        private CN_GetData ObjectCN = new CN_GetData();
        Boolean isInsert = true;
        int id_datosPersonales = 0;


        public FormDatosPersonalesAdmin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void CargarDatosPersonales()
        {
            dgvDatosPersonales.DataSource = ObjectCN.GetDatosPerosnales();
        }

        private void btnGuardarDP_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInsert == true) {
                    ObjectCN.InsertarDatosPer(txtNombre.Text, dtpFechaNac.Value, txtDir.Text, txtTel.Text, txtMail.Text, txtUrl.Text, txtTi.Text, cmbEst.Text, dtpFechaReg.Value);
                    MessageBox.Show("Se guardo correctamente");
                }
                else
                {
                    ObjectCN.ActualizarDatosPer(id_datosPersonales.ToString(), txtNombre.Text, dtpFechaNac.Value, txtDir.Text, txtTel.Text, txtMail.Text, txtUrl.Text, txtTi.Text, cmbEst.Text, dtpFechaReg.Value);
                    MessageBox.Show("Se actualizo correctamente");
                    isInsert = false;
                }
                CargarDatosPersonales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarDP_Click(object sender, EventArgs e)
        {
            if (dgvDatosPersonales.SelectedRows.Count > 0)
            {
                int indice = dgvDatosPersonales.CurrentCell.RowIndex;
                txtNombre.Text = dgvDatosPersonales.Rows[indice].Cells[1].Value.ToString();
                dtpFechaNac.Text = dgvDatosPersonales.Rows[indice].Cells[2].Value.ToString();
                txtDir.Text = dgvDatosPersonales.Rows[indice].Cells[3].Value.ToString();
                txtTel.Text = dgvDatosPersonales.Rows[indice].Cells[4].Value.ToString();
                txtMail.Text = dgvDatosPersonales.Rows[indice].Cells[5].Value.ToString();
                txtUrl.Text = dgvDatosPersonales.Rows[indice].Cells[6].Value.ToString();
                txtTi.Text = dgvDatosPersonales.Rows[indice].Cells[7].Value.ToString();
                cmbEst.Text = dgvDatosPersonales.Rows[indice].Cells[8].Value.ToString();
                dtpFechaReg.Text = dgvDatosPersonales.Rows[indice].Cells[9].Value.ToString();
                id_datosPersonales = int.Parse(dgvDatosPersonales.Rows[indice].Cells[0].Value.ToString());
                isInsert = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void btnEliminarDP_Click(object sender, EventArgs e)
        {
            if (dgvDatosPersonales.SelectedRows.Count > 0)
            {
                int indice = dgvDatosPersonales.CurrentCell.RowIndex;
                id_datosPersonales = int.Parse(dgvDatosPersonales.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    ObjectCN.ElimnarDatosPersonales(id_datosPersonales.ToString());
                    MessageBox.Show("Se elimino correctamente");

                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                }
                CargarDatosPersonales();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void FormDatosPersonalesAdmin_Load(object sender, EventArgs e)
        {
            CargarDatosPersonales();
        }
    }
}
