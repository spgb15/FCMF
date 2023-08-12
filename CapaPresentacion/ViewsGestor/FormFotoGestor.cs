using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsGestor
{
    public partial class FormFotoGestor : Form
    {
        private CN_GetData ObjectCN = new CN_GetData();
        Boolean isInsert = true;
        int id_foto = 0;

        public FormFotoGestor()
        {
            InitializeComponent();
            GetComboAlbum();
            GetComboCandidata();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormFotoGestor_Load(object sender, EventArgs e)
        {
            CargarDatosFotos();
        }
        private void CargarDatosFotos()
        {
            dgvFoto.DataSource = ObjectCN.GetFoto();
        }
        private void GetComboAlbum()
        {

            foreach (DataRow row in ObjectCN.GetAlbum().Rows)
            {
                string columna1 = row["id_album"].ToString();
                cmbIdAlbum.Items.Add(columna1);
                //Console.WriteLine($"Columna1: {columna1});
            }

        }
        private void GetComboCandidata()
        {

            foreach (DataRow row in ObjectCN.GetCandidata().Rows)
            {
                string columna1 = row["id_candita"].ToString();
                cmbIdCan.Items.Add(columna1);
                //Console.WriteLine($"Columna1: {columna1});
            }

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
                    ObjectCN.ActualizarFotos(id_foto.ToString(), cmbIdAlbum.Text, cmbIdCan.Text, txtTitu.Text, txtDesc.Text, txtUrlF.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se actualizo correctamente");
                    isInsert = true;
                }
                CargarDatosFotos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFoto.SelectedRows.Count > 0)
            {
                isInsert = false;
                int indice = dgvFoto.CurrentCell.RowIndex;
                cmbIdAlbum.Text = dgvFoto.Rows[indice].Cells[1].Value.ToString();
                cmbIdCan.Text = dgvFoto.Rows[indice].Cells[2].Value.ToString();
                txtTitu.Text = dgvFoto.Rows[indice].Cells[3].Value.ToString();
                txtDesc.Text = dgvFoto.Rows[indice].Cells[4].Value.ToString();
                txtUrlF.Text = dgvFoto.Rows[indice].Cells[5].Value.ToString();
                cmbEst.Text = dgvFoto.Rows[indice].Cells[6].Value.ToString();
                dtpFechaRe.Text = dgvFoto.Rows[indice].Cells[7].Value.ToString();
                id_foto = int.Parse(dgvFoto.Rows[indice].Cells[0].Value.ToString());

            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFoto.SelectedRows.Count > 0)
            {
                int indice = dgvFoto.CurrentCell.RowIndex;
                id_foto = int.Parse(dgvFoto.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    ObjectCN.EliminarFoto(id_foto.ToString());
                    MessageBox.Show("Se elimino correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                CargarDatosFotos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }
    }
}
