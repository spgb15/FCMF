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
        public FormPortafolioCandidata()
        {
            InitializeComponent();
        }

        private void FormPortafolioCandidata_Load(object sender, EventArgs e)
        {
            this.label9.Parent = this.pictureBox1;
            this.label9.BackColor = Color.Transparent;
        }
    }
}
