using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.DAL
{
    public class ProductoDAL
    {
        protected static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["P.A.V.I_3K5_GestionProductosPlanesTesting.Properties.Settings.GestionProductosPlanesTestingConnectionString"].ConnectionString;
            }
        }

        public static ProductoEntidad LoadProducto(SqlDataReader dr)
        {
            ProductoEntidad producto = new ProductoEntidad()
            {
                IdProducto = int.Parse(dr["id_producto"].ToString()),
                Nombre = dr["nombre"].ToString(),
                Borrado = bool.Parse(dr["borrado"].ToString())
            };
            return producto;
        }

        /// <summary>
        /// valida que el producto se encuentre en base
        /// </summary>
        
        public static List<ProductoEntidad> ValidarProducto(string nombre)
        {
            List<ProductoEntidad> lista = new List<ProductoEntidad>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_BuscarProducto por nombre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(LoadProducto(dr));
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }

            }
            return lista;
        }

        /// <summary>
        ///  busca todos los productos que no esten borrados
        /// </summary>
        

        public static List<ProductoEntidad> SelectAll()
        {
            List<ProductoEntidad> lista = new List<ProductoEntidad>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_SelectALLProducts", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(LoadProducto(dr));
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw (ex);
                }

            }
            return lista;
        }

        /// <summary>
        /// actualiza el nombre del producto 
        /// </summary>

        public static void UpdateProducto(string nombre)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateProducts", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }

        /// <summary>
        ///  inserta un nuevo prducto en base
        /// </summary>


        public static void InsertProducto(string nombre)
        {
            //Directiva de conexion con sql.
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    //Abrimos la conexion.
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_AddStockFood", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@borrado", false);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //capturamos el error.
                    throw (ex);
                }
            }
        }

        /// <summary>
        /// realiza el borrado logico de un producto solo actualizando la columna borrado
        /// </summary>
        

        public static string DeleteProducto(int id)
        {
            string respuesta = "";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteProducts", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdProducto", id);
                    cmd.ExecuteNonQuery();

                    if (cmd.ExecuteNonQuery() > 0)
                        respuesta = "ok";

                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
            return respuesta;
        }
    }
}
