using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.DAL
{
    class UsuarioDAL
    {
        public static Usuario LoadUsuario(SqlDataReader dr)
        {
            Usuario usuario = new Usuario()
            {
                IdUsuario = int.Parse(dr["id_usuario"].ToString()),
                IdPerfil = int.Parse(dr["id_perfil"].ToString()),
                Nombre = dr["usuario"].ToString(),
                Password = dr["password"].ToString(),
                Email = dr["email"].ToString(),
                Estado = dr["estado"].ToString(),
                Borrado = bool.Parse(dr["borrado"].ToString())
            };
            return usuario;
        }

        public static Usuario ValidarLogin(string nombreUsuario, string password)
        {
            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PHQ3SE9\SQL_INSTANCIA;Initial Catalog=GestionProductosPlanesTesting;User ID=sa;Password=Holamundo12;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE usuario = @usuario and password = @password", connection);
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuario = LoadUsuario(dr);
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
            return usuario;
        }
    }
}
