using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.DAL
{
    public class ProductoDAL
    {

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

        public static ProductoEntidad ValidarProducto(string nombre)
        {
            ProductoEntidad producto = new ProductoEntidad();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-H6PMK8M\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE nombre = @nombre AND (borrado = false OR borrado = null)", connection);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            producto = LoadProducto(dr);
                        }
                    }
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return producto;
        }

        public static List<ProductoEntidad> SelectAll()
        {
            List<ProductoEntidad> producto = new List<ProductoEntidad>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-H6PMK8M\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos ", connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            producto.Add(LoadProducto(dr));
                        }
                    }
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return producto;
        }

        public static string UpdateProducto(string nombre)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-H6PMK8M\sql_instancia;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
            {
                SqlCommand cmd = new SqlCommand("update Productos set nombre = @nombre WHERE nombre = @nombre AND (borrado = false OR borrado = null)", connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@borrado", false);
                connection.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        respuesta = "ok";
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return respuesta;
        }

        public static string InsertProducto(string nombre)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-H6PMK8M\sql_instancia;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
            {
                SqlCommand cmd = new SqlCommand("insert into Productos (nombre,borrado) values(@nombre, @borrado)", connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@borrado", false);
                connection.Open();
                cmd.ExecuteNonQuery();

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return respuesta;
        }

        public static string DeleteProducto(string nombre)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-H6PMK8M\sql_instancia;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
            {
                SqlCommand cmd = new SqlCommand("update Productos set borrado = true WHERE nombre = @nombre ", connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                connection.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        respuesta = "ok";
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return respuesta;
        }
    }
}
