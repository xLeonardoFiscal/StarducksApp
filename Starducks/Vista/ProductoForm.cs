using MySql.Data.MySqlClient;
using Starducks.Modelo;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Starducks.Vista
{
    public partial class ProductoForm : Form
    {
        // Variable para guardar la ruta de la imagen seleccionada temporalmente
        private string rutaImagenSeleccionada = "";

        public ProductoForm()
        {
            InitializeComponent();
        }

        // 1. EVENTO PARA CARGAR IMAGEN
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        rutaImagenSeleccionada = ofd.FileName;

                        // Usamos un bloque para asegurar que el archivo no quede bloqueado
                        // pbProducto es el nombre de tu control
                        using (var fs = new FileStream(rutaImagenSeleccionada, FileMode.Open, FileAccess.Read))
                        {
                            pbProducto.Image = Image.FromStream(fs);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                    }
                }
            }
        }

        // 2. EVENTO PARA GUARDAR PRODUCTO
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text)) { MessageBox.Show("Ponle un nombre al producto"); return; }
            if (string.IsNullOrEmpty(rutaImagenSeleccionada)) { MessageBox.Show("Selecciona una imagen primero"); return; }

            try
            {
                // 2. Preparar el archivo (como hicimos antes)
                string nombreArchivo = Guid.NewGuid().ToString() + Path.GetExtension(rutaImagenSeleccionada);
                string destino = Path.Combine(Application.StartupPath, "Imagenes", nombreArchivo);
                Directory.CreateDirectory(Path.GetDirectoryName(destino));
                File.Copy(rutaImagenSeleccionada, destino);

                // 3. Insertar en MySQL
                string conexionString = "server=localhost;database=starducks;uid=root;pwd=TU_CONTRASEÑA;";
                using (MySqlConnection con = new MySqlConnection(conexionString))
                {
                    string query = "INSERT INTO productos (nombre, precio, descripcion, imagen) VALUES (@nombre, @precio, @desc, @img)";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@img", nombreArchivo); // Solo guardamos el nombre del archivo

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("¡Producto guardado exitosamente!");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            pbProducto.Image = null;
            rutaImagenSeleccionada = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
