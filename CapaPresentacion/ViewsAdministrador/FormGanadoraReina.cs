using CapaDatos;
using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsEstudiante
{
    public partial class FormGanadoraReina : Form
    {
        private CD_connection conn = new CD_connection();
        private List<string> imagenPaths;
        private int currentIndex = 0;
        private int parametro;

        private CN_GetData datos = new CN_GetData();
        public FormGanadoraReina()
        {
            InitializeComponent();
        }

       


        private void FormGanadoraReina_Load(object sender, EventArgs e)
        {
            this.label1.Parent = this.pictureBox1;
            this.label1.BackColor = Color.Transparent;
            imagenPaths = datos.ObtenerImagen(1);

            if (imagenPaths.Count > 0)
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
            List<Candidata> candidatas = datos.ObtenerCandidata(2);

            if (index >= 0 && index < imagenPaths.Count)
            {
                pictureBoxReina.Image = Image.FromFile(imagenPaths[index]);
                txtNombreReina.Text = candidatas[index].Nombre;
                int voto = candidatas[index].Id_candidata;
                txtPuntuacion.Text = datos.BuscarVoto(voto, "votacionReina").ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagenPaths.Count) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            currentIndex = (currentIndex + 1) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
        }
    }

    }

