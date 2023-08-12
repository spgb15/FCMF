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

namespace CapaPresentacion.ViewsGestor
{
    public partial class FormAlbumGestor : Form
    {
        private CN_GetData ObjectCN = new CN_GetData();
        Boolean isInsert = true;
        int id_album = 0;

        public FormAlbumGestor()
        {
            InitializeComponent();
            GetComboCandidata();
        }
        private void GetComboCandidata()
        {

            foreach (DataRow row in ObjectCN.GetCandidata().Rows)
            {
                string columna1 = row["id_candita"].ToString();
                cmbId_Can.Items.Add(columna1);
                //Console.WriteLine($"Columna1: {columna1});
            }

        }
        private void FormAlbumGestor_Load(object sender, EventArgs e)
        {
            CargarDatosAlbum();
        }
        private void CargarDatosAlbum()
        {
            dgvAlbum.DataSource = ObjectCN.GetAlbum();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInsert == true)
                {
                    MessageBox.Show("Usted no tiene el poder de ingresar datos");
                }
                else
                {
                    ObjectCN.ActualizarAlbum(id_album.ToString(), cmbId_Can.Text, txtNomAl.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se actualizo correctamente");
                    isInsert = true;
                }
                CargarDatosAlbum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlbum.SelectedRows.Count > 0)
            {
                int indice = dgvAlbum.CurrentCell.RowIndex;
                cmbId_Can.Text = dgvAlbum.Rows[indice].Cells[1].Value.ToString();
                txtNomAl.Text = dgvAlbum.Rows[indice].Cells[2].Value.ToString();
                cmbEst.Text = dgvAlbum.Rows[indice].Cells[3].Value.ToString();
                dtpFechaRe.Text = dgvAlbum.Rows[indice].Cells[4].Value.ToString();
                id_album = int.Parse(dgvAlbum.Rows[indice].Cells[0].Value.ToString());
                isInsert = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlbum.SelectedRows.Count > 0)
            {
                int indice = dgvAlbum.CurrentCell.RowIndex;
                id_album = int.Parse(dgvAlbum.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    ObjectCN.EliminarAlbum(id_album.ToString());
                    MessageBox.Show("Se elimino correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                CargarDatosAlbum();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }
    }
}
