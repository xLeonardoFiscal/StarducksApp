using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Starducks.Vista
{public partial class BienvenidaForm : Form
    {
        // Variable para controlar el avance del 0 al 100%
        private int progresoActual = 0;

        // API nativa para crear bordes suavemente redondeados en la ventana (Estilo Card)
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, 
            int nRightRect, int nBottomRect, 
            int nWidthEllipse, int nHeightEllipse
        );

        public BienvenidaForm()
        {
            InitializeComponent();
            
            // Aplicamos un radio de redondeo de 25 píxeles a las esquinas del formulario
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void BienvenidaForm_Load(object sender, EventArgs e)
        {
            // Nos aseguramos de que el panel de progreso comience vacío
            panelProgreso.Width = 0;
            timerCarg.Start();
        }

        private void timerCarga_Tick(object sender, EventArgs e)
        {
            progresoActual += 2; // Incremento progresivo

            // Cálculo matemático para estirar el panel activo de acuerdo al porcentaje
            int anchoMaximo = panelBarraBg.Width;
            panelProgreso.Width = (anchoMaximo * progresoActual) / 100;

            // Simulación dinámica de la carga de base de datos e interfaz
            if (progresoActual == 14) lblMensaje.Text = "Conectando con el servidor MySQL...";
            if (progresoActual == 42) lblMensaje.Text = "Verificando integridad de tablas...";
            if (progresoActual == 70) lblMensaje.Text = "Cargando catálogo de productos e imágenes...";
            if (progresoActual == 90) lblMensaje.Text = "Renderizando entorno gráfico...";

            // Fin del ciclo de carga
            if (progresoActual >= 100)
            {
                timerCarg.Stop();

                // Instancia y despliega tu siguiente Formulario (Ej: Menú Principal o Login)
                // MainForm menu = new MainForm();
                // menu.Show();

                this.Hide(); // Oculta el Splash Screen de forma limpia
            }
        }
    }
}
