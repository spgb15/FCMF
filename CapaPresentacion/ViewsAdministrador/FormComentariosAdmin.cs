using CapaDatos;
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

namespace CapaPresentacion.ViewsAdministrador
{
    public partial class FormComentariosAdmin : Form
    {
        private CN_GetData ObjectCN = new CN_GetData();
        Boolean isInsert = true;
        int id_comentarios = 0;

        public FormComentariosAdmin()
        {
            InitializeComponent();
            GetComboFoto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInsert == true)
                {
                    ObjectCN.InsertarComentarios(cmbIDFoto.Text, cmbIDEst.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se guardo correctamente");
                }
                else
                {
                    ObjectCN.ActualizarComentarios(id_comentarios.ToString(), cmbIDFoto.Text, cmbIDEst.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se actualizo correctamente");
                    isInsert = true;
                }
                CargarDatosComentarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetComboFoto()
        {

            foreach (DataRow row in ObjectCN.GetFoto().Rows)
            {
                string columna1 = row["id_foto"].ToString();
                cmbIDFoto.Items.Add(columna1);
                //Console.WriteLine($"Columna1: {columna1});
            }

        }

        private void FormComentariosAdmin_Load(object sender, EventArgs e)
        {
            CargarDatosComentarios();
        }
        private void CargarDatosComentarios()
        {
            dgvComentarios.DataSource = ObjectCN.GetComentarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvComentarios.SelectedRows.Count > 0)
            {
                int indice = dgvComentarios.CurrentCell.RowIndex;
                cmbIDFoto.Text = dgvComentarios.Rows[indice].Cells[1].Value.ToString();
                cmbIDEst.Text = dgvComentarios.Rows[indice].Cells[2].Value.ToString();
                cmbEst.Text = dgvComentarios.Rows[indice].Cells[3].Value.ToString();
                dtpFechaRe.Text = dgvComentarios.Rows[indice].Cells[4].Value.ToString();
                id_comentarios = int.Parse(dgvComentarios.Rows[indice].Cells[0].Value.ToString());
                isInsert = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComentarios.SelectedRows.Count > 0)
            {
                int indice = dgvComentarios.CurrentCell.RowIndex;
                id_comentarios = int.Parse(dgvComentarios.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    ObjectCN.EliminarComentarios(id_comentarios.ToString());
                    MessageBox.Show("Se elimino correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                CargarDatosComentarios();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }
    }
}
