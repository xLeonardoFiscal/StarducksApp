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
        private Starducks.Controlador.ProductoController controlador = new Starducks.Controlador.ProductoController();
        private List<Starducks.Vista.CatalogoForms.ItemCarrito> listaCarrito = new List<Starducks.Vista.CatalogoForms.ItemCarrito>();
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
            MessageBox.Show("Cargando categoría: " + categoria);
            // 1. LIMPIEZA
            flowLayoutPanelPanelProductos.Controls.Clear();

            // 2. OBTENCIÓN
            ProductoController controlador = new ProductoController();
            DataTable dtProductos = controlador.BuscarProductos(categoria);
            MessageBox.Show("Filas encontradas en BD: " + (dtProductos != null ? dtProductos.Rows.Count.ToString() : "NULL"));
            // 3. DIBUJADO
            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                foreach (DataRow fila in dtProductos.Rows)
                {
                    // Creamos la tarjeta y le asignamos los datos de la fila
                    TarjetaProducto tarjeta = new TarjetaProducto();

                    double pChico = Convert.ToDouble(fila["precio_tall"]);
                    double pMed = Convert.ToDouble(fila["precio_grande"]);
                    double pGra = Convert.ToDouble(fila["precio_venti"]);
                    byte[] imagen = fila["foto"] != DBNull.Value ? (byte[])fila["foto"] : null;

                    tarjeta.AsignarDatos(fila["nombre"].ToString(), fila["descripcion"].ToString(), pChico, pMed, pGra, imagen);

                    // AÑADIMOS LA LÓGICA DEL CARRITO
                    tarjeta.OnAgregarAlCarrito += (s, e) =>
                    {
                        MessageBox.Show("¡Botón presionado!");
                        TarjetaProducto t = (TarjetaProducto)s;

                        double precioSeleccionado = 0;

                        if (t.cmbTamano.Text == "Chico")
                            precioSeleccionado = t.PrecioChico;
                        else if (t.cmbTamano.Text == "Mediano")
                            precioSeleccionado = t.PrecioMediano;
                        else
                            precioSeleccionado = t.PrecioGrande;

                        var nuevoItem = new Starducks.Vista.CatalogoForms.ItemCarrito();
                        nuevoItem.Nombre = t.NombreProducto;
                        nuevoItem.Tamano = t.cmbTamano.Text; // Asegúrate de guardar el tamaño
                        nuevoItem.Precio = precioSeleccionado;

                        listaCarrito.Add(nuevoItem);

                        MessageBox.Show($"{t.NombreProducto} ({t.cmbTamano.Text}) añadido al carrito!");
                        ActualizarTotal();
                    };

                    // Agregamos la tarjeta al panel principal
                    flowLayoutPanelPanelProductos.Controls.Add(tarjeta);
                    flowLayoutPanelPanelProductos.Refresh();
                }
            }
            else
            {
                MessageBox.Show("No hay productos en esta categoría.");
            }
            panelMenu.Invalidate();
            panelMenu.Update();
        }



        private void ActualizarCarritoUI()
        {
            MessageBox.Show("Tamaño de listaCarrito: " + listaCarrito.Count);
            dgvCarrito.Rows.Clear();

            foreach (var item in listaCarrito)
            {
                dgvCarrito.Rows.Add(item.Nombre, item.Tamano, "$" + item.Precio.ToString("F2"));
            }

            // Aquí llamamos al "Contador" para que nos diga cuánto sumar
            double total = CalcularTotal();
            lblTotalCarrito.Text = "Total a pagar: $" + total.ToString("F2");
        }

        // Este método "Contador" solo hace matemáticas
        private double CalcularTotal()
        {
            double suma = 0;
            foreach (var item in listaCarrito)
            {
                suma += item.Precio;
            }
            return suma;
        }

        private void ActualizarTotal()
        {
            double total = 0;
            foreach (var item in listaCarrito) { total += item.Precio; }
            lblTotalCarrito.Text = "Total: $" + total.ToString("F2");
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarCatalogo("TODOS");
        }

        private void btnCafesFrios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón presionado, intentando cargar: Cafés fríos");
            CargarCatalogo("Cafés fríos");
        }

        private void btnCafesCalientes_Click(object sender, EventArgs e)
        {
            CargarCatalogo("Cafés calientes");
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            CargarCatalogo("Postres");
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

                tarjeta.AsignarDatos(
                nombre,
                desc,
                Convert.ToDouble(fila["precio_tall"]),    // Precio chico
                Convert.ToDouble(fila["precio_grande"]),  // Precio mediano
                Convert.ToDouble(fila["precio_venti"]),   // Precio grande
                imagenBytes
                 );
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