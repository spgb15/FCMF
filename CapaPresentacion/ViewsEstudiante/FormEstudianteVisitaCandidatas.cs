using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsEstudiante
{
    public partial class FormEstudianteVisitaCandidatas : Form
    {
        Candidata candidatas = new Candidata();
        CN_GetData candidatura = new CN_GetData();


        private List<string> imagenPaths;
        private int currentIndex = 0;

        private CN_GetData datos = new CN_GetData();
        private int parametro;
        private int id_candidata;
        public FormEstudianteVisitaCandidatas( int parametro)
        {
            InitializeComponent();
            this.MaximizeBox = false;  
            this.MinimizeBox = false;
            this.parametro = parametro;
            
        }


        private void FormEstudianteVisitaCandidatas_Load(object sender, EventArgs e)
        {
            this.btn_izq.Parent = this.pictureBox1;
            this.btn_der.Parent = this.pictureBox1;
            this.btn_izq.BackColor = Color.Transparent;
            this.btn_der.BackColor = Color.Transparent;
            CN_GetData candidata = new CN_GetData();
            List<Candidata> candidatas = candidata.ObtenerCandidata(parametro);
            
            

            imagenPaths = datos.ObtenerImagen(parametro);

            if(imagenPaths.Count > 0)
            {
                LoadImageByIndex(currentIndex);




            }
            else
            {
                System.Windows.MessageBox.Show("No se encontraron imagenes en la carpeta");
            }


        }

        private void LoadImageByIndex(int index)
        {
            List<Candidata> candidatas = candidatura.ObtenerCandidata(parametro);

            if (index >= 0 && index < imagenPaths.Count)
            {
                pictureBox2.Image = Image.FromFile(imagenPaths[index]);
                txtNombre.Text = candidatas[index].Nombre;
                txtEdad.Text = DateTime.Parse(candidatas[index].Fecha_nac).ToString("dd/MM/yyyy");
                id_candidata = Convert.ToInt32(candidatas[index].Id_candidata);            }
        }

        private void btn_der_Click_1(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
        }

        private void btn_izq_Click_1(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagenPaths.Count) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
        }

        private Form HomeEstudianteview()
        {
            return new HomeEstudiante();
        }



        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            HomeEstudiante ventana = new HomeEstudiante();
            ventana.Show();
            this.Hide();
        }



        private void btn_Portafolio_Click(object sender, EventArgs e)
        {
            FormPortafolioCandidata portafolio = new FormPortafolioCandidata();
            portafolio.candidataId = id_candidata;
            portafolio.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
