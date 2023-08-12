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
    public partial class FormUsuarioAdmin : Form
    {
        private CN_GetData ObjectCN = new CN_GetData();
        Boolean isInsert = true;
        int id_usuario = 0;

        public FormUsuarioAdmin()
        {
            InitializeComponent();
            GetComboPerfilUsuario();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInsert == true)
                {
                    ObjectCN.InsertarUsuario(txtNom.Text, txtUser.Text, txtCon.Text, txtMail.Text, cmbID_PU.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se guardo correctamente");
                }
                else
                {
                    ObjectCN.ActualizarUsuario(id_usuario.ToString(), txtNom.Text, txtUser.Text, txtCon.Text, txtMail.Text, cmbID_PU.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se actualizo correctamente");
                    isInsert = true;
                }
                CargarDatosUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetComboPerfilUsuario()
        {

            foreach (DataRow row in ObjectCN.GetPerfilUsuario().Rows)
            {
                string columna1 = row["id_perfil"].ToString();
                cmbID_PU.Items.Add(columna1);
                //Console.WriteLine($"Columna1: {columna1});
            }

        }

        private void FormUsuarioAdmin_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }
        private void CargarDatosUsuario()
        {
            dgvUsuario.DataSource = ObjectCN.GetUsuario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                int indice = dgvUsuario.CurrentCell.RowIndex;
                txtNom.Text = dgvUsuario.Rows[indice].Cells[1].Value.ToString();
                txtUser.Text = dgvUsuario.Rows[indice].Cells[2].Value.ToString();
                txtCon.Text = dgvUsuario.Rows[indice].Cells[3].Value.ToString();
                txtMail.Text = dgvUsuario.Rows[indice].Cells[4].Value.ToString();
                cmbID_PU.Text = dgvUsuario.Rows[indice].Cells[5].Value.ToString();
                cmbEst.Text = dgvUsuario.Rows[indice].Cells[6].Value.ToString();
                dtpFechaRe.Text = dgvUsuario.Rows[indice].Cells[7].Value.ToString();
                id_usuario = int.Parse(dgvUsuario.Rows[indice].Cells[0].Value.ToString());
                isInsert = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.SelectedRows.Count > 0)
            {
                int indice = dgvUsuario.CurrentCell.RowIndex;
                id_usuario = int.Parse(dgvUsuario.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    ObjectCN.EliminarUsuario(id_usuario.ToString());
                    MessageBox.Show("Se elimino correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                CargarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }
    }
}
