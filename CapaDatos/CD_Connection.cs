using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_connection
    {
        static string server = "DESKTOP-LRCIH65\\SQLEXPRESS"; //Nombre del servidor de la base de datos

        //String para hacer la conexion con la BD
        private SqlConnection conexion = new SqlConnection("Server=" + server + "; Database = DB_ReinaFacultad; Integrated Security=true");


        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
