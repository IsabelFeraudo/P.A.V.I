using P.A.V.I_3K5_GestionProductosPlanesTesting.DAL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.BLL
{
    public class UsuarioBLL
    {
        public static UsuarioEntidad ValidarLogin(string nombreUsuario, string password)
        {
            return UsuarioDAL.ValidarLogin(nombreUsuario, password);
        }
        
        public static UsuarioEntidad SelectModificarUsuario(int id)
        {
            return UsuarioDAL.SelectModificarUsuario(id);
        }
        
        public static void UpdateUsuario(int id, string nombre, string perfil, string password, string email)
        {
            UsuarioDAL.UpdateUsuario(id, nombre, perfil, password, email);
        }
        public static UsuarioEntidad ValidarLogeado()
        {
            return UsuarioDAL.ValidarLogeado();
        }

        public static List<UsuarioEntidad> SelectAll()
        {
            return UsuarioDAL.SelectAll();
        }
    }
}
