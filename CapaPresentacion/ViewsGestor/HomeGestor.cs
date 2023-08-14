using CapaPresentacion.ViewsAdministrador;
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

namespace CapaPresentacion.ViewsGestor
{
    public partial class HomeGestor : Form
    {
        public HomeGestor()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void HomeGestor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresarDT_Click(object sender, EventArgs e)
        {
            FormDatosPersonalesGestor formDatosPersonalesGestor = new FormDatosPersonalesGestor();
            formDatosPersonalesGestor.Show();
        }

        private void btnIngresarCA_Click(object sender, EventArgs e)
        {
            FormCandidataGestor formCandidataGestor = new FormCandidataGestor();
            formCandidataGestor.Show();
        }

        private void btnIngresarF_Click(object sender, EventArgs e)
        {
            FormFotoGestor formFotoGestor = new FormFotoGestor();
            formFotoGestor.Show();
        }

        private void btnIngresarA_Click(object sender, EventArgs e)
        {
            FormAlbumGestor formAlbumGestor = new FormAlbumGestor();
            formAlbumGestor.Show();
        }

        private void btnIngresarCO_Click(object sender, EventArgs e)
        {
            FormComentariosGestor formComentariosGestor = new FormComentariosGestor();
            formComentariosGestor.Show();
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
