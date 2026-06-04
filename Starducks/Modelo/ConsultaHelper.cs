using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Starducks.Modelo
{
    internal class ConsultaHelper
    {   
        // PROCEDIMIENTO DE USUARIOS CON VISTA
        public DataTable ConsultarUsuarios(string nombre, string rol)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_consulta_usuarios", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_nombre", string.IsNullOrWhiteSpace(nombre) ? DBNull.Value : (object)nombre);

                cmd.Parameters.AddWithValue("@p_rol", string.IsNullOrWhiteSpace(rol) ? DBNull.Value : (object)rol); 
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }


        // PROCEDIMIENTO DE PRODUCTOS CON VISTA
        public DataTable ConsultarProductos(string nombre, string categoria)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_consulta_productos", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_nombre",string.IsNullOrWhiteSpace(nombre)? DBNull.Value: (object)nombre);

                cmd.Parameters.AddWithValue("@p_categoria", string.IsNullOrWhiteSpace(categoria) ? DBNull.Value : (object)categoria);

                MySqlDataAdapter da =new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }


        // PROCEDIMIENTO DE PEDIDOS CON VISTA
        public DataTable ConsultarPedidos(DateTime? fechaInicio, DateTime? fechaFin, string estatus)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_consulta_pedidos", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_fecha_inicio", fechaInicio.HasValue ? (object)fechaInicio.Value.Date : DBNull.Value);

                cmd.Parameters.AddWithValue("@p_fecha_fin", fechaFin.HasValue ? (object)fechaFin.Value.Date : DBNull.Value);

                cmd.Parameters.AddWithValue("@p_estatus", string.IsNullOrWhiteSpace(estatus) ? DBNull.Value : (object)estatus);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // PROCEDIMIENTO DE CATEGORIAS CON VISTA
        public DataTable ConsultarCategorias(string nombre)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_consulta_categorias", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_nombre", string.IsNullOrWhiteSpace(nombre) ? DBNull.Value : (object)nombre);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }


        // PROCEDIMIENTO DE REPARTIDORES CON VISTA
        public DataTable ConsultarRepartidores(string nombre, string disponible)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_consulta_repartidores", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_nombre", string.IsNullOrWhiteSpace(nombre) ? DBNull.Value : (object)nombre);

                cmd.Parameters.AddWithValue("@p_disponible", string.IsNullOrWhiteSpace(disponible) ? DBNull.Value : (object)disponible);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }

        // PROCEDIMIENTO DE REPARTIDORES CON VISTA
        public DataTable ConsultarDetalles(string producto, string tamano)
        {
            DataTable tabla = new DataTable();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_consulta_detalle_pedido", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_producto", string.IsNullOrWhiteSpace(producto) ? DBNull.Value : (object)producto);

                cmd.Parameters.AddWithValue("@p_tamano", string.IsNullOrWhiteSpace(tamano) ? DBNull.Value : (object)tamano);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
