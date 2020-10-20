using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD
{
    public class PruebaDetalleEntidad
    {
        public int idCicloPruebaDetalle { get; set; }
        public int idCicloPrueba { get; set; }
        public int idCasoPrueba { get; set; }
        public int idUsuarioTester { get; set; }
        public int cantHoras { get; set; }
        public DateTime? fechaEjecucion { get; set; }
        public bool aceptado { get; set; }
        public bool borrado { get; set; }

        public PruebaDetalleEntidad()
        {
            idCicloPruebaDetalle = 0;
            idCicloPrueba = 0;
            idCasoPrueba = 0;
            idUsuarioTester = 0;
            cantHoras = 0;
            fechaEjecucion = null;
            aceptado = false;
            borrado = false;
        }
    }

}
