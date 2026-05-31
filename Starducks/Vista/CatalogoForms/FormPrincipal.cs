using MySql.Data.MySqlClient;
using Starducks.Controlador;
using Starducks.Modelo;
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

        private void CargarCatalogo(string filtro = "")
        {
            
            // 1. LIMPIEZA
            flowLayoutPanelPanelProductos.Controls.Clear();

            // 2. OBTENCIÓN
            ProductoController controlador = new ProductoController();
            DataTable dtProductos = controlador.BuscarProductos(filtro);



            // 3. DIBUJADO
            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                foreach (DataRow fila in dtProductos.Rows)
                {
                    TarjetaProducto tarjeta = new TarjetaProducto();

                    double pChico = Convert.ToDouble(fila["precio_tall"]);
                    double pMed = Convert.ToDouble(fila["precio_grande"]);
                    double pGra = Convert.ToDouble(fila["precio_venti"]);

                    // AQUÍ ESTÁ EL CAMBIO:
                    // 1. Obtenemos el nombre del archivo como string
                    string nombreFoto = fila["foto"].ToString();

                    // 2. Pasamos el nombreFoto en lugar de la variable 'imagen' (que era byte[])
                    tarjeta.AsignarDatos(
                    fila["nombre"].ToString(),
                    fila["descripcion"].ToString(),
                    Convert.ToDouble(fila["precio_tall"]),    // pChico
                    Convert.ToDouble(fila["precio_mediano"]), // pMed
                    Convert.ToDouble(fila["precio_grande"]),  // pGra
                     nombreFoto
                    );

                    // AÑADIMOS LA LÓGICA DEL CARRITO
                    tarjeta.OnAgregarAlCarrito += (s, e) =>
                    {

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
                        nuevoItem.Tamano = t.cmbTamano.Text;
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
            dgvCarrito.Rows.Clear();
            double total = 0;

            foreach (var item in listaCarrito)
            {
                dgvCarrito.Rows.Add(item.Nombre, item.Tamano, "$" + item.Precio.ToString("F2"));
                total += item.Precio;
            }

            lblTotalCarrito.Text = "Total: $" + total.ToString("F2");
            dgvCarrito.Refresh();
        }


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


            foreach (var item in listaCarrito)
            {

                dgvCarrito.Rows.Add(item.Nombre, item.Tamano, item.Precio.ToString("C2"));
            }


            double total = listaCarrito.Sum(x => x.Precio);
            lblTotalCarrito.Text = "Total: $" + total.ToString("F2");


            dgvCarrito.Refresh();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarCatalogo("TODOS");
        }

        private void btnCafesFrios_Click(object sender, EventArgs e)
        {

            CargarCatalogo("Cafes frios");
        }

        private void btnCafesCalientes_Click(object sender, EventArgs e)
        {
            CargarCatalogo("Cafes calientes");
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
                // Obtenemos el nombre del archivo de la base de datos
                string nombreArchivo = fila["foto"].ToString();

                tarjeta.AsignarDatos(
                    nombre,
                    desc,
                    Convert.ToDouble(fila["precio_tall"]),    // Precio chico
                    Convert.ToDouble(fila["precio_mediano"]),  // Precio mediano (corregido)
                    Convert.ToDouble(fila["precio_grande"]),   // Precio grande
                    nombreArchivo 
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


            DialogResult confirmacion = MessageBox.Show("¿Finalizar pedido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {

                ProductoController controller = new ProductoController();
                double total = listaCarrito.Sum(item => item.Precio);
                controller.GuardarPedido(total, listaCarrito);

                // MOSTRAMOS EL TICKET 
                PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
                vistaPrevia.Document = printDocument1;
                vistaPrevia.ShowDialog();

                // LIMPIEZA TOTAL 
                listaCarrito.Clear();
                ActualizarTotal();

                MessageBox.Show("Pedido finalizado con éxito.");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            float y = 50;
            float anchoHoja = e.PageBounds.Width;

            StringFormat formatoCentro = new StringFormat();
            formatoCentro.Alignment = StringAlignment.Center;

            e.Graphics.DrawString("STARDUCKS", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, anchoHoja / 2, y, formatoCentro);
            y += 50;

            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString(), new Font("Arial", 10), Brushes.Black, anchoHoja / 2, y, formatoCentro);
            y += 40;

            e.Graphics.DrawLine(Pens.Black, anchoHoja * 0.1f, y, anchoHoja * 0.9f, y);
            y += 30;

            float xIzquierda = anchoHoja * 0.15f;
            foreach (var item in listaCarrito)
            {
                string linea = $"{item.Nombre} ({item.Tamano}) - ${item.Precio:F2}";
                e.Graphics.DrawString(linea, new Font("Arial", 12), Brushes.Black, xIzquierda, y);
                y += 30;
            }

            // Total
            y += 20;
            e.Graphics.DrawLine(Pens.Black, anchoHoja * 0.1f, y, anchoHoja * 0.9f, y);
            y += 30;
            e.Graphics.DrawString("TOTAL A PAGAR: $" + listaCarrito.Sum(i => i.Precio).ToString("F2"),
                                  new Font("Arial", 14, FontStyle.Bold), Brushes.Black, anchoHoja / 2, y, formatoCentro);
        }

        private void flowLayoutPanelPanelProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCafefrio_Click(object sender, EventArgs e)
        {

            CargarCatalogo("Cafes frios");
        }

        private void btnCafecaliente_Click(object sender, EventArgs e)
        {
            CargarCatalogo("Cafes calientes");
        }

        private void btnTodos_Click_1(object sender, EventArgs e)
        {
            CargarCatalogo("TODOS");
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanelPanelProductos.Controls.Clear();

            string busqueda = txtBusqueda.Text;

            // Si la barra está vacía, cargamos el catálogo completo normalmente
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                CargarCatalogo();
            }
            else
            {
                CargarCatalogo(txtBusqueda.Text);
            }
        }
    }
}
