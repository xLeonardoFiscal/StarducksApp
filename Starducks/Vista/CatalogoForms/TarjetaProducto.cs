using Starducks.Controlador;
using Starducks.Modelo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
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

        public event EventHandler OnAgregarAlCarrito;

        // TARJETA PRODUCTO PRINCIPAL
        public TarjetaProducto()
        {
            InitializeComponent();

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

            // Aplicar lógica según el rol
            switch (Sesion.Rol)
            {
                case "administrado":
                    btnAgregar.Visible = true;
                    btnEliminar.Visible = true;
                    break;

                case "usuario operador":
                    btnAgregar.Visible = true;
                    btnEliminar.Visible = false;
                    break;

                case "consultor":
                    btnAgregar.Visible = true;
                    btnEliminar.Visible = false;
                    break;

                default: // Seguridad extra: si no coincide nada, ocultar todo
                    btnAgregar.Visible = false;
                    btnEliminar.Visible = false;
                    break;
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

        public string NombreSeleccionado => lblNombre.Text;
        public string TamanoSeleccionado => cmbTamano.SelectedItem.ToString();
        public string PrecioFinal => lblPrecio.Text;

        public string NombreProducto => lblNombre.Text;
        public double PrecioChicoVal => PrecioChico;
        public double PrecioMedianoVal => PrecioMediano;
        public double PrecioGrandeVal => PrecioGrande;

    }
}