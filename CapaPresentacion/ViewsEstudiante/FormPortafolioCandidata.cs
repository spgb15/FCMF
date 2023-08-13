using CapaEntidades;
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

namespace CapaPresentacion.ViewsEstudiante
{
    public partial class FormPortafolioCandidata : Form
    {
        CN_GetData Datos = new CN_GetData();
        Candidata candidatas = new Candidata();

        private List<string> imagenPaths;
        private int currentIndex = 0;


        public int candidataId { get; set; }
        
        public FormPortafolioCandidata()
        {
            InitializeComponent();
        }

        private void FormPortafolioCandidata_Load(object sender, EventArgs e)
        {
            //Se establece el parent del fondo
            this.lbl_nombre.Parent = this.pictureBox1;
            this.fecha.Parent = this.pictureBox1;
            this.telef.Parent = this.pictureBox1;
            this.dirr.Parent = this.pictureBox1;
            this.email.Parent = this.pictureBox1;
            this.pasatiemp.Parent = this.pictureBox1;
            this.lbl_habilidades.Parent = this.pictureBox1;
            this.lbl_interes.Parent = this.pictureBox1;
            this.lbl_aspiraciones.Parent = this.pictureBox1;
            this.lbl_comentario.Parent = this.pictureBox1;
            this.lbl_comentarioRec.Parent = this.pictureBox1;

            //Se establece transparencia
            this.lbl_nombre.BackColor = Color.Transparent;
            this.fecha.BackColor = Color.Transparent;
            this.telef.BackColor = Color.Transparent;
            this.dirr.BackColor = Color.Transparent;
            this.email.BackColor = Color.Transparent;
            this.pasatiemp.BackColor = Color.Transparent;
            this.lbl_habilidades.BackColor = Color.Transparent;
            this.lbl_interes.BackColor = Color.Transparent;
            this.lbl_aspiraciones.BackColor = Color.Transparent;
            this.lbl_comentario.BackColor = Color.Transparent;
            this.lbl_comentarioRec.BackColor = Color.Transparent;
            Candidata cand = Datos.ObtenerDatos(candidataId);

            //Llenar los campos
            txtNombre.Text = cand.Nombre;
            txtFecha.Text = DateTime.Parse(cand.Fecha_nac).ToString("dd/MM/yyyy");
            txtTel.Text = cand.Telefono;
            txtDir.Text = cand.Direccion;
            txtMail.Text = cand.Mail;
            txtPasatiempos.Text = cand.Pasatiempo;
            txtHabilidades.Text = cand.Habilidades;
            txtIntereses.Text = cand.Intereses;
            txtAspiraciones.Text = cand.Aspiraciones;


            imagenPaths = Datos.ObtenerAlbumCandidata(candidataId);

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

        List<string> candidatas = Datos.ObtenerAlbumCandidata(index);

            if (index >= 0 && index < imagenPaths.Count)
            {
                Foto_Candidata.Image = Image.FromFile(imagenPaths[index]);
            }
        }

        private void btn_izq_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagenPaths.Count) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
        }

        private void btn_der_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeEstudiante formulario = new HomeEstudiante();
            formulario.Show();
            this.Hide();
        }
    }
}
