using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD
{
    public class CasosDePrueba
    {
        public int idCasoPrueba { get; set; }
        public int idPlanPrueba { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public int idResponsable { get; set; }
        public bool borrado { get; set; }

        public CasosDePrueba()
        {
            idCasoPrueba = 0;
            idPlanPrueba = 0;
            titulo = "";
            descripcion = "";
            idResponsable = 0;
            borrado = false;
        }
    }
}
