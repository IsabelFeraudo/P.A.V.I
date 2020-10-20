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
        public static List<ProyectoEntidad> SelectAll()
        {
            return ProyectoDAL.SelectAll();
        }

        public static ProyectoEntidad UpdateProyecto(string descripcion, string version, string alcance, int idResponsable)
        {
            return ProyectoDAL.UpdateProyecto(descripcion, version, alcance, idResponsable);
        }
        public static ProyectoEntidad InsertProyecto(int id_proyecto, int id_producto, string descripcion, string version, string alcance, int id_responsable,bool borrado)
        {
            return ProyectoDAL.InsertProyecto(id_proyecto, id_producto, descripcion, version, alcance, id_responsable, false);
        }
        public static string DeleteProyecto(int idProyecto)
        {
            return ProyectoDAL.DeleteProyecto(idProyecto);
        }

        public static List<ProyectoEntidad> SelectDoc()
        {
            return ProyectoDAL.SelectDoc();
        }

        public static ProyectoEntidad SelectProyecto(int id)
        {
            return ProyectoDAL.SelectProyecto(id);
        }
    }
}