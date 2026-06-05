using iTextSharp.text;
using iTextSharp.text.pdf;
using Starducks.Controlador;
using Starducks.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Starducks.Vista
{
    public partial class ReportesForm : Form
    {

        public ReportesForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            treeReportes.Nodes.Clear();

            TreeNode usuarios = treeReportes.Nodes.Add("Usuarios");

            usuarios.Nodes.Add("Listado General");
            usuarios.Nodes.Add("Usuarios por rol");
            usuarios.Nodes.Add("Búsqueda de Usuario");
            usuarios.Nodes.Add("Cantidad de usuarios por rol");
            usuarios.Nodes.Add("Detalle de usuario");

            TreeNode productos = treeReportes.Nodes.Add("Productos");

            productos.Nodes.Add("Listado General de productos");
            productos.Nodes.Add("Productos por categoria");
            productos.Nodes.Add("Búsqueda de producto");
            productos.Nodes.Add("Cantidad de productos disponibles");
            productos.Nodes.Add("Detalle de producto");

            TreeNode pedidos = treeReportes.Nodes.Add("Pedidos");

            pedidos.Nodes.Add("Listado General de pedidos");
            pedidos.Nodes.Add("Pedidos de este dia");
            pedidos.Nodes.Add("Pedidos por Estatus");
            pedidos.Nodes.Add("Total pedidos");
            pedidos.Nodes.Add("Detalle de pedido");

            TreeNode categoria = treeReportes.Nodes.Add("Categorias de productos");

            categoria.Nodes.Add("Listado General de categorias");
            categoria.Nodes.Add("Búsqueda por nombre");
            categoria.Nodes.Add("Cantidad de productos por categoria");
            categoria.Nodes.Add("Detalle de categoria");
            categoria.Nodes.Add("Categorias con productos disponibles");

            TreeNode repartidores = treeReportes.Nodes.Add("Repartidores");

            repartidores.Nodes.Add("Listado General de repartidores");
            repartidores.Nodes.Add("Repartidores Disponibles / No disponibles");
            repartidores.Nodes.Add("Búsqueda por Nombre");
            repartidores.Nodes.Add("Cantidad de pedidos entregados por repartidor");
            repartidores.Nodes.Add("Detalle de repartidor");

            TreeNode Detalles = treeReportes.Nodes.Add("Detalles de pedidos");

            Detalles.Nodes.Add("Listado General de los Detalles de pedidos");
            Detalles.Nodes.Add("Por tamaño");
            Detalles.Nodes.Add("Búsqueda por producto");
            Detalles.Nodes.Add("Cantidad vendida por tamaño");
            Detalles.Nodes.Add("Detalle de registro");

            // Auditoria
            TreeNode auditoria = treeReportes.Nodes.Add("Auditoria");

            auditoria.Nodes.Add("Listado General de Auditoria");
            auditoria.Nodes.Add("Cambios Ultimos 10 Dias");
            auditoria.Nodes.Add("Cantidad de Updates y Deletes");

            lblFiltro.Visible = false;
            cmbFiltro.Visible = false;  // Ocultar al inicio
            txtFiltro.Visible = false;
            btnGenerar.Visible = false;

            lblBienvenida.Text = "Bienvenido " + Sesion.UsuarioActual + "!";

            MakePictureBoxCircular(pbLogo);
        }



        //METODO PARA REDONDEAR LAS PICTUREBOX
        private void MakePictureBoxCircular(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(gp);
        }


        private void LimpiarControles()  // LIMPIA TXTFILTRO, CMBFILTRO y DGVREPORTES
        {
            txtFiltro.Clear();

            cmbFiltro.SelectedIndex = -1;
            cmbFiltro.Items.Clear();

            dgvReporte.DataSource = null;
            dgvReporte.Rows.Clear();
            dgvReporte.Columns.Clear();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuarios();
        }



        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();

                guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";

                guardar.FileName = reporteSeleccionado + ".pdf";

                if (guardar.ShowDialog() == DialogResult.OK)
                {

                    Document documento = new Document(PageSize.A4);

                    PdfWriter writer = PdfWriter.GetInstance(documento, new FileStream(guardar.FileName, FileMode.Create));

                    writer.PageEvent = new PiePagina();



                    documento.Open();

                    //LOGO
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Starducks.Properties.Resources.LogoPato, System.Drawing.Imaging.ImageFormat.Jpeg);

                    logo.ScaleToFit(100f, 100f);

                    logo.Alignment = Element.ALIGN_CENTER;

                    documento.Add(logo);

                    // Titulo
                    iTextSharp.text.Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);

                    Paragraph titulo = new Paragraph("STARDUCKS", tituloFont);

                    titulo.Alignment = Element.ALIGN_CENTER;

                    documento.Add(titulo);


                    //Tipo de reporte
                    Paragraph reporte = new Paragraph(reporteSeleccionado, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));

                    reporte.Alignment = Element.ALIGN_CENTER;

                    documento.Add(reporte);


                    documento.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")));

                    documento.Add(new Paragraph("Generado por: " + Sesion.UsuarioActual));

                    documento.Add(new Paragraph("--------------------------------------------------------------------------------------------------------------------------"));

                    documento.Add(new Paragraph(" "));

                    PdfPTable tabla = new PdfPTable(dgvReporte.Columns.Count);

                    foreach (DataGridViewColumn col in dgvReporte.Columns)
                    {
                        tabla.AddCell(col.HeaderText);
                    }

                    foreach (DataGridViewRow fila in dgvReporte.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            foreach (DataGridViewCell celda in fila.Cells)
                            {
                                tabla.AddCell(celda.Value?.ToString() ?? "");
                            }
                        }
                    }

                    documento.Add(tabla);

                    documento.Close();

                    MessageBox.Show("PDF generado correctamente.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }




        // USUARIOS

        private void CargarUsuarios()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuarios();
        }


        private void EstadisticaUsuarios()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuariosCantidadRol();
        }


        // PRODCUTOS

        private void CargarProductos()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerProductosGeneral();
        }

        private void CargarProductoCategoriaCantidad()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerProductoCategoriaCantidad();
        }


        // PEDIDOS

        private void CargarPedidos()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerPedidosGeneral();
        }

        private void CargarPedidosDeHoy()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerPedidosDeHoy();
        }

        private void CargarPedidosTotalEstatus()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerPedidosTotalEstatus();
        }



        // REPARTIDORES

        private void CargarRepartidoresGeneral()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerRepartidoresGeneral();
        }


        private void CargarRepartidoresPedidos()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerRepartidoresPedidos();
        }



        // CATEGORIAS
        private void CargarCategoriasGeneral()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerCategoriasGeneral();
        }

        private void CargarCategoriasCantidadProductos()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerCategoriasCantidadProductos();
        }

        private void CargarCategoriasDisponibles()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerCategoriasDisponibles();
        }



        // DETALLES PRODUCTOS
        private void CargarDetallesGeneral()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerDetallesGeneral();
        }

        private void CargarDetallesCantidad()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerDetallesCantidad();
        }




        // AUDITORIAS
        private void CargarAuditoriaGeneral()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerAuditoriaGeneral();
        }

        private void CargarAuditoriaUltimos10Dias()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerAuditoriaUltimos10Dias();
        }

        private void CargarAuditoriaCantidad()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerAuditoriaCantidad();
        }




        private string reporteSeleccionado = ""; //variable global

        private void treeReportes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LimpiarControles();

            reporteSeleccionado = e.Node.Text; // se guarda que reporte esta activo
            string opcion = e.Node.Text;

            dgvReporte.ClearSelection();
            cmbFiltro.Visible = false;
            lblFiltro.Visible = false;
            txtFiltro.Visible = false;
            btnGenerar.Visible = false;

            cmbFiltro.Items.Clear();

            switch (e.Node.Text)
            {
                case "Listado General":

                    CargarUsuarios();
                    break;

                case "Usuarios por rol":
                    lblFiltro.Visible = true;
                    cmbFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Rol: ";

                    cmbFiltro.Items.Add("administrador");
                    cmbFiltro.Items.Add("usuario operador");
                    cmbFiltro.Items.Add("usuario consultor");

                    break;

                case "Búsqueda de Usuario":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Nombre o usuario: ";

                    break;

                case "Cantidad de usuarios por rol":
                    EstadisticaUsuarios();
                    break;

                case "Detalle de usuario":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese id del usuario:";
                    break;


                //Productos
                case "Listado General de productos":
                    CargarProductos();
                    break;

                case "Productos por categoria":
                    cmbFiltro.Visible = true;
                    lblFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Eliga la categoria";

                    cmbFiltro.Items.Add("cafes frios");
                    cmbFiltro.Items.Add("Cafes calientes");
                    cmbFiltro.Items.Add("Postres");

                    break;

                case "Búsqueda de producto":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el nombre del producto:";
                    break;

                case "Cantidad de productos disponibles":
                    CargarProductoCategoriaCantidad();
                    break;

                case "Detalle de producto":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese id del producto:";
                    break;


                // pedidos
                case "Listado General de pedidos":
                    CargarPedidos();
                    break;

                case "Pedidos de este dia":
                    CargarPedidosDeHoy();
                    break;

                case "Pedidos por Estatus":
                    cmbFiltro.Visible = true;
                    lblFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Elija el estatus";

                    cmbFiltro.Items.Add("pendiente");
                    cmbFiltro.Items.Add("preparando");
                    cmbFiltro.Items.Add("en camino");
                    cmbFiltro.Items.Add("entregado");
                    break;

                case "Total pedidos":
                    CargarPedidosTotalEstatus();
                    break;

                case "Detalle de pedido":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el ID del pedido:";
                    break;


                // categorias
                case "Listado General de categorias":
                    CargarCategoriasGeneral();
                    break;

                case "Búsqueda por nombre":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el nombre de la categoria a buscar:";
                    break;

                case "Cantidad de productos por categoria":
                    CargarCategoriasCantidadProductos();
                    break;

                case "Detalle de categoria":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el ID de la categoria:";
                    break;

                case "Categorias con productos disponibles":
                    CargarCategoriasDisponibles();
                    break;


                // repartidores
                case "Listado General de repartidores":
                    CargarRepartidoresGeneral();
                    break;

                case "Repartidores Disponibles / No disponibles":
                    cmbFiltro.Visible = true;
                    lblFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Elija Diponibles(1) o no Disponibles(0)";

                    cmbFiltro.Items.Add("0");
                    cmbFiltro.Items.Add("1");
                    break;

                case "Búsqueda por Nombre":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el nombre del Repartidor:";
                    break;

                case "Cantidad de pedidos entregados por repartidor":
                    CargarRepartidoresPedidos();
                    break;

                case "Detalle de repartidor":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el ID del repartidor:";
                    break;


                // Detalles de pedidos
                case "Listado General de los Detalles de pedidos":
                    CargarDetallesGeneral();
                    break;

                case "Por tamaño":
                    cmbFiltro.Visible = true;
                    lblFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Elija el tamaño";

                    cmbFiltro.Items.Add("tall");
                    cmbFiltro.Items.Add("grande");
                    cmbFiltro.Items.Add("venti");
                    break;

                case "Búsqueda por producto":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el nombre del producto";
                    break;

                case "Cantidad vendida por tamaño":
                    CargarDetallesCantidad();
                    break;

                case "Detalle de registro":
                    lblFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnGenerar.Visible = true;

                    lblFiltro.Text = "Ingrese el ID del detalle del producto a buscar";
                    break;
                    //Auditoria
                case "Listado General de Auditoria":
                    CargarAuditoriaGeneral();
                    break;

                case "Cambios Ultimos 10 Dias":
                    CargarAuditoriaUltimos10Dias();
                    break;

                case "Cantidad de Updates y Deletes":
                    CargarAuditoriaCantidad();
                    break;
            }
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ReporteController reporte = new ReporteController();

            switch (reporteSeleccionado)
            {
                case "Usuarios por rol":

                    if (cmbFiltro.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un rol");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerUsuariosRol(cmbFiltro.SelectedItem.ToString());
                    break;


                case "Búsqueda de Usuario":

                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese nombre o usuario a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerUsuariosBusqueda(txtFiltro.Text.Trim());
                    break;


                case "Detalle de usuario":

                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese ID del usuario");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerUsuariosDetalle(txtFiltro.Text.Trim());
                    break;



                // Productos

                case "Productos por categoria":
                    if (cmbFiltro.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione una categoria");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerProductosCategoria(cmbFiltro.SelectedItem.ToString());
                    break;

                case "Búsqueda de producto":

                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese nombre o producto a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerProductoBusqueda(txtFiltro.Text.Trim());
                    break;

                case "Detalle de producto":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese id del producto a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerProductoDetalle(txtFiltro.Text.Trim());
                    break;



                // PEDIDOS

                case "Pedidos por Estatus":
                    if (cmbFiltro.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un estatus");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerPedidosEstatus(cmbFiltro.SelectedItem.ToString());
                    break;


                case "Detalle de pedido":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese id del pedido a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerPedidosDetalle(txtFiltro.Text.Trim());
                    break;




                // REPARTIDORES
                case "Repartidores Disponibles / No disponibles":
                    if (cmbFiltro.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione si quiere ver Repartidores Disponibles(1) o no Disponibles(0)");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerRepartidoresDisponibilidad(cmbFiltro.SelectedItem.ToString());
                    break;


                case "Búsqueda por Nombre":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese el nombre del repartidor a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerRepartidoresBusqueda(txtFiltro.Text.Trim());
                    break;


                case "Detalle de repartidor":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese id del repartidor a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerRepartidoresDetalle(txtFiltro.Text.Trim());
                    break;




                // CATEGORIAS

                case "Búsqueda por nombre":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese el nombre de la categoria a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerCategoriasBusqueda(txtFiltro.Text.Trim());
                    break;

                case "Detalle de categoria":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese id de la categoria a buscar");
                        return;

                    }

                    dgvReporte.DataSource = reporte.ObtenerCategoriasDetalle(txtFiltro.Text.Trim());
                    break;



                // DETALLES PRODUCTOS
                case "Por tamaño":
                    if (cmbFiltro.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un tamaño");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerDetallesTamano(cmbFiltro.SelectedItem.ToString());
                    break;

                case "Búsqueda por producto":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese el producto del detalle a buscar");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerDetallesBusqueda(txtFiltro.Text.Trim());
                    break;

                case "Detalle de registro":
                    if (string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese id del Detalle del producto a buscar");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerDetallesRegistro(txtFiltro.Text.Trim());
                    break;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
