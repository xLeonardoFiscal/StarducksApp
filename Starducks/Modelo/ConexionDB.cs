using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starducks.Modelo
{
    public class ConexionDB
    {
        private string cadena = "server=localhost;database=starducks;user=root;password=;";

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
    }
}