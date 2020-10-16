using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD
{
    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Version { get; set; }
        public string Alcance { get; set; }
        public int IdResponsable { get; set; }
        public bool Borrado { get; set; }

        public Proyecto()
        {
            IdProyecto = 0;
            IdProducto = 0;
            Descripcion = "";
            Version = "";
            Alcance = "";
            IdResponsable = 0;
            Borrado = false;
        }
    }
}
