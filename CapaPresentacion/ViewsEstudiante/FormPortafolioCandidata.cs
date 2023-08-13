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
            Foto_Candidata.Image = Image.FromFile(cand.Url);

        }

    }
}
