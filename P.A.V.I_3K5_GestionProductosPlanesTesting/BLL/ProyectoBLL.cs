using P.A.V.I_3K5_GestionProductosPlanesTesting.DAL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.BLL
{
    public class ProyectoBLL
    {
        public static List<Proyecto> SelectAll()
        {
            return ProyectoDAL.SelectAll();
        }

        public static void UpdateProyecto(int idProyecto, int idProducto, string descripcion, string version, string alcance, int idResponsable)
        {
            ProyectoDAL.UpdateProyecto(idProyecto, idProducto, descripcion, version, alcance, idResponsable);
        }
        public static void InsertProyecto(int idProyecto, int idProducto, string descripcion, string version, string alcance, int idResponsable)
        {
            ProyectoDAL.InsertProyecto(idProyecto,idProducto, descripcion, version, alcance, idResponsable);
        }
        public static string DeleteProyecto(int idProyecto)
        {
            return ProyectoDAL.DeleteProyecto(idProyecto);
        }
    }
}
