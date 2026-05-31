using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
namespace Starducks.Vista.CatalogoForms
{
    public partial class TarjetaProducto : UserControl
    {
        // Propiedades para los precios
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double PrecioChico { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double PrecioMediano { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double PrecioGrande { get; set; }

        // Evento para que el Form principal sepa cuando agregamos algo
        public event EventHandler OnAgregarAlCarrito;

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

        public void AsignarDatos(string nombre, string desc, double pChico, double pMed, double pGra, byte[] imagenBytes)
        {
            lblNombre.Text = nombre;
            lblDescripcion.Text = desc;

            // 2. Guardar los precios en tus propiedades públicas
            this.PrecioChico = pChico;
            this.PrecioMediano = pMed;
            this.PrecioGrande = pGra;

            // 3. Mostrar el precio inicial (por ejemplo, el mediano)
            lblPrecio.Text = "$" + pMed.ToString("F2");

            // 4. Convertir los bytes a imagen para el PictureBox
            if (imagenBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pbImagen.Image = Image.FromStream(ms);
                }
            }
        }

        private void ActualizarPrecio()
        {
            switch (cmbTamano.SelectedItem.ToString())
            {
                case "Chico": lblPrecio.Text = "$" + PrecioChico.ToString("F2"); break;
                case "Mediano": lblPrecio.Text = "$" + PrecioMediano.ToString("F2"); break;
                case "Grande": lblPrecio.Text = "$" + PrecioGrande.ToString("F2"); break;
            }
        }

        private void cmbTamano_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dependiendo de lo que elija el usuario, cambiamos el texto del lblPrecio
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Disparar evento para que el Form principal capture la acción
            OnAgregarAlCarrito?.Invoke(this, EventArgs.Empty);
        }
        private void TarjetaProducto_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radio = 20; // Ajusta el número para más o menos redondeo

            // Crear el recorte
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(this.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(this.Width - radio, this.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, this.Height - radio, radio, radio, 90, 90);

            // Aplicar el recorte al control
            this.Region = new System.Drawing.Region(path);
        }

        private Image BytesToImagen(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }

        // Propiedades de acceso rápido para cuando se presione el botón en el Form principal
        public string NombreSeleccionado => lblNombre.Text;
        public string TamanoSeleccionado => cmbTamano.SelectedItem.ToString();
        public string PrecioFinal => lblPrecio.Text;

        public string NombreProducto => lblNombre.Text;
        public double PrecioChicoVal => PrecioChico; // Cambia el nombre si es necesario
        public double PrecioMedianoVal => PrecioMediano;
        public double PrecioGrandeVal => PrecioGrande;

    }
}
