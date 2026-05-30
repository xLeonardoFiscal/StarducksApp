using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;

namespace Starducks.Vista.CatalogoForms
{
    public partial class TarjetaProducto : UserControl
    {
        public TarjetaProducto()
        {
            InitializeComponent();
        }

        public void AsignarDatos(string nombre, string desc, double precio, byte[] imagenBytes)
        {
            lblNombre.Text = nombre;
            lblDescripcion.Text = desc;
            lblPrecio.Text = "$" + precio.ToString("F2");

            // FORZAR VISIBILIDAD (Crucial si antes no se veía nada)
            this.Visible = true;
            lblNombre.Visible = true;
            lblDescripcion.Visible = true;
            lblPrecio.Visible = true;
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
    }
}
