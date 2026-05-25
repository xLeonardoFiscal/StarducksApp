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
        public void ConfigurarTarjeta(string nombre, string descripcion, double precio, byte[] imagenBytes)
        {
            lblNombre.Text = nombre;
            lblDescripcion.Text = descripcion;
            lblPrecio.Text = $"${precio:F2} MXN";

            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                pbImagen.Image = BytesToImagen(imagenBytes);
            }
            else
            {
                
                pbImagen.Image = Properties.Resources.CafePruebas;
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
    }
}
