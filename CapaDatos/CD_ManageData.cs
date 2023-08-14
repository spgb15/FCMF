using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CapaEntidades;
using System.Reflection;
using System.Security.Policy;
using System.IO;

namespace CapaDatos
{
    public class CD_ManageData
    {
        private CD_connection conn = new CD_connection();
        static string server = "DESKTOP-7AKP9MA"; //Nombre del servidor de la base de datos

        //String para hacer la conexion con la BD
        private string conexion = "Server=" + server + "; Database = DB_ReinaFacultad; Integrated Security=true";


        public bool InsertarDatosPersonales(string nombres, DateTime fechaNac, string direccion, string teléfono, string mail, string url_foto, string titulo, char estado, DateTime fechaReg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "InsertarDatosPersonales";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", nombres);
            cmd.Parameters.AddWithValue("@feNac", fechaNac);
            cmd.Parameters.AddWithValue("@dir", direccion);
            cmd.Parameters.AddWithValue("@tel", teléfono);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@url_foto", url_foto);
            cmd.Parameters.AddWithValue("@titu", titulo);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@nom, @feNac, @dir, @tel, @mail, @url_foto, @titu, @feRe
        }

        public bool ActualizarDatosPersonales(int id_datosPersonales, string nombres, DateTime fechaNac, string direccion, string teléfono, string mail, string url_foto, string titulo, char estado, DateTime fechaReg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "ModificarDatosPersonales";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_daPer", id_datosPersonales);
            cmd.Parameters.AddWithValue("@nom", nombres);
            cmd.Parameters.AddWithValue("@feNac", fechaNac);
            cmd.Parameters.AddWithValue("@dir", direccion);
            cmd.Parameters.AddWithValue("@tel", teléfono);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@url_foto", url_foto);
            cmd.Parameters.AddWithValue("@titu", titulo);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@nom, @feNac, @dir, @tel, @mail, @url_foto, @titu, @feRe
        }

        public DataTable ObtenerDatosPersonales()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerDatosPersonales";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public DataTable ObtenerComboDatosPersonales()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerComboDatosPersonales";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarDatosPersonales(int id_datosPersonales)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "EliminarDatosPersonales";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_datosPer", id_datosPersonales);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;

        }

        public bool InsertarCandidata(int id_datosPersonales, int id_reiando, string pasatiempos, string habilidades, string intereses, string aspiraciones, char estado, DateTime fechaReg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "InsertarCandidata";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_daPer", id_datosPersonales);
            cmd.Parameters.AddWithValue("@id_reinado", id_reiando);
            cmd.Parameters.AddWithValue("@pasti", pasatiempos);
            cmd.Parameters.AddWithValue("@habi", habilidades);
            cmd.Parameters.AddWithValue("@int", intereses);
            cmd.Parameters.AddWithValue("@asp", aspiraciones);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_daPer, @id_reinado, @pasti, @habi, @int, @asp, @est, @feRe
        }

        public bool ActualizarCandidata(int id_candidata, int id_datosPersonales, int id_reiando, string pasatiempos, string habilidades, string intereses, string aspiraciones, char estado, DateTime fechaReg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "ModificarCandidata";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_can", id_candidata);
            cmd.Parameters.AddWithValue("@id_daPer", id_datosPersonales);
            cmd.Parameters.AddWithValue("@id_reinado", id_reiando);
            cmd.Parameters.AddWithValue("@pasti", pasatiempos);
            cmd.Parameters.AddWithValue("@habi", habilidades);
            cmd.Parameters.AddWithValue("@int", intereses);
            cmd.Parameters.AddWithValue("@asp", aspiraciones);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@nom, @feNac, @dir, @tel, @mail, @url_foto, @titu, @feRe
        }
        //Trabaja con Store Procedure
        public DataTable ObtenerCandidata()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerCandidata";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarCandidata(int id_candidata)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "EliminarCandidata";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_can", id_candidata);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;

        }

        public bool InsertarPerfilUsuario(string modulo, char estado, DateTime fechaReg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "InsertarPerfilUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mod", modulo);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@mod, @est, @feRe
        }

        public bool ActualizarPerfilUsuario(int id_perfil, string modulo, char estado, DateTime fechaReg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "ModificarPerfilUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_per", id_perfil);
            cmd.Parameters.AddWithValue("@mod", modulo);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_per, @mod, @est, @feRe
        }
        //Trabaja con Store Procedure
        public DataTable ObtenerPerfilUsuario()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerPerfilUsuario";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarPerfilUsuario(int id_perfil)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "EliminarPerfilUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_per", id_perfil);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
        }

        public bool InsertarUsuario(string nombres, string username, string contrasenia, string mail, int id_perfil, char estado, DateTime fechaReg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "InsertarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", nombres);
            cmd.Parameters.AddWithValue("@userna", username);
            cmd.Parameters.AddWithValue("@cont", contrasenia);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@id_per", id_perfil);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@nom, @userna, @cont, @mail, @id_per, @est, @feRe
        }

        public bool ActualizarUsuario(int id_usuario, string nombres, string username, string contrasenia, string mail, int id_perfil, char estado, DateTime fechaReg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "ModificarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_usu", id_usuario);
            cmd.Parameters.AddWithValue("@nom", nombres);
            cmd.Parameters.AddWithValue("@userna", username);
            cmd.Parameters.AddWithValue("@cont", contrasenia);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@id_per", id_perfil);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_usu, @nom, @userna, @cont, @mail, @id_per, @est, @feRe
        }
        //Trabaja con Store Procedure
        public DataTable ObtenerUsuario()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerUsuario";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarUsuario(int id_usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "EliminarUsuario";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_usu", id_usuario);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;

        }

        public bool InsertarAlbum(int id_candidata, string nombreAlbum, char estado, DateTime fechaReg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "InsertarAlbum";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_can", id_candidata);
            cmd.Parameters.AddWithValue("@nomAl", nombreAlbum);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_can, @nomAl, @est, @feRe
        }

        public bool ActualizarAlbum(int id_album, int id_candidata, string nombreAlbum, char estado, DateTime fechaReg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "ModificarAlbum";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_al", id_album);
            cmd.Parameters.AddWithValue("@id_can", id_candidata);
            cmd.Parameters.AddWithValue("@nomAl", nombreAlbum);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@@id_al, @id_can, @nomAl, @est, @feRe
        }
        //Trabaja con Store Procedure
        public DataTable ObtenerAlbum()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerAlbum";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarAlbum(int id_album)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "EliminarAlbum";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_al", id_album);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
        }

        public bool InsertarFotos(int id_album, int id_candidata, string titulo, string descripcion, string url_foto, char estado, DateTime fechaReg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "InsertarFotos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_al", id_album);
            cmd.Parameters.AddWithValue("@id_can", id_candidata);
            cmd.Parameters.AddWithValue("@titu", titulo);
            cmd.Parameters.AddWithValue("@des", descripcion);
            cmd.Parameters.AddWithValue("@url_foto", url_foto);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_al, @id_can, @titu, @des, @url_foto, @est, @feRe
        }

        public bool ActualizarFotos(int id_foto, int id_album, int id_candidata, string titulo, string descripcion, string url_foto, char estado, DateTime fechaReg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "ModificarFotos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_fo", id_foto);
            cmd.Parameters.AddWithValue("@id_al", id_album);
            cmd.Parameters.AddWithValue("@id_can", id_candidata);
            cmd.Parameters.AddWithValue("@titu", titulo);
            cmd.Parameters.AddWithValue("@des", descripcion);
            cmd.Parameters.AddWithValue("@url_foto", url_foto);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_fo, @id_al, @id_can, @titu, @des, @url_foto, @est, @feRe
        }
        //Trabaja con Store Procedure
        public DataTable ObtenerFoto()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerFotos";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarFoto(int id_foto)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "EliminarFoto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_fo", id_foto);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;

        }

        public bool InsertarComentarios(int id_foto, int id_estudiante, string comentario)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "Insert Into comentarios (id_foto, id_estudiante, comentario) values ( " + id_foto + "," + id_estudiante + ", '" + comentario + "');";
;

            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_fo, @id_est, @est, @feRe
        }


        public bool ActualizarComentarios(int id_comentarios, int id_foto, int id_estudiante, char estado, DateTime fechaReg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "ModificarComentarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_com", id_comentarios);
            cmd.Parameters.AddWithValue("@id_fo", id_foto);
            cmd.Parameters.AddWithValue("@id_est", id_estudiante);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
            //@id_com, @id_fo, @id_est, @est, @feRe
        }
        //Trabaja con Store Procedure
        public DataTable ObtenerComentarios(int id_foto)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandText = "SELECT * FROM COMENTARIOS JOIN USUARIO ON id_estudiante = id_usuario WHERE ID_FOTO = " + id_foto + ";";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public bool EliminarComentarios(int id_comentarios)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "EliminarComentarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_com", id_comentarios);
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;

        }

        public DataTable ObtenerReinado()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerReinado";
            // ejecuto y asigno al adaptador
            adapter = new SqlDataAdapter(cmd);
            // asignar los resultados al datatable
            adapter.Fill(dt);
            return dt;
        }

        public List<string> GetImagePaths(int reinado)
        {
            List<string> paths = new List<string>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select url_foto from datosPersonales WHERE ID_DATOSPERSONALES = ANY (SELECT id_datosPersonales FROM candidata WHERE id_reinado = " + reinado + " );", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    paths.Add(reader.GetString(0));
                }
                reader.Close();
                conn.Close();
            }
            return paths;
        }
        

        public List<Candidata> ObtenerCandidatas(int reinado)
        {
            List<Candidata> candidatas = new List<Candidata>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT * FROM Candidata JOIN DatosPersonales ON Candidata.ID_DatosPersonales = DatosPersonales.id_datosPersonales WHERE id_reinado = " + reinado + " ;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            candidatas.Add(new Candidata
                            {
                                Id_candidata = Convert.ToInt32(reader["id_candita"]),
                                Id_datosPersonales = Convert.ToInt32(reader["id_datosPersonales"]),
                                Nombre = reader["nombres"].ToString(),
                                Id_reinado = Convert.ToInt32(reader["ID_Reinado"]),
                                Pasatiempo = reader["Pasatiempos"].ToString(),
                                Habilidades = reader["Habilidades"].ToString(),
                                Intereses = reader["Intereses"].ToString(),
                                Aspiraciones = reader["Aspiraciones"].ToString(),
                                Fecha_nac = reader["FechaNac"].ToString(),
                                Direccion = reader["direccion"].ToString(),
                                Telefono = reader["teléfono"].ToString(),
                                Mail = reader["mail"].ToString(),
                                Titulo = reader["Titulo"].ToString()
                            });                    
                        }
                    }
                }
                
            }
            return candidatas;
        }

        public Candidata Datos(int id_candita)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT * FROM Candidata JOIN DatosPersonales ON Candidata.ID_DatosPersonales = DatosPersonales.id_datosPersonales WHERE id_candita = " + id_candita + " ;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_candita", id_candita);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Candidata candidata = new Candidata
                            {
                                Id_datosPersonales = Convert.ToInt32(reader["id_datosPersonales"]),
                                Nombre = reader["nombres"].ToString(),
                                Id_reinado = Convert.ToInt32(reader["ID_Reinado"]),
                                Pasatiempo = reader["Pasatiempos"].ToString(),
                                Habilidades = reader["Habilidades"].ToString(),
                                Intereses = reader["Intereses"].ToString(),
                                Aspiraciones = reader["Aspiraciones"].ToString(),
                                Fecha_nac = reader["FechaNac"].ToString(),
                                Direccion = reader["direccion"].ToString(),
                                Telefono = reader["teléfono"].ToString(),
                                Mail = reader["mail"].ToString(),
                                Titulo = reader["Titulo"].ToString(),
                                Urls = reader["url_foto"].ToString()
                            };
                            return candidata;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }

            }
        }
        public List<string> ObtenerAlbumCandidata(int index)
        {
            List<string> paths = new List<string>();

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("ObtenerFotosCandidata", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramIdCandidata = new SqlParameter("@idCandidata", SqlDbType.Int);
                paramIdCandidata.Value = index;
                cmd.Parameters.Add(paramIdCandidata);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    paths.Add(reader.GetString(0));
                }
                reader.Close();
            }

            return paths;
        }

        public int ObtenerIdFoto(string UrlFoto)
        {
            int idFoto = -1;

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                string query = "SELECT id_foto FROM fotos WHERE url_foto = '" + UrlFoto + "';"; 

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        idFoto = Convert.ToInt32(result);
                    }
                }
            }

            return idFoto;
        }

        public bool InsertarVoto(string votacion ,int id_cand, int id_est)
        {

            string query = "INSERT INTO " + votacion +"(id_candita, id_usuario) VALUES (" + id_cand + ',' + id_est + ");";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.CerrarConexion();
            return true;
        }

        public bool BuscarIdEst(int id, string votacion)
        {
            string query = "SELECT * FROM " + votacion + " WHERE id_usuario = @id";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    // Ejecutar la consulta y obtener el resultado escalar
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si count es mayor que cero, significa que el ID se encontró en la tabla
                    return count > 0;
                }
            }
        }

        public int BuscarVoto(int id, string votacion)
        {
            string query = "SELECT COUNT(*) as voto FROM " + votacion + " WHERE id_candita = @id";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    // Ejecutar la consulta y obtener el resultado escalar
                    int count = (int)cmd.ExecuteScalar();
                    return count;
                }
            }
        }



    }

}


