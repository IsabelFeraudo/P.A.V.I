using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD
{
    public class ProductoEntidad
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public bool Borrado { get; set; }

        public ProductoEntidad()
        {
            IdProducto = 0;
            Nombre = "";
            Borrado = false;
        }
    }
}
