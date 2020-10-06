using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD
{
    public class CicloPrueba
    {
        public int IdCicloPrueba { get; set; }
        public DateTime? FechaInicioEjecucion { get; set; }
        public DateTime? FechaFinEjecucion { get; set; }
        public int IdResponsable { get; set; }
        public int IdPlanPrueba { get; set; }
        public bool Aceptado { get; set; }
        public bool Borrado { get; set; }

        public CicloPrueba()
        {
            IdCicloPrueba = 0;
            FechaInicioEjecucion = null;
            FechaFinEjecucion = null;
            IdResponsable = 0;
            IdPlanPrueba = 0;
            Aceptado = false;
            Borrado = false;
        }
    }
}
