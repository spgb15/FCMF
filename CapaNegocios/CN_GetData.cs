using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using CapaDatos;
using System.Security.AccessControl;
using System.Net.NetworkInformation;
using System.ComponentModel;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_GetData


    {
        private CD_ManageData ObjectCD = new CD_ManageData();        
 

        public void InsertarDatosPer(string nombres, DateTime fechaNac, string direccion, string teléfono, string mail, string url_foto, string titulo, string estado, DateTime fechaReg)
        {

            ObjectCD.InsertarDatosPersonales(nombres, fechaNac, direccion, teléfono, mail, url_foto, titulo, char.Parse(estado), fechaReg);


        }
        public void ActualizarDatosPer(string id_datosPersonales, string nombres, DateTime fechaNac, string direccion, string teléfono, string mail, string url_foto, string titulo, string estado, DateTime fechaReg)
        {
            ObjectCD.ActualizarDatosPersonales(int.Parse(id_datosPersonales), nombres, fechaNac, direccion, teléfono, mail, url_foto, titulo, char.Parse(estado), fechaReg);
        }

        public void ElimnarDatosPersonales(string id_datosPersonales)
        {
            ObjectCD.EliminarDatosPersonales(int.Parse(id_datosPersonales));
        }
        public DataTable GetDatosPerosnales()
        {
            // Utiliza SP
            return ObjectCD.ObtenerDatosPersonales();
        }

        public DataTable GetComboDatosPerosnales()
        {
            // Utiliza SP
            return ObjectCD.ObtenerComboDatosPersonales();
        }

        public void InsertarCandidata(string id_datosPersonales, string id_reiando, string pasatiempos, string habilidades, string intereses, string aspiraciones, string estado, DateTime fechaReg)
        {

            ObjectCD.InsertarCandidata(int.Parse(id_datosPersonales), int.Parse(id_reiando), pasatiempos, habilidades, intereses, aspiraciones, char.Parse(estado), fechaReg);

        }
        public void ActualizarCandidata(string id_candidata, string id_datosPersonales, string id_reiando, string pasatiempos, string habilidades, string intereses, string aspiraciones, string estado, DateTime fechaReg)
        {
            ObjectCD.ActualizarCandidata(int.Parse(id_candidata), int.Parse(id_datosPersonales), int.Parse(id_reiando), pasatiempos, habilidades, intereses, aspiraciones, char.Parse(estado), fechaReg);
        }

        public void EliminarCandidata(string id_candidata)
        {
            ObjectCD.EliminarCandidata(int.Parse(id_candidata));
        }
        public DataTable GetCandidata()
        {
            // Utiliza SP
            return ObjectCD.ObtenerCandidata();
        }

        public void InsertarPerfilUsuario(string modulo, string estado, DateTime fechaReg)
        {

            ObjectCD.InsertarPerfilUsuario(modulo, char.Parse(estado), fechaReg);

        }
        public void ActualizarPerfilUsuario(string id_perfil, string modulo, string estado, DateTime fechaReg)
        {
            ObjectCD.ActualizarPerfilUsuario(int.Parse(id_perfil), modulo, char.Parse(estado), fechaReg);
        }

        public void EliminarPerfilUsuario(string id_perfil)
        {
            ObjectCD.EliminarCandidata(int.Parse(id_perfil));
        }
        public DataTable GetPerfilUsuario()
        {
            // Utiliza SP
            return ObjectCD.ObtenerPerfilUsuario();
        }

        public void InsertarUsuario(string nombres, string username, string contrasenia, string mail, string id_perfil, string estado, DateTime fechaReg)
        {

            ObjectCD.InsertarUsuario(nombres, username, contrasenia, mail, int.Parse(id_perfil), char.Parse(estado), fechaReg);

        }
        public void ActualizarUsuario(string id_usuario, string nombres, string username, string contrasenia, string mail, string id_perfil, string estado, DateTime fechaReg)
        {
            ObjectCD.ActualizarUsuario(int.Parse(id_usuario), nombres, username, contrasenia, mail, int.Parse(id_perfil), char.Parse(estado), fechaReg);
        }

        public void EliminarUsuario(string id_usuario)
        {
            ObjectCD.EliminarUsuario(int.Parse(id_usuario));
        }
        public DataTable GetUsuario()
        {
            // Utiliza SP
            return ObjectCD.ObtenerUsuario();
        }

        public void InsertarAlbum(string id_candidata, string nombreAlbum, string estado, DateTime fechaReg)
        {

            ObjectCD.InsertarAlbum(int.Parse(id_candidata), nombreAlbum, char.Parse(estado), fechaReg);

        }
        public void ActualizarAlbum(string id_album, string id_candidata, string nombreAlbum, string estado, DateTime fechaReg)
        {
            ObjectCD.ActualizarAlbum(int.Parse(id_album), int.Parse(id_candidata), nombreAlbum, char.Parse(estado), fechaReg);
        }

        public void EliminarAlbum(string id_album)
        {
            ObjectCD.EliminarAlbum(int.Parse(id_album));
        }
        public DataTable GetAlbum()
        {
            // Utiliza SP
            return ObjectCD.ObtenerAlbum();
        }

        public void InsertarFotos(string id_album, string id_candidata, string titulo, string descripcion, string url_foto, string estado, DateTime fechaReg)
        {

            ObjectCD.InsertarFotos(int.Parse(id_album), int.Parse(id_candidata), titulo, descripcion, url_foto, char.Parse(estado), fechaReg);

        }
        public void ActualizarFotos(string id_foto, string id_album, string id_candidata, string titulo, string descripcion, string url_foto, string estado, DateTime fechaReg)
        {
            ObjectCD.ActualizarFotos(int.Parse(id_foto), int.Parse(id_album), int.Parse(id_candidata), titulo, descripcion, url_foto, char.Parse(estado), fechaReg);
        }

        public void EliminarFoto(string id_foto)
        {
            ObjectCD.EliminarFoto(int.Parse(id_foto));
        }
        public DataTable GetFoto()
        {
            // Utiliza SP
            return ObjectCD.ObtenerFoto();
        }

        public void InsertarComentarios(int id_foto, int id_estudiante, string comentario)
        {

            ObjectCD.InsertarComentarios(id_foto, id_estudiante, comentario);

        }
        public void ActualizarComentarios(string id_comentarios, string id_foto, string id_estudiante, string estado, DateTime fechaReg)
        {
            ObjectCD.ActualizarComentarios(int.Parse(id_comentarios), int.Parse(id_foto), int.Parse(id_estudiante), char.Parse(estado), fechaReg);
        }

        public void EliminarComentarios(string id_comentarios)
        {
            ObjectCD.EliminarComentarios(int.Parse(id_comentarios));
        }
        public DataTable GetComentarios(int id_foto)
        {
            // Utiliza SP
            return ObjectCD.ObtenerComentarios(id_foto);

        }

        public DataTable GetReinado()
        {
            // Utiliza SP
            return ObjectCD.ObtenerReinado();

        }

        public List<string> ObtenerImagen(int reinado)
        {
            return ObjectCD.GetImagePaths(reinado);
        }

        public List<Candidata> ObtenerCandidata(int reinado)
        {
            return ObjectCD.ObtenerCandidatas( reinado);
        }

        public Candidata ObtenerDatos(int candita)
        {
            return ObjectCD.Datos(candita);
        }

        public List<string> ObtenerAlbumCandidata(int candita)
        {
            return ObjectCD.ObtenerAlbumCandidata(candita);
        }

        public int ObtenerIdFoto(string candita)
        {
            return ObjectCD.ObtenerIdFoto(candita);
        }

        public bool InsertarVoto(string voto, int id_cand, int id_est)
        {
            return ObjectCD.InsertarVoto(voto, id_cand, id_est);
        }

        public bool BuscarId(int usuario, string votacion)
        {
            return ObjectCD.BuscarIdEst(usuario, votacion);
        }
        

    }
}