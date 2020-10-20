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
        public static ProyectoEntidad LoadProyecto(SqlDataReader dr)
        {
            ProyectoEntidad pro = new ProyectoEntidad()
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

        public static List<ProyectoEntidad> SelectAll()
        {
            List<ProyectoEntidad> proyecto = new List<ProyectoEntidad>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Proyectos WHERE borrado = 0", connection);
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

        public static ProyectoEntidad UpdateProyecto(string descripcion, string version, string alcance, int idResponsable)
        {
            ProyectoEntidad proyecto = new ProyectoEntidad();
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Productos set idProyecto = @id_proyecto WHERE idProyecto = @idProyecto AND (borrado = false OR borrado = null)", connection);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@version", version);
                cmd.Parameters.AddWithValue("@alcance", alcance);
                cmd.Parameters.AddWithValue("@id_responsable", idResponsable);
                cmd.Parameters.AddWithValue("@borrado", false);
                connection.Open();
                cmd.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return proyecto;
        }

        public static ProyectoEntidad InsertProyecto(int id_proyecto, int id_producto, string descripcion, string version,string alcance, int id_responsable, bool borrado)
        {
            ProyectoEntidad proyecto = new ProyectoEntidad(); 
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Proyectos (id_proyecto,id_producto,descripcion,version,alcance,id_responsable,borrado) values(@id_proyecto, @id_producto, @descripcion, @version, @alcance, @id_responsable, @borrado)", connection);
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);
                cmd.Parameters.AddWithValue("@id_producto", id_producto);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@version", version);
                cmd.Parameters.AddWithValue("@alcance", alcance);
                cmd.Parameters.AddWithValue("@id_responsable", id_responsable);
                cmd.Parameters.AddWithValue("@borrado", false);
                connection.Open();
                cmd.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            return proyecto;
        }

        public static string DeleteProyecto(int id)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Proyectos set borrado = 1 WHERE id_producto = " + id, connection);
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

        private void CargarIdResponsable()
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Proyectos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                connection.Open();
                cmd.Connection = connection;

                DataTable data = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                connection.Close();
            }
        }

        public static List<ProyectoEntidad> SelectDoc()
        {
            List<ProyectoEntidad> listItem = new List<ProyectoEntidad>();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Proyectos", connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            listItem.Add(LoadProyecto(dr));
                        }
                    }
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return listItem;
        }

        public static ProyectoEntidad SelectProyecto(int id)
        {
            ProyectoEntidad proyecto = new ProyectoEntidad();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Proyectos WHERE idProyecto = @id_proyecto AND (borrado = false OR borrado = null)", connection);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        LoadProyecto(dr);
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

    }
}
