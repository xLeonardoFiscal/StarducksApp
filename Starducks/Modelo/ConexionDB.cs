using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System;

public class Conexion
{
    private string cadena = "server=localhost;database=starducks;user=root;password=;";

    public MySqlConnection conectar()
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