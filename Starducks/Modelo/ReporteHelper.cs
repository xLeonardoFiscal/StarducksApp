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
        
    }
}
