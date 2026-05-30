using MySql.Data.MySqlClient;
using Starducks.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Starducks.Vista.CatalogoForms
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            BuscarCatalogo("TODOS");
        }

        private void CargarCatalogo(string categoria)
        {
            // 1. LIMPIEZA: Borra lo anterior para que no se encimen los productos
            flowLayoutPanelPanelProductos.Controls.Clear();

            // 2. OBTENCIÓN: Trae los datos de la base de datos
            ProductoController controlador = new ProductoController();
            DataTable dtProductos = controlador.BuscarProductos(categoria);

            // 3. DIBUJADO: Crea cada tarjeta y agrégala al panel
            if (dtProductos.Rows.Count > 0)
            {
                foreach (DataRow fila in dtProductos.Rows)
                {
                    TarjetaProducto tarjeta = new TarjetaProducto();

                    // Asigna los valores (asegúrate de que los nombres de columnas coincidan con tu BD)
                    tarjeta.NombreProducto = fila["nombre"].ToString();
                    tarjeta.Precio = fila["precio"].ToString();

                    // ¡ESTO ES LO QUE HACE QUE SE VEAN!
                    flowLayoutPanelPanelProductos.Controls.Add(tarjeta);
                }
            }
            else
            {
                MessageBox.Show("No hay productos en esta categoría.");
            }
        }


        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarCatalogo("TODOS");
        }

        private void btnCafesFrios_Click(object sender, EventArgs e)
        {
            CargarCatalogo("CAFES FRIOS");
        }

        private void btnCafesCalientes_Click(object sender, EventArgs e)
        {
            CargarCatalogo("CAFES CALIENTES");
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            CargarCatalogo("POSTRES");
        }
        private void BuscarCatalogo(string textoBusqueda)
        {

            panelMenu.Controls.Clear();

            Starducks.Controlador.ProductoController controlador = new Starducks.Controlador.ProductoController();
            DataTable dtProductos = controlador.BuscarProductos(textoBusqueda);

            if (dtProductos == null || dtProductos.Rows.Count == 0)
            {
                return;
            }


            foreach (DataRow fila in dtProductos.Rows)
            {
                TarjetaProducto tarjeta = new TarjetaProducto();

                string nombre = fila["nombre"].ToString();
                string desc = fila["descripcion"].ToString();
                double precio = Convert.ToDouble(fila["precio_tall"]);
                byte[] imagenBytes = fila["foto"] != DBNull.Value ? (byte[])fila["foto"] : null;

                tarjeta.AsignarDatos(nombre, desc, precio, imagenBytes);
                tarjeta.Margin = new Padding(12);

                panelMenu.Controls.Add(tarjeta);
            }
        }


        private void flowLayoutPanelProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            panelMenu.Controls.Clear();

            // Llamamos a tu catálogo pasándole "TODOS"
            CargarCatalogo("TODOS");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}