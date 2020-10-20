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
    public class PruebaDetalleDAL
    {
        public static PruebaDetalleEntidad LoadPruebaDetalle(SqlDataReader dr)
        {
            PruebaDetalleEntidad prueba = new PruebaDetalleEntidad()
            {
                idCicloPruebaDetalle = int.Parse(dr["id_ciclo_prueba_detalle"].ToString()),
                idCicloPrueba = int.Parse(dr["id_ciclo_prueba"].ToString()),
                idCasoPrueba = int.Parse(dr["id_caso_prueba"].ToString()),
                idUsuarioTester = int.Parse(dr["id_caso_prueba"].ToString()),
                cantHoras = int.Parse(dr["cantidad_horas"].ToString()),
                fechaEjecucion = DateTime.Parse(dr["fecha_ejecucion"].ToString()),
                aceptado = bool.Parse(dr["aceptado"].ToString()),
                borrado = bool.Parse(dr["borrado"].ToString())
            };

            return prueba;
        }

        public static List<PruebaDetalleEntidad> SelectAll()
        {
            List<PruebaDetalleEntidad> prueba = new List<PruebaDetalleEntidad>();
            try
            {
                using(SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CiclosPruebaDetalle WHERE borrado = 0", connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            prueba.Add(LoadPruebaDetalle(dr));
                        }
                    }
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return prueba;
        }

        public static string UpdateCicloPruebaDetalle(int idciclopruebadetalle, int idcicloprueba, int idcasoprueba, int idusuariotester, int cantidadhoras, int fechaejecucion)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update CiclosPruebaDetalle set idciclopruebadetalle = @id_ciclo_prueba_detalle WHERE idciclopruebadetalle = @id_ciclo_prueba_detalle AND (borrado = false OR borrado=null)",connection);
                cmd.Parameters.AddWithValue("@id_ciclo_prueba",idcicloprueba);
                cmd.Parameters.AddWithValue("@id_caso_prueba",idcasoprueba);
                cmd.Parameters.AddWithValue("@id_usuario_tester",idusuariotester);
                cmd.Parameters.AddWithValue("@cantidad_horas", cantidadhoras);
                cmd.Parameters.AddWithValue("@fecha_ejecucion", fechaejecucion);
                cmd.Parameters.AddWithValue("@aceptado", true);
                cmd.Parameters.AddWithValue("@borrado", false);

                connection.Open();
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                        respuesta = "Ciclo de prueba actualizado";
                }

                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }
            return respuesta;
        }
        public static string InsertPrueba(int idciclopruebadetalle, int idcicloprueba, int idcasoprueba, int idusuariotester, int cantidadhoras, int fechaejecucion)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("insert into CiclosPruebaDetalle (idciclopruebadetalle,idcicloprueba,idcasoprueba,idusuariotester,cantidadhoras,fechaejecucion,aceptado,borrado) values(@id_ciclo_prueba_detalle,@id_ciclo_prueba, @id_caso_prueba, @id_usuario_tester,@cantidad_horas,@fecha_ejecucion,@aceptado,@borrado)", connection);
                cmd.Parameters.AddWithValue("@id_ciclo_prueba_detalle", idciclopruebadetalle);
                cmd.Parameters.AddWithValue("@id_ciclo_prueba",idcicloprueba);
                cmd.Parameters.AddWithValue("@id_caso_prueba",idcasoprueba);
                cmd.Parameters.AddWithValue("@id_usuario_tester", idcasoprueba);
                cmd.Parameters.AddWithValue("@cantidad_horas", cantidadhoras);
                cmd.Parameters.AddWithValue("@fecha_ejecucion", fechaejecucion);
                cmd.Parameters.AddWithValue("@aceptado", true);
                cmd.Parameters.AddWithValue("@borrado", false);
                connection.Open();
                cmd.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return respuesta;
        }

        public static string DeletePrueba(int id)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update CiclosPruebaDetalle set borrado = 1 WHERE id_ciclo_prueba_detalle = " + id, connection);
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
