using Starducks.Controlador;
using Starducks.Modelo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Starducks.Controlador;

namespace Starducks.Vista.CatalogoForms
{
    public partial class TarjetaProducto : UserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double PrecioChico { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double PrecioMediano { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double PrecioGrande { get; set; }
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int IdProducto { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NombreArchivoImagen { get; set; }

        public event EventHandler OnAgregarAlCarrito;

        // TARJETA PRODUCTO PRINCIPAL
        public TarjetaProducto()
        {
            InitializeComponent();
            cmbTamano.SelectedIndexChanged += cmbTamano_SelectedIndexChanged;

            // Configurar el ComboBox
            cmbTamano.Items.AddRange(new string[] { "Chico", "Mediano", "Grande" });
            cmbTamano.SelectedIndex = 1; // Mediano por defecto
            cmbTamano.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTamano.SelectedIndexChanged += cmbTamano_SelectedIndexChanged;

            btnAgregar.Click += btnAgregar_Click;
        }

        //ASIGNAR DATOS DE PRINCIPAL
        public void AsignarDatos(string nombre, string desc, double pTall, double pGrande, double pVenti, string nombreArchivo)
        {
            lblNombre.Text = nombre;
            lblDescripcion.Text = desc;
            this.PrecioChico = pTall;
            this.PrecioMediano = pGrande;
            this.PrecioGrande = pVenti;
            this.NombreArchivoImagen = nombreArchivo;

            // Buscamos el archivo en la carpeta "Imagenes" usando el nombre recibido
            string rutaCompleta = Path.Combine(Application.StartupPath, "Imagenes", nombreArchivo);

            if (File.Exists(rutaCompleta))
            {
                pbImagen.Image = Image.FromFile(rutaCompleta);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbImagen.Image = null; // O una imagen de error
            }
        }

        //ACTUALIZACION DE LOS PRECIOS AL ELEGIR EL TAMAÑO
        private void ActualizarPrecio()
        {
            switch (cmbTamano.SelectedItem.ToString())
            {
                case "Chico": lblPrecio.Text = "$" + PrecioChico.ToString("F2"); break;
                case "Mediano": lblPrecio.Text = "$" + PrecioMediano.ToString("F2"); break;
                case "Grande": lblPrecio.Text = "$" + PrecioGrande.ToString("F2"); break;
            }
        }

        //EL BOTON DE ELEGIR LOS TAMAÑOS
        private void cmbTamano_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbTamano.SelectedItem.ToString())
            {
                case "Chico":
                    lblPrecio.Text = "$" + PrecioChico.ToString("F2");
                    break;
                case "Mediano":
                    lblPrecio.Text = "$" + PrecioMediano.ToString("F2");
                    break;
                case "Grande":
                    lblPrecio.Text = "$" + PrecioGrande.ToString("F2");
                    break;
            }
        }

        //BOTON DE AÑADIR 
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            OnAgregarAlCarrito?.Invoke(this, EventArgs.Empty);
        }

        //LA TARJETA DEL PRODUCTO LOAD
        private void TarjetaProducto_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radio = 20;


            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(this.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(this.Width - radio, this.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, this.Height - radio, radio, radio, 90, 90);


            this.Region = new System.Drawing.Region(path);

            btnAgregar.Visible = false;
            btnEliminar.Visible = false;
            btnEditar.Visible = false;

            // Comparar contra lo que realmente está en la BD
            if (Sesion.Rol == "administrador")
            {
                btnAgregar.Visible = true;
                btnEliminar.Visible = true;
                btnEditar.Visible = true;
            }
            else if (Sesion.Rol == "usuario operador")
            {
                btnAgregar.Visible = true;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
            }
            else if (Sesion.Rol == "consultor")
            {
                btnAgregar.Visible = true;
                btnEliminar.Visible = false;
                btnEditar.Visible = false;
            }
        }

        //LA IMAGEN EN BYTES

        private Image BytesToImagen(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                ProductoController control = new ProductoController();
                // Llamas al método que borra usando el ID que guardamos
                bool eliminado = control.EliminarProducto(this.IdProducto);

                if (eliminado)
                {
                    this.Dispose(); // Elimina la tarjeta visualmente
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ProductoForm form = new ProductoForm();

            // Aquí es donde ocurre la magia: le inyectas la info antes de mostrarlo
            form.CargarDatosParaEditar(
            this.IdProducto,
            this.lblNombre.Text,
            this.lblDescripcion.Text,
            this.PrecioChico.ToString(),   // Asumiendo que guardas estos valores en la tarjeta
            this.PrecioMediano.ToString(),
            this.PrecioGrande.ToString(),
            this.NombreArchivoImagen
            );
            form.ShowDialog();
            Form formularioPadre = this.FindForm();
            if (formularioPadre != null)
            {
                // IMPORTANTE: Cambia "FormPrincipal" por el nombre real de tu formulario (ej. Form1)
                // Puedes ver ese nombre en la parte de arriba de tu archivo FormPrincipal.cs
                if (formularioPadre is FormPrincipal)
                {
                    ((FormPrincipal)formularioPadre).CargarCatalogo();
                }
            }
        }

        public string NombreSeleccionado => lblNombre.Text;
        public string TamanoSeleccionado => cmbTamano.SelectedItem.ToString();
        public string PrecioFinal => lblPrecio.Text;

        public string NombreProducto => lblNombre.Text;
        public double PrecioChicoVal => PrecioChico;
        public double PrecioMedianoVal => PrecioMediano;
        public double PrecioGrandeVal => PrecioGrande;

    }
}