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
    }
}
