using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Starducks.Vista.FormCatalogo
{
    public partial class CardProducto : UserControl
    {
        public CardProducto()
        {
            InitializeComponent();
        }
        public string Titulo
        {
            get => lblNombre.Text;
            set => lblNombre.Text = value;
        }

        public Image Foto
        {
            get => picImagen.Image;
            set => picImagen.Image = value;
        }

        public string Costo
        {
            get => lblPrecio.Text;
            set => lblPrecio.Text = value;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
