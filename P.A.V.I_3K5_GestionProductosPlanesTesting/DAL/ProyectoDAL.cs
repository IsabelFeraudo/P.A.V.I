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
    public class ProyectoDAL
    {
        public static Proyecto LoadProyecto(SqlDataReader dr)
        {
            Proyecto pro = new Proyecto()
            {
                IdProyecto = int.Parse(dr["id_proyecto"].ToString()),
                IdProducto = int.Parse(dr["id_producto"].ToString()),
                Descripcion = dr["descripcion"].ToString(),
                Version = dr["version"].ToString(),
                Alcance = dr["alcance"].ToString(),
                IdResponsable = int.Parse(dr["id_responsable"].ToString()),
                Borrado = bool.Parse(dr["borrado"].ToString())
            };

            return pro;
        }

        public static List<Proyecto> SelectAll()
        {
            List<Proyecto> proyecto = new List<Proyecto>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Proyectos where borrado = 0", connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            proyecto.Add(LoadProyecto(dr));
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
            return proyecto;
        }

        public static string UpdateProyecto(int idProyecto, int idProducto, string descripcion, string version, string alcance, int idResponsable)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update Productos set idProyecto = @id_proyecto WHERE idProyecto = @idProyecto AND (borrado = false OR borrado = null)", connection);
                cmd.Parameters.AddWithValue("@id_proyecto", idProyecto);
                cmd.Parameters.AddWithValue("@id_producto", idProducto);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@version", version);
                cmd.Parameters.AddWithValue("@alcance", alcance);
                cmd.Parameters.AddWithValue("@id_responsable", idResponsable);
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

        public static string InsertProyecto(int idProyecto, int idProducto, string descripcion, string version,string alcance, int idResponsable)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("insert into Proyectos (idProyecto,idProducto,descripcion,version,alcance,idResponsable,borrado) values(@id_proyecto, @id_producto, @descripcion, @version, @alcance, @id_responsable, @borrado)", connection);
                cmd.Parameters.AddWithValue("@id_proyecto", idProyecto);
                cmd.Parameters.AddWithValue("@id_producto", idProducto);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@version", version);
                cmd.Parameters.AddWithValue("@alcance", alcance);
                cmd.Parameters.AddWithValue("@id_responsable", idResponsable);
                cmd.Parameters.AddWithValue("@borrado", false);
                connection.Open();
                cmd.ExecuteNonQuery();

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
            return respuesta;
        }

        public static string DeleteProyecto(int id)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("update Proyectos set borrado = 1 WHERE id_producto = " + id, connection);
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
