using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Starducks.Modelo
{
    internal class ReporteHelper
    {
        // USUARIOS GENERAL
        public DataTable UsariosGeneral()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_usuarios_general", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }


        // USUARIOS POR ROL
        public DataTable UsuariosRol(string rol)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_usuarios_por_rol", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_rol", rol);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // BUSQUEDA DE USUARIOS
        public DataTable UsuariosBusqueda(string busqueda)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_buscar_usuario", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_busqueda", busqueda);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // CANTIDAD DE USUARIOS POR ROL
        public DataTable UsuariosCantidadRol()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_estadistica_usuarios", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // DETALLE DE USUARIOS
        public DataTable UsuariosDetalle(string id)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalle_usuario", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_usuario", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }





        // PRODUCTOS general
        public DataTable ProductosGeneral()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_productos_general", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Productos por categoria 
        public DataTable ProductosCategoria(string categoria)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_productos_categoria", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_categoria", categoria);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Busqueda de producto
        public DataTable ProductoBusqueda (string busqueda)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_buscar_producto", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_busqueda", busqueda);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        //Cantidad de productos por categoria 
        public DataTable ProductoCategoriaCantidad()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_estadistica_productos", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Detalle producto
        public DataTable ProductoDetalle(string id)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalle_producto", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_producto", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }




        // PEDIDOS general
        public DataTable PedidosGeneral()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_pedidos_general", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Pedidos de Hoy 
        public DataTable PedidosDeHoy()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_pedidos_hoy", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Busqueda de pedidos por estatus
        public DataTable PedidosEstatus(string estatus)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_pedidos_estatus", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_estatus", estatus);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Total de pedidos por estatus
        public DataTable PedidosTotalEstatus()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_estadistica_pedidos", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Detalle Pedidos
        public DataTable PedidosDetalle(string id)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalle_pedido", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_pedido", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }





        // REPARTIDORES general
        public DataTable RepartidoresGeneral()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_repartidores_general", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Repartidores disponibles / no disponibles 
        public DataTable RepartidoresDisponibilidad(string disponibilidad)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_repartidores_disponibilidad", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_disponible", disponibilidad);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Busqueda por Nombre
        public DataTable RepartidoresBusqueda(string nombre)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_buscar_repartidor", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_nombre", nombre);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Cantidad de pedidos asignados por repartidor
        public DataTable RepartidoresPedidos()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_estadistica_repartidores", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Detalle Repartidor
        public DataTable RepartidoresDetalle(string id)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalle_repartidor", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_repartidor", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }






        // CATEGORIAS general
        public DataTable CategoriasGeneral()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_categorias_general", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Busqueda de categorias por nombre 
        public DataTable CategoriasBusqueda(string nombre)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_buscar_categoria", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_nombre", nombre);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Cantidad de Productos por categoria
        public DataTable CategoriasCantidadProductos()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_estadistica_categorias", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Detalle de Categoria
        public DataTable CategoriasDetalle(string id)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalle_categoria", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_categoria", id);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Categorias con Productos Disponibles
        public DataTable CategoriasDisponibles()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_categorias_disponibles", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }





        // DETALLES PRODUCTOS general
        public DataTable DetallesGeneral()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalles_general", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Filtrar por Tamaño 
        public DataTable DetallesTamano(string tamano)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalles_tamano", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_tamano", tamano);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Busqueda por producto
        public DataTable DetallesBusqueda(string producto)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_buscar_detalle_producto", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_producto", producto);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Cantidad Vendida por Tamaño
        public DataTable DetallesCantidad()
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_estadistica_tamanos", con);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // Detalles de Registro
        public DataTable DetallesRegistro(string id)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_detalle_registro", con);

                cmd.Parameters.AddWithValue("@p_id_detalle", id);

                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

    }

}
