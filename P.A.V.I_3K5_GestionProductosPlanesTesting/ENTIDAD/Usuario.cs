using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public bool Borrado { get; set; }

        public Usuario()
        {
            IdUsuario = 0;
            IdPerfil = 0;
            Nombre = "";
            Password = "";
            Email = "";
            Estado = "";
            Borrado = false;
        }
    }
}
