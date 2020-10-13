using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace P.A.V.I_3K5_GestionProductosPlanesTesting.DAL
{
    public class UsuarioDAL
    {
        protected static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["P.A.V.I_3K5_GestionProductosPlanesTesting.Properties.Settings.GestionProductosPlanesTestingConnectionString"].ConnectionString;
            }
        }
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

        public static Usuario LoadUsuarioModificar(SqlDataReader dr)
        {
            Usuario usuario = new Usuario()
            {
                IdUsuario = int.Parse(dr["id_usuario"].ToString()),
                Perfil = dr["perfil"].ToString(),
                Nombre = dr["usuario"].ToString(),
                Password = dr["password"].ToString(),
                Email = dr["email"].ToString(),
                
            };
            return usuario;
        }

        public static Usuario ValidarLogin(string nombreUsuario, string password)
        {
            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_SelectUsuarioByUsuarioPassWord", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@password", password);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuario = LoadUsuario(dr);
                        }
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return usuario;
        }

        /// <summary>
        /// devuelve el usuario para poder modificar
        /// </summary>
        
        public static Usuario SelectModificarUsuario(int id)
        {
            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_SelectUsuarioByIdModificar", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdUsuario", id);
                    
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuario = LoadUsuarioModificar(dr);
                        }
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return usuario;
        }

        public static void UpdateUsuario(int id,string nombre,string perfil, string password, string email)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_UpdateUsuarioInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@perfil", perfil);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }

        public static Usuario ValidarLogeado()
        {
            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_SelectUsuariByLogeado", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            usuario = LoadUsuario(dr);
                        }
                    }
                    if (con.State == ConnectionState.Open)
                        con.Close();
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
