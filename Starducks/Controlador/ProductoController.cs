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
                    //System.Windows.Forms.MessageBox.Show("Error al consultar productos: " + ex.Message);
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


                    if (imagenBytes != null)
                        cmd.Parameters.AddWithValue("@foto", imagenBytes);
                    else
                        cmd.Parameters.AddWithValue("@foto", DBNull.Value);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar el producto en la BD: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        //LA BARRA DE BUSQUEDA 
        public DataTable BuscarProductos(string filtro)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
                {
                    string query = "";

                    if (filtro == "TODOS")
                    {
                        query = "SELECT * FROM productos";
                    }
                    else
                    {
                        
                        query = @"SELECT p.* FROM productos p 
                          LEFT JOIN categorias_producto c ON p.id_categoria = c.id_categoria 
                          WHERE c.nombre COLLATE utf8mb4_unicode_ci = @filtro 
                          OR p.nombre LIKE @filtroBusqueda";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        if (filtro != "TODOS")
                        {
                            cmd.Parameters.AddWithValue("@filtro", filtro);
                            cmd.Parameters.AddWithValue("@filtroBusqueda", "%" + filtro + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            return tabla;
        }

        //GUARDAR PEDIDO EN EL CARRITO 
        public bool GuardarPedido(double total, List<Starducks.Vista.CatalogoForms.ItemCarrito> carrito)
        {
            using (MySqlConnection conexion = ConexionDB.ObtenerConexion())
            {
                
                using (MySqlTransaction transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        // 1. Guardar Pedido
                        string queryPedido = "INSERT INTO pedidos (total, fecha) VALUES (@total, NOW());";
                        MySqlCommand cmdPedido = new MySqlCommand(queryPedido, conexion, transaccion);
                        cmdPedido.Parameters.AddWithValue("@total", total);
                        cmdPedido.ExecuteNonQuery();

                        long idPedido = cmdPedido.LastInsertedId; 

                        // 2. Guardar Detalles
                        foreach (var item in carrito)
                        {
                            string queryDetalle = "INSERT INTO detalle_pedido (id_pedido, nombre_producto, tamano, precio) VALUES (@id, @nom, @tam, @pre);";
                            MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, conexion, transaccion);
                            cmdDetalle.Parameters.AddWithValue("@id", idPedido);
                            cmdDetalle.Parameters.AddWithValue("@nom", item.Nombre);
                            cmdDetalle.Parameters.AddWithValue("@tam", item.Tamano);
                            cmdDetalle.Parameters.AddWithValue("@pre", item.Precio);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        transaccion.Commit(); 
                        return true;
                    }
                    catch
                    {
                        transaccion.Rollback();
                        return false;
                    }
                }
            }
        }
    }
}


