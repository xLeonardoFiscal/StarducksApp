using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Starducks.Vista.CatalogoForms;

namespace Starducks.Vista.CatalogoForms
{
    public class ItemCarrito
    {
        public string Nombre { get; set; }
        public string Tamano { get; set; }
        public double Precio { get; set; }

        public ItemCarrito()
        {
        }

        // Constructor sencillo
        public ItemCarrito(string nombre, string tamano, double precio)
        {
            Nombre = nombre;
            Tamano = tamano;
            Precio = precio;
        }


        private void GuardarVentaEnBD()
        {
            // 1. Definimos la conexión
            string cadenaConexion = "Server=localhost;Database=nombre_tu_bd;Uid=root;Pwd=Lizbethhdz17;";

            // 2. Creamos el objeto de conexión (usando 'using' para que se cierre sola)
            using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conn.Open(); // Ahora sí existe 'conn'
                    MySqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        // ... (aquí va el resto de tu código de inserción) ...

                        trans.Commit();
                        MessageBox.Show("¡Venta registrada con éxito!");
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex; // Lanzamos el error para que el catch de abajo lo capture
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }
    }
}
