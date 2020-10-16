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
    public class CicloPruebaDAL
    {

        public static CicloPrueba LoadCicloPrueba(SqlDataReader dr)
        {
            CicloPrueba ciclo = new CicloPrueba()
            {
                IdCicloPrueba = int.Parse(dr["id_ciclo_prueba"].ToString()),
                FechaInicioEjecucion = DateTime.Parse(dr["fecha_inicio_ejecucion"].ToString()),
                FechaFinEjecucion = DateTime.Parse(dr["fecha_fin_ejecucuion"].ToString()),
                IdResponsable = int.Parse(dr["id_responsable"].ToString()),
                IdPlanPrueba = int.Parse(dr["id_plan_prueba"].ToString()),
                Aceptado = bool.Parse(dr["aceptado"].ToString()),
                Borrado = bool.Parse(dr["borrado"].ToString())
            };
            return ciclo;
        }

        
        public static List<CicloPrueba> SelectAll()
        {
            List<CicloPrueba> ciclo = new List<CicloPrueba>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CiclosPrueba WHERE borrado = 0", connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            ciclo.Add(LoadCicloPrueba(dr));
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
            return ciclo;
        }

        public static string UpdateCicloPrueba(DateTime fechaInicio, DateTime FechaFin, int idResponsable, int idPlanPrueba)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update CiclosPrueba set idCicloPrueba = @id_ciclo_prueba WHERE idCicloPrueba = @id_ciclo_prueba AND (borrado = false OR borrado = null)", connection);
                cmd.Parameters.AddWithValue("@fecha_inicio_ejecucion", fechaInicio);
                cmd.Parameters.AddWithValue("@fecha_fin_ejecucion", FechaFin);
                cmd.Parameters.AddWithValue("@id_responsable", idResponsable);
                cmd.Parameters.AddWithValue("@id_plan_prueba", idPlanPrueba);
                cmd.Parameters.AddWithValue("@aceptado", true);
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

        public static string InsertCicloPrueba(DateTime fechaInicio, DateTime fechaFin, int idResponsable, int idPlanPrueba)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("insert into CiclosPrueba (fechaInicio,fechaFin, idResponsable, idPlanPrueba) values(@fecha_inicio_ejecucion,@fecha_fin_ejecucion, @id_responsable, @id_plan_prueba, @borrado)", connection);
                cmd.Parameters.AddWithValue("@fecha_inicio_ejecucion", fechaInicio);
                cmd.Parameters.AddWithValue("@fecha_fin_ejecucion", fechaFin);
                cmd.Parameters.AddWithValue("@id_responsable", idResponsable);
                cmd.Parameters.AddWithValue("@id_plan_prueba", idPlanPrueba);
                cmd.Parameters.AddWithValue("@borrado", false);
                connection.Open();
                cmd.ExecuteNonQuery();

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return respuesta;
        }

        public static string DeleteCicloPrueba(int id)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update CiclosPrueba set borrado = 1 WHERE id_producto = " + id, connection);
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
