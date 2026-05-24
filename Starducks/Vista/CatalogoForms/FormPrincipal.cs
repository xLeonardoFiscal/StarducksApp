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
            CargarCatalogo();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCatalogo();
        }

        private void CargarCatalogo()
        {
            // Limpiamos el contenedor por si acaso
            flowLayoutPanelProductos.Controls.Clear();

            // Simulamos datos de ejemplo. En un caso real, esto vendría de un bucle (while o foreach) desde tu BD.
            for (int i = 1; i <= 8; i++)
            {
                TarjetaProducto tarjeta = new TarjetaProducto();

                // Aquí defines los datos de cada producto. 
                // Nota: Asegúrate de tener imágenes asignadas o un recurso por defecto.
                string nombre = i % 2 == 0 ? "Espresso Intenso" : "Latte Vainilla";
                string desc = "Granos arábica, notas intensas y cuerpo completo.";
                double precio = i % 2 == 0 ? 45.00 : 55.00;
                Image imgCafe = Properties.Resources.CafePruebas;// Sustituye por tus imágenes de Resources

                // Configuramos los textos e imagen de la tarjeta
                tarjeta.ConfigurarTarjeta(nombre, desc, precio, imgCafe);

                // Un pequeño margen entre tarjetas para que respiren
                tarjeta.Margin = new Padding(12);

                // ¡La magia! El FlowLayoutPanel lo acomoda automáticamente en el grid
                flowLayoutPanelProductos.Controls.Add(tarjeta);
            }
        }

        private void flowLayoutPanelProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCafecaliente_Click(object sender, EventArgs e)
        {

        }

        private void btnPostres_Click(object sender, EventArgs e)
        {

        }
    }
}
