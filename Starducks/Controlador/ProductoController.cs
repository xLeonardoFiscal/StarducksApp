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
                    query = "SELECT nombre, descripcion, precio_tall, foto FROM productos";
                }
                else
                {

                    query = "SELECT nombre, descripcion, precio_tall, foto FROM productos WHERE categoria = @categoria";
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


            string query = "INSERT INTO productos (nombre, descripcion, precio_tall, categoria, foto) VALUES (@nombre, @descripcion, @precio, @categoria, @imagen)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio_tall", precio);
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    // Si el usuario no seleccionó imagen, guardamos un valor nulo en la BD
                    if (imagenBytes != null)
                        cmd.Parameters.AddWithValue("@foto", imagenBytes);
                    else
                        cmd.Parameters.AddWithValue("@foto", DBNull.Value);

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
        public DataTable BuscarProductos(string categoria)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                string query = "";

                if (categoria == "TODOS")
                {
                    query = "SELECT * FROM productos";
                }
                else
                {
                    // Usamos un JOIN para conectar la tabla productos con categorias_producto
                    // Filtramos por el nombre de la categoría, no por una columna inexistente
                    query = @"SELECT p.* FROM productos p 
                      INNER JOIN categorias_producto c ON p.id_categoria = c.id_categoria 
                      WHERE c.nombre = @cat";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    if (categoria != "TODOS")
                        cmd.Parameters.AddWithValue("@cat", categoria);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
            }
            return tabla;
        }
    }  
    
}

