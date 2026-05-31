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
            dgvCarrito.Rows.Clear(); // Limpia la vista actual
            double total = 0;

            foreach (var item in listaCarrito)
            {
                dgvCarrito.Rows.Add(item.Nombre, item.Tamano, "$" + item.Precio.ToString("F2"));
                total += item.Precio;
            }

            lblTotalCarrito.Text = "Total: $" + total.ToString("F2");
            dgvCarrito.Refresh(); // Fuerza el refresco visual
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
            dgvCarrito.Rows.Clear();

            // Recorremos la lista y añadimos cada fila al DataGridView
            foreach (var item in listaCarrito)
            {
                // IMPORTANTE: Asegúrate de que el orden de columnas coincida
                // con lo que definiste en el diseñador o por código.
                dgvCarrito.Rows.Add(item.Nombre, item.Tamano, item.Precio.ToString("C2"));
            }

            // Actualizamos total en el label
            double total = listaCarrito.Sum(x => x.Precio);
            lblTotalCarrito.Text = "Total: $" + total.ToString("F2");

            // Forzamos el refresco visual
            dgvCarrito.Refresh();
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

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (listaCarrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.", "Starducks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmación
            DialogResult confirmacion = MessageBox.Show("¿Finalizar pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // --- AQUÍ LLAMAS A TU GUARDADO EN BD ---
                ProductoController controller = new ProductoController();
                double total = listaCarrito.Sum(item => item.Precio);
                controller.GuardarPedido(total, listaCarrito);

                // 3. AHORA MOSTRAMOS EL TICKET (La lista aún tiene los datos)
                PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
                vistaPrevia.Document = printDocument1;
                vistaPrevia.ShowDialog();

                // 4. LIMPIEZA TOTAL (Solo después de mostrar el ticket)
                listaCarrito.Clear();
                ActualizarTotal();

                MessageBox.Show("Pedido finalizado con éxito.");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 1. Configuraciones iniciales
            float y = 50; // Margen superior
            float anchoHoja = e.PageBounds.Width;

            // Objeto para centrar texto
            StringFormat formatoCentro = new StringFormat();
            formatoCentro.Alignment = StringAlignment.Center;

            // 2. Título (Centrado en el ancho de la hoja)
            e.Graphics.DrawString("STARDUCKS", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, anchoHoja / 2, y, formatoCentro);
            y += 50;

            // 3. Fecha
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString(), new Font("Arial", 10), Brushes.Black, anchoHoja / 2, y, formatoCentro);
            y += 40;

            // 4. Línea divisoria (dibujada desde el 10% hasta el 90% del ancho)
            e.Graphics.DrawLine(Pens.Black, anchoHoja * 0.1f, y, anchoHoja * 0.9f, y);
            y += 30;

            // 5. Productos (Alineados a la izquierda pero con margen)
            float xIzquierda = anchoHoja * 0.15f; // Margen izquierdo
            foreach (var item in listaCarrito)
            {
                string linea = $"{item.Nombre} ({item.Tamano}) - ${item.Precio:F2}";
                e.Graphics.DrawString(linea, new Font("Arial", 12), Brushes.Black, xIzquierda, y);
                y += 30;
            }

            // 6. Total
            y += 20;
            e.Graphics.DrawLine(Pens.Black, anchoHoja * 0.1f, y, anchoHoja * 0.9f, y);
            y += 30;
            e.Graphics.DrawString("TOTAL A PAGAR: $" + listaCarrito.Sum(i => i.Precio).ToString("F2"),
                                  new Font("Arial", 14, FontStyle.Bold), Brushes.Black, anchoHoja / 2, y, formatoCentro);
        }
    }
}
