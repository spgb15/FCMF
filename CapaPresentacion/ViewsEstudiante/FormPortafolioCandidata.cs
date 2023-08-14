using CapaEntidades;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ViewsEstudiante
{
    public partial class FormPortafolioCandidata : Form
    {
        CN_GetData Datos = new CN_GetData();
        Candidata Candidatura = new Candidata();
        Usuario usuario = new Usuario();

        private List<string> imagenPaths;
        private int currentIndex = 0;

        foto fotos = new foto();

        



        public int candidataId { get; set; }
        public int Id_estudiante { get; set; }

        private string urls;

        bool exitoso = false;

        public FormPortafolioCandidata()
        {
            InitializeComponent();
        }

        private void FormPortafolioCandidata_Load(object sender, EventArgs e)
        {
            idEstudiante.id_candidata = candidataId;
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
                urls = imagenPaths[index];
                CargarComentariosEnDataGridView();

            }
        }

        private void btn_izq_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + imagenPaths.Count) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
            txtComentario.Clear();
        }

        private void btn_der_Click(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % imagenPaths.Count;
            LoadImageByIndex(currentIndex);
            txtComentario.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeEstudiante formulario = new HomeEstudiante();
            formulario.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string comentario = txtComentario.Text;
            int id_foto = Datos.ObtenerIdFoto(urls);
            int id_usuario = idEstudiante.IdEstudiante;
            Datos.InsertarComentarios(id_foto, id_usuario, comentario);
            txtComentario.Clear();
            CargarComentariosEnDataGridView();



        }

        private void CargarComentariosEnDataGridView()
        {
            int id_foto = Datos.ObtenerIdFoto(urls);

            DataTable comentariosTable = Datos.GetComentarios(id_foto); // Obtén los comentarios para el id_foto

            dgvComentario.Columns.Clear(); // Limpiar las columnas existentes

            // Configurar AutoGenerateColumns en false
            dgvComentario.AutoGenerateColumns = false;


            // Crear la columna del nombre en el DataGridView
            DataGridViewTextBoxColumn nombreColumn = new DataGridViewTextBoxColumn();
            nombreColumn.HeaderText = "Nombre";
            nombreColumn.DataPropertyName = "NOMBRES"; // El nombre de la columna en el DataTable
            nombreColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvComentario.Columns.Add(nombreColumn);

            // Crear la columna del comentario en el DataGridView
            DataGridViewTextBoxColumn comentarioColumn = new DataGridViewTextBoxColumn();
            comentarioColumn.HeaderText = "Comentario";
            comentarioColumn.DataPropertyName = "Comentario"; // El nombre de la columna en el DataTable
            comentarioColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvComentario.Columns.Add(comentarioColumn);

            // Asignar el DataTable al DataGridView
            dgvComentario.DataSource = comentariosTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_votacion = idEstudiante.votacion;
            int id_est = idEstudiante.IdEstudiante;
            string voto = string.Empty;
            switch (id_votacion) 
            {
                case 1:
                    voto = "votacionFotogenia";
                    break;
                case 2:
                    voto = "votacionReina";
                    break;
            }

            exitoso = Datos.InsertarVoto(voto, candidataId, id_est);

            if (exitoso)
            { 
                MessageBox.Show("Gracias por tu voto ❤");
                HomeEstudiante home = new HomeEstudiante();
                home.Show();
                this.Hide();
            }
        }
    }
}
