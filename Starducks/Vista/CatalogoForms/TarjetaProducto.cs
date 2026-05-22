using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Starducks.Vista.CatalogoForms
{
    public partial class TarjetaProducto : UserControl
    {
        public TarjetaProducto()
        {
            InitializeComponent();
        }

        // Método para cargar los datos del café en los controles de la tarjeta
        public void ConfigurarTarjeta(string nombre, string descripcion, double precio, Image imagen)
        {
            lblNombre.Text = nombre;
            lblDescripcion.Text = descripcion;
            lblPrecio.Text = $"${precio:F2} MXN";

            if (imagen != null)
            {
                pbImagen.Image = imagen;
            }
        }
        public Image BytesToImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }
    }
}

