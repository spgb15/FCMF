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
    public partial class FormPerfilUsuario : Form
    {
        private CN_GetData ObjectCN = new CN_GetData();
        Boolean isInsert = true;
        int id_perfilUsurio = 0;

        public FormPerfilUsuario()
        {
            InitializeComponent();
            GetComboModulo();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FormPerfilUsuario_Load(object sender, EventArgs e)
        {
            CargarDatosPerfilUsuario();
        }
        private void CargarDatosPerfilUsuario()
        {
            dgvPerfilUsuario.DataSource = ObjectCN.GetPerfilUsuario();
        }
        private void GetComboModulo()
        {

            foreach (DataRow row in ObjectCN.GetPerfilUsuario().Rows)
            {
                string columna1 = row["modulo"].ToString();
                cmbModulo.Items.Add(columna1);
                //Console.WriteLine($"Columna1: {columna1});
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInsert == true)
                {
                    ObjectCN.InsertarPerfilUsuario(cmbModulo.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se guardo correctamente");
                }
                else
                {
                    ObjectCN.ActualizarPerfilUsuario(id_perfilUsurio.ToString(), cmbModulo.Text, cmbEst.Text, dtpFechaRe.Value);
                    MessageBox.Show("Se actualizo correctamente");
                    isInsert = true;
                }
                CargarDatosPerfilUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPerfilUsuario.SelectedRows.Count > 0)
            {
                int indice = dgvPerfilUsuario.CurrentCell.RowIndex;
                cmbModulo.Text = dgvPerfilUsuario.Rows[indice].Cells[1].Value.ToString();
                cmbEst.Text = dgvPerfilUsuario.Rows[indice].Cells[3].Value.ToString();
                dtpFechaRe.Text = dgvPerfilUsuario.Rows[indice].Cells[4].Value.ToString();
                id_perfilUsurio = int.Parse(dgvPerfilUsuario.Rows[indice].Cells[0].Value.ToString());
                isInsert = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPerfilUsuario.SelectedRows.Count > 0)
            {
                int indice = dgvPerfilUsuario.CurrentCell.RowIndex;
                id_perfilUsurio = int.Parse(dgvPerfilUsuario.Rows[indice].Cells[0].Value.ToString());
                try
                {
                    ObjectCN.EliminarPerfilUsuario(id_perfilUsurio.ToString());
                    MessageBox.Show("Se elimino correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                CargarDatosPerfilUsuario();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la fila");
            }
        }
    }
}
