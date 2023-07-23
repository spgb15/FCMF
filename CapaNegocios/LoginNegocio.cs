using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class LoginNegocio
    {
        LoginDatos datos = new LoginDatos();

        public Usuario Login(string username, string contrasenia)
        {
            return datos.VerificarAcceso(username, contrasenia);
        }
    }
}
