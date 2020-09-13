using P.A.V.I_3K5_GestionProductosPlanesTesting.DAL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.BLL
{
    class UsuarioBLL
    {
        public static Usuario ValidarLogin(string nombreUsuario, string password)
        {
            return UsuarioDAL.ValidarLogin(nombreUsuario, password);
        }
    }
}
