﻿using System;
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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" || txtPassword.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Hay campos vacíos", "Intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
