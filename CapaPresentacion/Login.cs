using CapaEntidades;
using CapaNegocios;
using CapaPresentacion.ViewsAdministrador;
using CapaPresentacion.ViewsEstudiante;
using CapaPresentacion.ViewsGestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        LoginNegocio neg = new LoginNegocio();
        private int usua;


        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Login - Sistema de eleccion de reina";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private Form AbriForm(int perfil)
        {
            switch (perfil)
            {
                case 1:
                    return new HomeAdministrador();

                case 2:
                    return new HomeGestor();

                case 3:
                    return new HomeEstudiante();

                default:
                    throw new ArgumentException("Perfil no válido");
            }
        }

            private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" || txtPassword.Text != "")
            {
                Usuario usuario = neg.Login(txtUser.Text, txtPassword.Text);
                if (usuario != null)
                {
                    int perfil = usuario.Id_Perfil;
                    idEstudiante.IdEstudiante = usuario.Id_Usuario;
                    AbriForm(perfil).Show();
                    this.Hide();
                }
                else
                {
                    txtUser.Clear();
                    txtPassword.Clear();    
                    MessageBox.Show("Usuario no exíste", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacíos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
        }
    }
}
