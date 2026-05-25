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
            CargarCatalogo("TODOS");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCatalogo("TODOS");
        }

        private void CargarCatalogo(string categoria)
        {
            flowLayoutPanelPanelProductos.Controls.Clear();

            Starducks.Controlador.ProductoController controlador = new Starducks.Controlador.ProductoController();
            DataTable dtProductos = controlador.ObtenerProductos(categoria);

            if (dtProductos == null || dtProductos.Rows.Count == 0)
            {
                return;
            }
            foreach (DataRow fila in dtProductos.Rows)
            {
                TarjetaProducto tarjeta = new TarjetaProducto();

                string nombre = fila["nombre"].ToString();
                string desc = fila["descripcion"].ToString();
                double precio = Convert.ToDouble(fila["precio"]);
                byte[] imagenBytes = fila["imagen"] != DBNull.Value ? (byte[])fila["imagen"] : null;

                tarjeta.ConfigurarTarjeta(nombre, desc, precio, imagenBytes);

                tarjeta.Margin = new Padding(12);

                flowLayoutPanelPanelProductos.Controls.Add(tarjeta);
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
            
            flowLayoutPanelPanelProductos.Controls.Clear();

  
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
                double precio = Convert.ToDouble(fila["precio"]);
                byte[] imagenBytes = fila["imagen"] != DBNull.Value ? (byte[])fila["imagen"] : null;

                tarjeta.ConfigurarTarjeta(nombre, desc, precio, imagenBytes);
                tarjeta.Margin = new Padding(12);

                flowLayoutPanelPanelProductos.Controls.Add(tarjeta);
            }
        }
    }
}