using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD
{
    public class PlanesDePrueba
    {
        public int IdPlanPrueba { get; set; }
        public int IdProyecto { get; set; }
        public string Nombre { get; set; }
        public int IdResponsable { get; set; }
        public string Descripcion { get; set; }
        public bool Borrado { get; set; }

        public PlanesDePrueba() 
        {
            IdPlanPrueba = 0;
            IdProyecto = 0;
            Nombre = "";
            IdResponsable = 0;
            Descripcion = "";
            Borrado = false;
        }
    }
}
