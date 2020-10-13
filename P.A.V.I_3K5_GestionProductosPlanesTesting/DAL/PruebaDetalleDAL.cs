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
        public static PruebaDetalle LoadPruebaDetalle(SqlDataReader dr)
        {
            PruebaDetalle prueba = new PruebaDetalle()
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

        public static List<PruebaDetalle> SelectAll()
        {
            List<PruebaDetalle> prueba = new List<PruebaDetalle>();
            try
            {
                using(SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM CiclosPruebaDetalle where borrado = 0", connection);
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

        public string UpdateCicloPruebaDetalle()
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update CiclosPruebaDetalle set ");
            }
            return respuesta;
        }
    }
}
