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

        private int idProductoActual = 0;
        private string nombreImagenActual = "";
        

        public ProductoForm()
        {
            InitializeComponent();
        }
        public ProductoForm(int id, string nombre, string desc, double precio)
        {
            InitializeComponent();

            // Rellenamos los campos automáticamente
            txtId.Text = id.ToString(); // Necesitas un campo oculto para el ID
            txtNombre.Text = nombre;
            txtDescripcion.Text = desc;
            txtPrecioTall.Text = precio.ToString();
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
            // 1. Validaciones
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            try
            {
                // 2. Manejo de imagen (mantiene la anterior si no se selecciona nueva)
                string nombreArchivoFinal = nombreImagenActual;

                if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
                {
                    nombreArchivoFinal = Guid.NewGuid().ToString() + Path.GetExtension(rutaImagenSeleccionada);
                    string destino = Path.Combine(Application.StartupPath, "Imagenes", nombreArchivoFinal);
                    Directory.CreateDirectory(Path.GetDirectoryName(destino));
                    File.Copy(rutaImagenSeleccionada, destino);
                }

                // 3. Consulta ajustada a tus columnas exactas
                string query = "";
                if (idProductoActual == 0) // INSERT
                {
                    query = @"INSERT INTO productos (nombre, descripcion, precio_tall, precio_grande, precio_venti, foto) 
                      VALUES (@nombre, @desc, @pTall, @pGrande, @pVenti, @foto)";
                }
                else // UPDATE
                {
                    query = @"UPDATE productos SET 
                      nombre = @nombre, 
                      descripcion = @desc, 
                      precio_tall = @pTall, 
                      precio_grande = @pGrande, 
                      precio_venti = @pVenti, 
                      foto = @foto 
                      WHERE id_producto = @id";
                }

                
                string conexionString = "server=localhost;database=starducks;uid=root;pwd=Lizbethhdz17 ; AllowPublicKeyRetrieval=True;";

                using (MySqlConnection con = new MySqlConnection(conexionString))
                {
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@pTall", txtPrecioTall.Text);     // Asegúrate que tus TextBox se llamen así
                    cmd.Parameters.AddWithValue("@pGrande", txtPrecioGrande.Text);
                    cmd.Parameters.AddWithValue("@pVenti", txtPrecioVenti.Text);
                    cmd.Parameters.AddWithValue("@foto", nombreArchivoFinal);

                    if (idProductoActual != 0)
                        cmd.Parameters.AddWithValue("@id", idProductoActual);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Guardado exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        public void CargarDatosParaEditar(int id, string nombre, string desc, string pTall, string pMediano, string pGrande, string nombreImagen)
        {
            this.idProductoActual = id;
            {
                this.idProductoActual = id;
                this.txtNombre.Text = nombre;
                this.txtDescripcion.Text = desc;

                this.txtPrecioTall.Text = pTall;
                this.txtPrecioGrande.Text = pMediano;
                this.txtPrecioVenti.Text = pGrande;

                this.nombreImagenActual = nombreImagen.Trim();

                // Carga de imagen con ruta segura
                string rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", this.nombreImagenActual);
                if (File.Exists(rutaImagen))
                {
                    pbProducto.ImageLocation = rutaImagen;
                }
                else
                {
                    pbProducto.Image = null; // Limpiar si no existe
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtPrecioTall.Clear();
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
