using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Starducks.Modelo
{
    internal class AuditoriaHelper
    {   
        // Método para registrar auditoria
        public void RegistrarAuditoria(int idAdmin, int idUsuarioAfectado, string tabla, string accion, string descripcion)
        {
            using (MySqlConnection con = new MySqlConnection())
            {
                MySqlCommand cmd = new MySqlCommand("sp_registrar_auditoria", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_admin", idAdmin);

                cmd.Parameters.AddWithValue("@p_id_afectado", idUsuarioAfectado);

                cmd.Parameters.AddWithValue("@p_tabla", tabla);

                cmd.Parameters.AddWithValue("@p_accion", accion);

                cmd.Parameters.AddWithValue("@p_descripcion", descripcion);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
