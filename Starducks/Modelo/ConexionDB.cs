using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starducks.Modelo
{
    public class ConexionDB
    {
        private static string cadena = "Server=localhost;Database=starducks;Uid=root;Pwd=014281850026Lv*;";

        public MySqlConnection Conectar()
        {
            MySqlConnection con = new MySqlConnection(cadena);

            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error de conexión: " + e.Message);
            }

            return con;
        }
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadena);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}