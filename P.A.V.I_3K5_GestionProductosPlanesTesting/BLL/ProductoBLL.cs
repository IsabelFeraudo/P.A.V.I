using P.A.V.I_3K5_GestionProductosPlanesTesting.DAL;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.BLL
{
    public class ProductoBLL
    {
        public static List<ProductoEntidad> ValidarProducto(string nombre)
        {
            return ProductoDAL.ValidarProducto(nombre);
        }

        public static string UpdateProducto(string nombre)
        {
            return ProductoDAL.UpdateProducto(nombre);
        }
        public static string InsertProducto(string nombre)
        {
            return ProductoDAL.InsertProducto(nombre);
        }
        public static string DeleteProducto(int id)
        {
            return ProductoDAL.DeleteProducto(id);
        }

        public static List<ENTIDAD.ProductoEntidad> SelectAll()
        {
            return ProductoDAL.SelectAll();
        }
    }
}
