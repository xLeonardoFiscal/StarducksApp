using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Starducks.Modelo
{
    internal class UsuarioDAO
    {
        public bool Insertar(Usuario usuario)
        {
            try
            {
                MySqlConnection con = ConexionDB.ObtenerConexion();

                string sql = @"INSERT INTO usuarios
                               (Nombre, Usuario, Password, Telefono, Direccion, Foto)
                               VALUES
                               (@Nombre,@User,@Password,@Telefono,@Direccion,@Foto)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Usuario", usuario.User);
                cmd.Parameters.AddWithValue("@Password", usuario.Password);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                cmd.Parameters.AddWithValue("@Foto", usuario.Foto);

                //Guardar la ruta de la imagen temporalmente
                cmd.Parameters.AddWithValue("@foto", DBNull.Value);

                int filas = cmd.ExecuteNonQuery();

                con.Close();

                return filas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario: " + ex.Message);
                return false;
            }
        }
    }
}