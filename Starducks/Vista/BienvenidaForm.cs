using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Runtime.InteropServices;
using Starducks.Vista.CatalogoForms;

namespace Starducks.Vista
{
    public partial class BienvenidaForm : Form
    {
        public string nombreUsuario;
        public string FotoUsuarios;

        private int progresoActual = 0;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthBorder, int nHeightBorder);

        public BienvenidaForm()
        {
            InitializeComponent();

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


        }

        private void BienvenidaForm_Load(object sender, EventArgs e)
        {
            panelProgreso.Location = new Point(0, 0);
            panelProgreso.Width = 0;
            timerCarg.Start();
            

            lblTitulo.Text = "¡Bienvenido, " + nombreUsuario + "!";

            if (!string.IsNullOrEmpty(FotoUsuarios))
            {
                string startupPath = Application.StartupPath;
                string rutaBase = Path.Combine(startupPath, "FotosUsuarios");
                string rutaCompleta = Path.Combine(rutaBase, FotoUsuarios);

                if (File.Exists(rutaCompleta))
                {
                    pbFotoUsuario.Image = Image.FromFile(rutaCompleta);
                    pbFotoUsuario.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }



        }



        private void timerCarg_Tick(object sender, EventArgs e)
        {
            progresoActual += 2;

            panelProgreso.Location = new Point(0, 0);

            int anchoMaximo = panelBarraBg.Width;
            int anchoCalculado = (anchoMaximo * progresoActual) / 100;

            if (anchoCalculado > anchoMaximo)
            {
                anchoCalculado = anchoMaximo;
            }

            panelProgreso.Width = anchoCalculado;
            lblPorcentaje.Text = $"Iniciando sistema... {progresoActual}%";

            if (progresoActual >= 100)
            {
                timerCarg.Stop();
                this.Close();
            }
        }



        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panelBarraBg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
   