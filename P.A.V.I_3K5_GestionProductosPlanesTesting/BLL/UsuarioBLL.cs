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
        public static Usuario ValidarLogin(string nombreUsuario, string password)
        {
            return UsuarioDAL.ValidarLogin(nombreUsuario, password);
        }
        
        public static Usuario SelectModificarUsuario(int id)
        {
            return UsuarioDAL.SelectModificarUsuario(id);
        }
        
        public static void UpdateUsuario(int id, string nombre, string perfil, string password, string email)
        {
            UsuarioDAL.UpdateUsuario(id, nombre, perfil, password, email);
        }
        public static Usuario ValidarLogeado()
        {
            return UsuarioDAL.ValidarLogeado();
        }
    }
}
