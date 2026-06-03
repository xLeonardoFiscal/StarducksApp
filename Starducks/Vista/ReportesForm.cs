using Starducks.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Starducks.Modelo;

namespace Starducks.Vista
{
    public partial class ReportesForm : Form
    {

        public ReportesForm()
        {
            InitializeComponent();

            treeReportes.Nodes.Clear();

            TreeNode usuarios = treeReportes.Nodes.Add("Usuarios");

            usuarios.Nodes.Add("Listado General");
            usuarios.Nodes.Add("Usuarios por rol");
            usuarios.Nodes.Add("Búsqueda de Usuario");
            usuarios.Nodes.Add("Cantidad de usuarios por rol");
            usuarios.Nodes.Add("Detalle de usuario");

            TreeNode productos = treeReportes.Nodes.Add("Productos");

            productos.Nodes.Add("Listado General");
            productos.Nodes.Add("Productos por categoria");
            productos.Nodes.Add("Búsqueda de producto");
            productos.Nodes.Add("Cantidad de productos disponibles");
            productos.Nodes.Add("Detalle de producto");

            TreeNode pedidos = treeReportes.Nodes.Add("Pedidos");

            pedidos.Nodes.Add("Listado General");
            pedidos.Nodes.Add("Pedidos de este dia");
            pedidos.Nodes.Add("Pedidos por Estatus");
            pedidos.Nodes.Add("Total pedidos");
            pedidos.Nodes.Add("Detalle de pedido");

            TreeNode categoria = treeReportes.Nodes.Add("Categorias de productos");

            categoria.Nodes.Add("Listado General");
            categoria.Nodes.Add("Búsqueda por nombre");
            categoria.Nodes.Add("Cantidad de productos por categoria");
            categoria.Nodes.Add("Detalle de categoria");
            categoria.Nodes.Add("Categorias con productos disponibles");

            TreeNode repartidores = treeReportes.Nodes.Add("Repartidores");

            repartidores.Nodes.Add("Listado General");
            repartidores.Nodes.Add("Repartidores Disponibles / No disponibles");
            repartidores.Nodes.Add("Búsqueda por Nombre");
            repartidores.Nodes.Add("Cantidad de pedidos entregados por repartidor");
            repartidores.Nodes.Add("Detalle de repartidor");

            TreeNode Detalles = treeReportes.Nodes.Add("Detalles de pedidos");

            Detalles.Nodes.Add("Listado General");
            Detalles.Nodes.Add("Por tamaño");
            Detalles.Nodes.Add("Búsqueda por producto");
            Detalles.Nodes.Add("Cantidad vendida por tamaño");
            Detalles.Nodes.Add("Detalle de registro");

            lblFiltro.Visible = false;
            cmbFiltro.Visible = false;  // Ocultar al inicio
            txtFiltro.Visible = false;
            btnGenerar.Visible = false;

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






        private void CargarUsuarios()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuarios();
        }

        private void CargarUsuariosPorRol()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuariosRol("administrador");
        }

        private void BuscarUsuarios()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuariosBusqueda("");
        }

        private void EstadisticaUsuarios()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuariosCantidadRol();
        }

        private void DetalleUsuarios()
        {
            ReporteController reporte = new ReporteController();

            dgvReporte.DataSource = reporte.ObtenerUsuariosDetalle("");
        }






        private string reporteSeleccionado = ""; //variable global

        private void treeReportes_AfterSelect(object sender, TreeViewEventArgs e)
        {
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
                    
                    if(string.IsNullOrWhiteSpace(txtFiltro.Text))
                    {
                        MessageBox.Show("Ingrese ID del usuario");
                        return;
                    }

                    dgvReporte.DataSource = reporte.ObtenerUsuariosDetalle(txtFiltro.Text.Trim());
                    break;
            }

        }
    }
}
