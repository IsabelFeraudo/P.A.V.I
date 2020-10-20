using P.A.V.I_3K5_GestionProductosPlanesTesting.DAL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.BLL
{
    public class CasosDePruebaBLL
    {
        public static List<CasosDePruebaEntidad> SelectAll()
        {
            return CasosDePruebaDAL.SelectAll();
        }

        public static void UpdateCasoPrueba(int idCasoPrueba, int idPlanPrueba, string titulo, string descripcion, int idResponsable)
        {
            CasosDePruebaDAL.UpdateCasoPrueba(idCasoPrueba, idPlanPrueba, titulo, descripcion, idResponsable);
        }
        public static void InsertCasoPrueba(int idCasoPrueba, int idPlanPrueba, string titulo, string descripcion, int idResponsable)
        {
            CasosDePruebaDAL.InsertCasoPrueba(idCasoPrueba, idPlanPrueba, titulo, descripcion, idResponsable);
        }
        public static string DeleteCasoPrueba(int idProyecto)
        {
            return CasosDePruebaDAL.DeleteCasoPrueba(idProyecto);
        }
    }
}