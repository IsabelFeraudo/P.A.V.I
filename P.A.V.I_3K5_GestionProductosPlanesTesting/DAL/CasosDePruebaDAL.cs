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

    public class CasosDePruebaDAL

    {

        public static CasosDePruebaEntidad LoadCasosDePrueba(SqlDataReader dr)

        {

            CasosDePruebaEntidad caso = new CasosDePruebaEntidad()

            {

                idCasoPrueba = int.Parse(dr["id_caso_prueba"].ToString()),

                idPlanPrueba = int.Parse(dr["id_plan_prueba"].ToString()),

                titulo = dr["titulo"].ToString(),

                descripcion = dr["descripcion"].ToString(),

                idResponsable = int.Parse(dr["id_responsable"].ToString()),

                borrado = bool.Parse(dr["borrado"].ToString())

            };

            return caso;

        }



        public static List<CasosDePruebaEntidad> SelectAll()

        {

            List<CasosDePruebaEntidad> caso = new List<CasosDePruebaEntidad>();

            try

            {

                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))

                {

                    SqlCommand cmd = new SqlCommand("SELECT * FROM CasosDePrueba WHERE borrado = 0", connection);

                    cmd.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())

                    {

                        while (dr.Read())

                        {

                            caso.Add(LoadCasosDePrueba(dr));

                        }

                    }

                    if (connection.State == ConnectionState.Open)

                        connection.Close();

                };

            }

            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);

            }



            return caso;

        }



        public static string UpdateCasoPrueba(int idCasoPrueba, int idPlanPrueba, string titulo, string descripcion, int idResponsable)

        {

            string respuesta = "";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))

            {

                SqlCommand cmd = new SqlCommand("update CasosDePrueba set idCasoPrueba = @id_caso_prueba WHERE idCasoPrueba = @id_caso_prueba AND (borrado = false OR borrado = null)", connection);

                cmd.Parameters.AddWithValue("@id_caso_prueba", idCasoPrueba);

                cmd.Parameters.AddWithValue("@id_plan_prueba", idPlanPrueba);

                cmd.Parameters.AddWithValue("@titulo", titulo);

                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.Parameters.AddWithValue("@id_responsable", idResponsable);

                cmd.Parameters.AddWithValue("@borrado", false);



                connection.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())

                {

                    if (dr.Read())

                        respuesta = "Caso de prueba actualizado";

                }



                if (connection.State == ConnectionState.Open)

                    connection.Close();

            }

            return respuesta;

        }



        public static string InsertCasoPrueba(int idCasoPrueba, int idPlanPrueba, string titulo, string descripcion, int idResponsable)

        {

            string respuesta = "";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))

            {

                SqlCommand cmd = new SqlCommand("insert into CasosDePrueba (idCasoPrueba,idPlanPrueba,titulo,descripcion,idResponsable,borrado) values(@id_caso_prueba,@id_plan_prueba,@titulo,@descripcion,@id_responsable,@borrado)", connection);

                cmd.Parameters.AddWithValue("@id_caso_prueba", idCasoPrueba);

                cmd.Parameters.AddWithValue("@id_plan_prueba", idPlanPrueba);

                cmd.Parameters.AddWithValue("@titulo", titulo);

                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                cmd.Parameters.AddWithValue("@id_responsable", idResponsable);

                cmd.Parameters.AddWithValue("@borrado", false);

                connection.Open();

                cmd.ExecuteNonQuery();



                if (connection.State == ConnectionState.Open)

                    connection.Close();

            }

            return respuesta;

        }



        public static string DeleteCasoPrueba(int id)

        {

            string respuesta = "";

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))

            {

                {

                    SqlCommand cmd = new SqlCommand("update CasosDePrueba set borrado = 1 WHERE id_caso_prueba = " + id, connection);

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

}