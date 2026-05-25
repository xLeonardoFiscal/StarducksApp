using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Starducks.Vista
{
    public partial class ProductoForm : Form
    {
        
        private byte[] fotoBytes = null;

        public ProductoForm()
        {
            InitializeComponent(); 
        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
           
        }

       
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Imagen (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
                pbPrevia.Image = Image.FromFile(dialog.FileName);

               
                fotoBytes = File.ReadAllBytes(dialog.FileName);
            }
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Por favor, llena los campos obligatorios (Nombre, Precio y Categoría).", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = txtDescripcion.Text.Trim();
                double precio = Convert.ToDouble(txtPrecio.Text.Trim());
                string categoria = cmbCategoria.SelectedItem.ToString();

             
                Starducks.Controlador.ProductoController controlador = new Starducks.Controlador.ProductoController();

                bool guardadoExitoso = controlador.InsertarProducto(nombre, descripcion, precio, categoria, fotoBytes);

                if (guardadoExitoso)
                {
                    MessageBox.Show("¡El producto se ha registrado exitosamente en Starducks!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el producto en la base de datos.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un precio numérico válido (Ej: 45.50).", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private string rolUsuarioActual;

        public FormPrincipal(string rol)
        {
            InitializeComponent();
            this.rolUsuarioActual = rol;


            AplicarPermisosPorRol();
        }

        // Método para limpiar los controles tras registrar
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cmbCategoria.SelectedIndex = -1;
            pbPrevia.Image = null;
            fotoBytes = null;
        }
    }
}