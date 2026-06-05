using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Starducks.Modelo;
using System.Collections.Generic;

namespace Starducks.Controlador
{
    internal class UsuarioController
    {
        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                string sql = @"SELECT id_usuario, nombre, usuario, rol, activo FROM usuarios";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Usuario
                    {
                        IdUsuario = Convert.ToInt32(dr["id_usuario"]),
                        Nombre = dr["nombre"].ToString(),
                        User = dr["usuario"].ToString(),
                        Rol = dr["rol"].ToString(),
                        Activo = Convert.ToInt32(dr["activo"])
                    });
                }
            }

            return lista;
        }



        public bool ActualizarRol(int idUsuario, string nuevoRol)
        {
            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                string sql = @"UPDATE usuarios SET rol = @rol WHERE id_usuario = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@rol", nuevoRol);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public bool DesactivarUsuario(int idUsuario)
        {
            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                string sql =
                @"UPDATE usuarios SET activo = 0 WHERE id_usuario = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id", idUsuario);

                return cmd.ExecuteNonQuery() > 0;
            }
        }


        public bool ReactivarUsuario(int idUsuario)
        {
            using (MySqlConnection con = ConexionDB.ObtenerConexion())
            {
                string sql =
                @"UPDATE usuarios SET activo = 1 WHERE id_usuario = @id";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id", idUsuario);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
