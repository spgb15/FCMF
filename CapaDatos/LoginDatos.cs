using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class LoginDatos
    {
        private CD_connection conn = new CD_connection();

        public Usuario VerificarAcceso(string username, string contrasenia)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SELECT * FROM usuario WHERE username = '" + username + "' AND contrasenia = '" + contrasenia + "' AND  estado = 'A'";
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.CerrarConexion();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Usuario usuario = new Usuario
                {
                    Id_Usuario      = Convert.ToInt32(row["id_usuario"]),
                    Nombres         = row["nombres"].ToString(),
                    Id_Perfil       = Convert.ToInt32(row["id_perfil"])
                };

                return usuario;
            }
            else
            {
                return null;
            }
        }

    }
}
