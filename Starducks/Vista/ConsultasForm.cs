using Starducks.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Starducks.Vista
{
    public partial class ConsultasForm : Form
    {
        public ConsultasForm()
        {
            InitializeComponent();

            treeConsultas.Nodes.Clear();

            treeConsultas.Nodes.Add("Usuarios");
            treeConsultas.Nodes.Add("Productos");
            treeConsultas.Nodes.Add("Pedidos");
            treeConsultas.Nodes.Add("Repartidores");
            treeConsultas.Nodes.Add("Categorias");
            treeConsultas.Nodes.Add("Detalle Pedido");

            MakePictureBoxCircular(pbLogo);
        }

        //Varaible global de la consulta seleccionada
        private string consultaSeleccionada = "";

        private void LimpiarPantalla()
        {
            txtFiltro.Clear();
            cmbFiltro.SelectedIndex = -1;
            dgvConsulta.DataSource = null;
            lblTotal.Text = "Total registros: 0";
        }

        private void LimpiarControles()
        {
            dtInicio.Visible = false;
            dtFin.Visible = false;
            cmbFiltro.Visible = false;
            txtFiltro.Visible = false;
            lbltxt.Visible = false;
            lblcmb.Visible = false;
            lblInicio.Visible = false;
            lblFin.Visible = false;

        }


        //METODO PARA REDONDEAR LAS PICTUREBOX
        private void MakePictureBoxCircular(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(gp);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void treeConsultas_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LimpiarPantalla();
            LimpiarControles();
            consultaSeleccionada = e.Node.Text;

            switch (e.Node.Text)
            {
                case "Usuarios":

                    lbltxt.Visible = true;
                    cmbFiltro.Visible = true;
                    txtFiltro.Visible = true;
                    btnBuscar.Visible = true;
                    btnLimpiar.Visible = true;
                    lblcmb.Visible = true;

                    lbltxt.Text = "Nombre del usuario:";
                    lblcmb.Text = "Rol del usuario:";
                    cmbFiltro.Items.Clear();

                    cmbFiltro.Items.Add("administrador");
                    cmbFiltro.Items.Add("usuario operador");
                    cmbFiltro.Items.Add("consultor");

                    break;

                case "Productos":

                    lbltxt.Visible = true;
                    txtFiltro.Visible = true;
                    lblcmb.Visible = true;
                    btnBuscar.Visible = true;
                    btnLimpiar.Visible = true;
                    cmbFiltro.Visible = true;


                    lbltxt.Text = "Nombre del producto:";
                    lblcmb.Text = "Categoria del producto:";
                    cmbFiltro.Items.Clear();

                    cmbFiltro.Items.Add("cafes frios");
                    cmbFiltro.Items.Add("Cafes calientes");
                    cmbFiltro.Items.Add("Postres");

                    break;

                case "Pedidos":
                    btnBuscar.Visible = true;
                    btnLimpiar.Visible = true;
                    dtInicio.Visible = true;
                    dtFin.Visible = true;
                    cmbFiltro.Visible = true;
                    lblInicio.Visible = true;
                    lblFin.Visible = true;
                    lblcmb.Visible = true;

                    lblcmb.Text = "Estatus del pedido:";
                    cmbFiltro.Items.Clear();

                    cmbFiltro.Items.Add("pendiente");
                    cmbFiltro.Items.Add("preparando");
                    cmbFiltro.Items.Add("en camino");
                    cmbFiltro.Items.Add("entregado");

                    break;

                case "Repartidores":
                    lbltxt.Visible = true;
                    btnBuscar.Visible = true;
                    btnLimpiar.Visible = true;
                    txtFiltro.Visible = true;
                    cmbFiltro.Visible = true;
                    lblcmb.Visible = true;

                    lbltxt.Text = "Nombre del repartidor:";
                    lblcmb.Text = "Disponible(1) / No Disponible(0):";
                    cmbFiltro.Items.Clear();

                    cmbFiltro.Items.Add("0");
                    cmbFiltro.Items.Add("1");
                    break;

                case "Categorias":
                    lbltxt.Visible = true;
                    btnBuscar.Visible = true;
                    btnLimpiar.Visible = true;
                    txtFiltro.Visible = true;

                    lbltxt.Text = "Nombre de categoria:";
                    break;

                case "Detalle Pedido":
                    lbltxt.Visible = true;
                    btnBuscar.Visible = true;
                    btnLimpiar.Visible = true;
                    txtFiltro.Visible = true;
                    cmbFiltro.Visible = true;
                    lblcmb.Visible = true;

                    lbltxt.Text = "Nombre del producto:";
                    lblcmb.Text = "Tamaño del producto:";
                    cmbFiltro.Items.Clear();

                    cmbFiltro.Items.Add("tall");
                    cmbFiltro.Items.Add("venti");
                    cmbFiltro.Items.Add("grande");
                    break;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaController consulta = new ConsultaController();

            switch (consultaSeleccionada)
            {
                case "Usuarios":

                    dgvConsulta.DataSource = consulta.ObtenerUsuarios(txtFiltro.Text.Trim(), cmbFiltro.Text);

                    break;

                case "Productos":

                    dgvConsulta.DataSource = consulta.ObtenerProductos(txtFiltro.Text.Trim(), cmbFiltro.Text);

                    break;

                case "Pedidos":

                    dgvConsulta.DataSource = consulta.ObtenerPedidos(dtInicio.Value, dtFin.Value, cmbFiltro.Text);

                    break;

                case "Categorias":
                    dgvConsulta.DataSource = consulta.ObtenerCategorias(txtFiltro.Text.Trim());
                    break;

                case "Repartidores":
                    dgvConsulta.DataSource = consulta.ObtenerRepartidores(txtFiltro.Text.Trim(), cmbFiltro.Text);
                    break;

                case "Detalle Pedido":
                    dgvConsulta.DataSource = consulta.ObtenerDetalles(txtFiltro.Text.Trim(), cmbFiltro.Text);
                    break;
            }

            lblTotal.Text = "Total registros: " + dgvConsulta.Rows.Count;
        }

        private void dgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvConsulta.Rows[e.RowIndex].Cells[0].Value.ToString();

                MessageBox.Show("ID seleccionado: " + id);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }
    }
}
