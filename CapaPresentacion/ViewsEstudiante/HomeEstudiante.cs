using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsEstudiante
{
    public partial class HomeEstudiante : Form
    {
        public HomeEstudiante()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void HomeEstudiante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            // Crear un objeto Pen con el color y el grosor que desees para el borde
            Pen borderPen = new Pen(Color.Red, 4);

            // Obtener el tamaño del PictureBox
            int width = fondo.Width;
            int height = fondo.Height;

            // Dibujar el borde alrededor del PictureBox
            e.Graphics.DrawRectangle(borderPen, 0, 0, width - 1, height - 1);
        } 

        private Form formularioCandidata()
        {
            return new FormEstudianteVisitaCandidatas();
        }

        private void btn_MissFotogenica_Click(object sender, EventArgs e)
        {
            formularioCandidata().Show();
            this.Hide();
        }

        private void btn_Miss_Click(object sender, EventArgs e)
        {
            formularioCandidata().Show();
            this.Hide(); 
        }

        private void HomeEstudiante_Load(object sender, EventArgs e)
        {
            titulo_1.Parent = this.fondo;
            Subtitulo.Parent = this.fondo;
            titulo_1.BackColor = Color.Transparent;
            Subtitulo.BackColor = Color.Transparent;
            this.fondo.BackColor = Color.Transparent;

        }
    }
    }

