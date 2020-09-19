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

        public static List<ProductoEntidad> ValidarProducto(string nombre)
        {
            List<ProductoEntidad> producto = new List<ProductoEntidad>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PHQ3SE9\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE nombre like '%" + nombre + "%' AND (borrado = 0 OR borrado = null)", connection);
                    //cmd.Parameters.AddWithValue("@nombre", nombre);
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

        public static List<ProductoEntidad> SelectAll()
        {
            List<ProductoEntidad> producto = new List<ProductoEntidad>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PHQ3SE9\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Productos where borrado = 0", connection);
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
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PHQ3SE9\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
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
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PHQ3SE9\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
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

        public static string DeleteProducto(int id)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PHQ3SE9\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
            {
                SqlCommand cmd = new SqlCommand("update Productos set borrado = 1 WHERE id_producto = " + id , connection);
                cmd.CommandType = CommandType.Text;
                connection.Open();
                
                cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() > 0)
                    respuesta = "ok";

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return respuesta;
        }
    }
}
