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
    public class PlanesDePruebaDAL
    {

        public static PlanesDePrueba LoadPlanesDePrueba(SqlDataReader dr)
        {
            PlanesDePrueba plan = new PlanesDePrueba()
            {
                IdPlanPrueba = int.Parse(dr["id_plan_prueba"].ToString()),
                IdProyecto = int.Parse(dr["id_proyecto"].ToString()),
                Nombre = dr["nombre"].ToString(),
                IdResponsable = int.Parse(dr["id_plan_prueba"].ToString()),
                Descripcion = dr["descripcion"].ToString(),
                Borrado = bool.Parse(dr["borrado"].ToString())
            };
            return plan;
        }

        public static List<PlanesDePrueba> SelectAll()
        {
            List<PlanesDePrueba> plan = new List<PlanesDePrueba>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PlanesDePrueba WHERE borrado = 0", connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            plan.Add(LoadPlanesDePrueba(dr));
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
            return plan;
        }

        public static string UpdatePlan(string nombre, string descripcion)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update PlanesDePrueba set nombre = @nombre WHERE nombre = @nombre AND (borrado = false OR borrado = null)", connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
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

        public static string InsertPlanDePrueba(string nombre,string descripcion)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("insert into PlanesDePrueba (nombre,descripcion,borrado) values(@nombre, @descripcion, @borrado)", connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
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
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update PlanesDePrueba set borrado = 1 WHERE id_producto = " + id, connection);
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


