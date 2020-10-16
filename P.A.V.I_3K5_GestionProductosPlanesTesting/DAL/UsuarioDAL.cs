﻿using P.A.V.I_3K5_GestionProductosPlanesTesting.ENTIDAD;
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
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True;"))
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

        public static Usuario SelectModificarUsuario(int id)
        {
            Usuario usuario = new Usuario();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True;"))
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
        public static void UpdateUsuario(int id, string nombre, string perfil, string password, string email)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True;"))
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
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BER74LN\SQLEXPRESS;Initial Catalog=GestionProductosPlanesTesting;Integrated Security=True;"))
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
