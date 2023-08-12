﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaDatos
{
    public class CD_ManageData
    {
        private CD_connection conn = new CD_connection();

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

        public bool InsertarComentarios(int id_foto, int id_estudiante, char estado, DateTime fechaReg)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "InsertarComentarios";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_fo", id_foto);
            cmd.Parameters.AddWithValue("@id_est", id_estudiante);
            cmd.Parameters.AddWithValue("@est", estado);
            cmd.Parameters.AddWithValue("@feRe", fechaReg);
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
        public DataTable ObtenerComentarios()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter;
            // abro conexion
            cmd.Connection = conn.AbrirConexion();
            // establezco el tipo de comamdo a store procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ObtenerComentarios";
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

    }
}

