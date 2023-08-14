using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


    namespace CapaEntidades
    {
        public class Candidata
        {
            public int Id_candidata { get; set; }
            public int Id_datosPersonales { get; set; }
            public int Id_reinado { get; set; }
            public string Nombre { get; set; }
            public string Pasatiempo { get; set; }
            public string Habilidades { get; set; }
            public string Intereses { get; set; }
            public string Aspiraciones { get; set; }
            public string Fecha_nac { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
            public string Mail { get; set; }
            public string Titulo { get; set; }

            public string Urls { get; set; }
    }
    }
