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
            this.Load += FormPrincipal_Load;
            this.WindowState = FormWindowState.Maximized; // PANTALLA COMPLETA
        }



        //CATALOGO
        public void CargarCatalogo(string filtro = "")
        {
            // 1. LIMPIEZA
            flowLayoutPanelPanelProductos.Controls.Clear();

            // 2. OBTENCIÓN
            ProductoController controlador = new ProductoController();
            DataTable dtProductos = controlador.BuscarProductos(filtro);

            if (dtProductos == null)
            {
                return;
            }

            // Esto te dirá si el problema es que la tabla está vacía en la base de datos



            // 3. DIBUJADO
            if (dtProductos != null && dtProductos.Rows.Count > 0)
            {
                //FOREACH
                foreach (DataRow fila in dtProductos.Rows)
                {
                    AgregarTarjetaAlPanel(fila);
                }
            }
        }

        //ACTUALIZAR CARRITO

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
        //CALCULAR TOTAL

        private double CalcularTotal()
        {
            double suma = 0;
            foreach (var item in listaCarrito)
            {
                suma += item.Precio;
            }
            return suma;
        }

        //ACTUALIZAR TOTAL
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
        //BTNTODOS
        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarCatalogo("TODOS");
        }

        //BTNFRIOS
        private void btnCafesFrios_Click(object sender, EventArgs e)
        {

            CargarCatalogo("Cafes frios");
        }

        //BTNCALIENTES
        private void btnCafesCalientes_Click(object sender, EventArgs e)
        {
            CargarCatalogo("Cafes calientes");
        }

        //BTNPOSTRES
        private void btnPostres_Click(object sender, EventArgs e)
        {
            CargarCatalogo("Postres");
        }

        //BUCADOR CATALOGO
        private void BuscarCatalogo(string textoBusqueda)
        {

            CargarCatalogo(textoBusqueda);
        }

        //el catalago se agregan los prodcutos solo para que ya solo quede una y no dividido
        private void AgregarTarjetaAlPanel(DataRow fila)
        {
            TarjetaProducto tarjeta = new TarjetaProducto();
            tarjeta.IdProducto = Convert.ToInt32(fila["id_producto"]); 

            // 1. ASIGNACIÓN DE DATOS
            tarjeta.AsignarDatos(
                fila["nombre"].ToString(),
                fila["descripcion"].ToString(),
                Convert.ToDouble(fila["precio_tall"]),
                Convert.ToDouble(fila["precio_grande"]),
                Convert.ToDouble(fila["precio_venti"]),
                fila["foto"].ToString().Trim() // Nombre del archivo .jpg
            );

            // 2. LÓGICA DEL BOTÓN AÑADIR (Evento compartido)
            tarjeta.OnAgregarAlCarrito += (s, e) =>
            {
                TarjetaProducto t = (TarjetaProducto)s;
                double precio = 0;

                // Asegúrate de que cmbTamano sea el nombre real en tu TarjetaProducto
                if (t.cmbTamano.Text == "Chico") precio = t.PrecioChico;
                else if (t.cmbTamano.Text == "Mediano") precio = t.PrecioMediano;
                else precio = t.PrecioGrande;

                // Agregar a la lista del carrito
                var nuevoItem = new Starducks.Vista.CatalogoForms.ItemCarrito();
                nuevoItem.Nombre = t.lblNombre.Text;
                nuevoItem.Tamano = t.cmbTamano.Text;
                nuevoItem.Precio = precio;

                listaCarrito.Add(nuevoItem);
                ActualizarTotal(); // Método que suma los precios
                MessageBox.Show($"{t.lblNombre.Text} añadido al carrito!");
            };

            // 3. DIBUJADO EN EL PANEL CORRECTO
            tarjeta.Margin = new Padding(12);
            flowLayoutPanelPanelProductos.Controls.Add(tarjeta);
        }


        //FORMPRINCIPAL LOAD
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            AplicarPermisos();

            panelMenu.Controls.Clear();

            CargarCatalogo("TODOS");
        }

        private void AplicarPermisos()
        {
            string rol = Sesion.Rol != null ? Sesion.Rol.Trim().ToLower() : "";

            // Aseguramos el estado de cada uno
            btnReportesForm.Visible = (rol == "administrador");
            btnConsultas.Visible = (rol == "administrador" || rol == "usuario operador");
            btnUsuarios.Visible = (rol == "administrador");
            btnAgregarProducto.Visible = (rol == "administrador");
        }

        //BTN PAGAR
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
        //IMPRIMIR TICKET
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

        //BUSCADOR DE PRODUCTOS
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

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

        private void btnReportesForm_Click(object sender, EventArgs e)
        {
            if (Sesion.Rol != "ADMIN")
            {
                MessageBox.Show("Acceso denegado. Solo administradores pueden ver reportes.");
                return;
            }
            ReportesForm reportes = new ReportesForm();
            reportes.Owner = this;
            reportes.Show();
            this.Hide();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ConsultasForm consultas = new ConsultasForm();
            consultas.Owner = this;
            consultas.Show();
            this.Hide();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosForm formusuarios = new UsuariosForm();
            formusuarios.Owner = this;
            formusuarios.Show();
            this.Hide();
        }

        private void FormPrincipal_Load_1(object sender, EventArgs e)
        {
            AplicarPermisos();

            panelMenu.Controls.Clear();


        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ProductoForm form = new ProductoForm();
            form.ShowDialog();
            CargarCatalogo("TODOS");

        }
    }
}