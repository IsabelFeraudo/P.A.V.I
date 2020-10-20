using P.A.V.I_3K5_GestionProductosPlanesTesting.DAL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.BLL
{
    public class PruebaDetalleBLL
    {
        public static List<PruebaDetalleEntidad> SelectAll()
        {
            return PruebaDetalleDAL.SelectAll();
        }

        public static void UpdateCicloPruebaDetalle(int idciclopruebadetalle, int idcicloprueba, int idcasoprueba, int idusuariotester, int cantidadhoras, int fechaejecucion)
        {
            PruebaDetalleDAL.UpdateCicloPruebaDetalle(idciclopruebadetalle,idcicloprueba,idcasoprueba,idusuariotester,cantidadhoras,fechaejecucion);
        }
        public static void InsertPrueba(int idciclopruebadetalle, int idcicloprueba, int idcasoprueba, int idusuariotester, int cantidadhoras, int fechaejecucion)
        {
            PruebaDetalleDAL.InsertPrueba(idciclopruebadetalle, idcicloprueba, idcasoprueba, idusuariotester, cantidadhoras, fechaejecucion);
        }
        public static string DeletePrueba(int idProyecto)
        {
            return PruebaDetalleDAL.DeletePrueba(idProyecto);
        }
    }
}