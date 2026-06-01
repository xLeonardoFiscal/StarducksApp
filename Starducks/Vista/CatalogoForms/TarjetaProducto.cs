using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
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

        public void AsignarDatos(string nombre, string desc, double pChico, double pMediano, double pGrande, byte[] imagenBytes)
        {
            lblNombre.Text = nombre;
            lblDescripcion.Text = desc;

            
            this.PrecioChico = pChico;
            this.PrecioMediano = pMediano;
            this.PrecioGrande = pGrande;

            /
            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        // Intentamos cargar la imagen
                        Image img = Image.FromStream(ms);
                        pbImagen.Image = img;
                        pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (ArgumentException)
                {
                    
                    pbImagen.Image = null;
                    
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
           
            OnAgregarAlCarrito?.Invoke(this, EventArgs.Empty);
        }
        private void TarjetaProducto_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radio = 20; 

           
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(this.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(this.Width - radio, this.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, this.Height - radio, radio, radio, 90, 90);

            
            this.Region = new System.Drawing.Region(path);
        }

        private Image BytesToImagen(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
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