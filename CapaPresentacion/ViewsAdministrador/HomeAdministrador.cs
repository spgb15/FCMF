using CapaPresentacion.ViewsEstudiante;
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
    public partial class HomeAdministrador : Form
    {
        public HomeAdministrador()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void HomeAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresarDT_Click(object sender, EventArgs e)
        {
            FormDatosPersonalesAdmin formDatosPersonalesAdmin = new FormDatosPersonalesAdmin();
            formDatosPersonalesAdmin.Show();
        }

        private void btnIngresarCA_Click(object sender, EventArgs e)
        {
            FormCandidataAdmin formCandidataAdmin = new FormCandidataAdmin();
            formCandidataAdmin.Show();
        }

        private void btnIngresarU_Click(object sender, EventArgs e)
        {
            FormUsuarioAdmin formUsuario = new FormUsuarioAdmin();
            formUsuario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPerfilUsuario formPUsuario = new FormPerfilUsuario();
            formPUsuario.Show();
        }

        private void btnIngresarA_Click(object sender, EventArgs e)
        {
            FormAlbumAdmin formAlbumAdmin = new FormAlbumAdmin();
            formAlbumAdmin.Show();
        }

        private void btnIngresarF_Click(object sender, EventArgs e)
        {
            FormFotoAdmin formFotoAdmin = new FormFotoAdmin();
            formFotoAdmin.Show();
        }


        private void btnIgresarVF_Click(object sender, EventArgs e)
        {
            FormGanadoraFotogenia formGanadoraFotogenia = new FormGanadoraFotogenia();
            formGanadoraFotogenia.Show();
        }

        private void btnIngresarVR_Click(object sender, EventArgs e)
        {
            FormGanadoraReina formGanadoraReina = new FormGanadoraReina();
            formGanadoraReina.Show();
        }
    }
}
