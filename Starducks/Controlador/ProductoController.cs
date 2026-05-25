using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using Starducks.Modelo;

namespace Starducks.Controlador
{
    public class ProductoController
    {
       
        public DataTable ObtenerProductos(string categoria)
        {
            DataTable tabla = new DataTable();
            MySqlConnection con = ConexionDB.ObtenerConexion();

            if (con != null)
            {
                string query;

                if (categoria.ToUpper() == "TODOS")
                {
                    query = "SELECT nombre, descripcion, precio, imagen FROM productos";
                }
                else
                {
                    
                    query = "SELECT nombre, descripcion, precio, imagen FROM productos WHERE categoria = @categoria";
                }

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (categoria.ToUpper() != "TODOS")
                        {
                            cmd.Parameters.AddWithValue("@categoria", categoria);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al consultar productos: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return tabla;
        }
        public bool InsertarProducto(string nombre, string descripcion, double precio, string categoria, byte[] imagenBytes)
        {
            MySqlConnection con = ConexionDB.ObtenerConexion();
            if (con == null) return false;

           
            string query = "INSERT INTO productos (nombre, descripcion, precio, categoria, imagen) VALUES (@nombre, @descripcion, @precio, @categoria, @imagen)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    // Si el usuario no seleccionó imagen, guardamos un valor nulo en la BD
                    if (imagenBytes != null)
                        cmd.Parameters.AddWithValue("@imagen", imagenBytes);
                    else
                        cmd.Parameters.AddWithValue("@imagen", DBNull.Value);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0; // Retorna true si se guardó con éxito
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar el producto en la BD: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close(); // Cerramos la conexión siempre
            }
        }
        public DataTable BuscarProductos(string texto)
        {
            DataTable tabla = new DataTable();
            MySqlConnection con = ConexionDB.ObtenerConexion();

            if (con != null)
            {
             
                string query = "SELECT nombre, descripcion, precio, imagen FROM productos WHERE nombre LIKE @texto";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // El '%' sirve para que busque la palabra en cualquier parte del nombre
                        cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error al buscar: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return tabla;
        }
    }
}