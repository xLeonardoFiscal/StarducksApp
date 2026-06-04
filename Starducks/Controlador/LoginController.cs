using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Starducks.Modelo;

namespace Starducks.Controlador
{
    internal class LoginController
    {
        ConexionDB conexion = new ConexionDB();

        public Usuario IniciarSesion(
            string usuario,
            string password)
        {
            MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=starducks;Uid=root;Pwd=Lizbethhdz17;");

            try
            {
                conexion.Open();

                Usuario user = null;

                string query =
                    @"SELECT * 
                    FROM usuarios
                    WHERE usuario=@usuario
                    AND password=@password";

                MySqlConnection con = ConexionDB.ObtenerConexion();

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@usuario", usuario);

                cmd.Parameters.AddWithValue(
                    "@password", password);

                MySqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    user = new Usuario();

                    user.IdUsuario =
                        lector.GetInt32(
                           "id_usuario");

                    user.Nombre = lector["nombre"].ToString();

                    user.User = lector["usuario"].ToString();

                    user.Rol = lector["rol"].ToString();

                }

                con.Close();

                return user;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return null;
            }
            
        }
        
    }
}
