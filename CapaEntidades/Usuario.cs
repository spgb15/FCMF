using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }

        public string Nombres { get; set; }

        public string Username { get; set; }

        public string Mail { get; set; }

        public int Id_Perfil { get; set; }
    }
}
