using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Starducks.Vista
{
    public partial class BienvenidaForm : Form
    {
        private int progresoActual = 0;

        // Código nativo para redondear las esquinas de la ventana estilo Card
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthBorder, int nHeightBorder);

        public BienvenidaForm()
        {
            InitializeComponent();
            // Aplicamos un radio de redondeo de 25 píxeles al diseño plano
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void BienvenidaForm_Load(object sender, EventArgs e)
        {
            if (!panelBarraBg.Controls.Contains(panelProgreso))
            {
                panelBarraBg.Controls.Add(panelProgreso);
            }

            // 2. Clavamos la posición inicial exacta en la esquina superior izquierda
            panelProgreso.Location = new Point(0, 0);
            panelProgreso.Width = 0;
            panelProgreso.Height = panelBarraBg.Height;

            // 3. Imponemos los colores oficiales de Starducks sí o sí
            panelBarraBg.BackColor = Color.FromArgb(244, 241, 234); // Fondo Blanco Cremoso
            panelProgreso.BackColor = Color.FromArgb(216, 169, 74);  // Barra Dorada

            // 4. Encendemos el reloj
            timerCarg.Start();
        }
        

        private void timerCarg_Tick(object sender, EventArgs e)
        {
            progresoActual += 2; // Avanza el contador

            // Forzado de posición en cada Tick para evitar desborde por culpa de CoreCLR
            panelProgreso.Location = new Point(0, 0);

            // Calculamos el ancho de forma milimétrica basado en el fondo blanco
            int anchoMaximo = panelBarraBg.Width;
            int anchoCalculado = (anchoMaximo * progresoActual) / 100;

            // CONTROL DE LÍMITE RECTILÍNEO
            if (anchoCalculado > anchoMaximo)
            {
                anchoCalculado = anchoMaximo;
            }

            // Asignamos el tamaño final controlado
            panelProgreso.Width = anchoCalculado;

            // Actualizamos el contador de texto en pantalla
            lblPorcentaje.Text = $"Iniciando sistema... {progresoActual}%";

            // Si llega al final, detiene el reloj y avanza al Login
            if (progresoActual >= 100)
            {
                timerCarg.Stop(); //

                LoginForm login = new LoginForm(); //
                login.Show(); //

                this.Hide(); //
            }
        }
    
        

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
   