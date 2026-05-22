using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Starducks.Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CBmostrarContra.Checked = true; //Ocultar contraseña

            //Hacer los paneles redondos
            MakePanelRounded(pUsuario, txtUsuario);
            MakePanelRounded(pContra, txtContra);

            //Hacer los picture box redondos
            MakePictureBoxCircular(pbUsuario);
            MakePictureBoxCircular(pbContra);

        }


        //METODO PARA REDONDEAR LAS PICTUREBOX
        private void MakePictureBoxCircular(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(gp);
        }



        //METODO PARA REDONDEAR LOS PANEL Y LOS TEXTUREBOX DENTRO
        private void MakePanelRounded(Panel panel, TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.White;

            GraphicsPath gpPanel = new GraphicsPath();
            int radius = 60;

            gpPanel.StartFigure();
            //AddArc tiene 4 o 5 argumentos dependiendo la sobrecarga
            //AddArc(int x, int y, int width, int height, float startAngle, float sweepAngle)

            gpPanel.AddArc(0f, 0f, radius, radius, 180f, 90f);
            gpPanel.AddArc(panel.Width - radius, 0f, radius, radius, 270f, 90f);
            gpPanel.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0f, 90f);
            gpPanel.AddArc(0f, panel.Height - radius, radius, radius, 90f, 90f);
            gpPanel.CloseAllFigures();

            panel.Region = new Region(gpPanel);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = !CBmostrarContra.Checked; //Tapa la contraseña si el check esta activado

            if (CBmostrarContra.Checked)
            {
                CBmostrarContra.Text = "Mostrar contraseña";
            }
            else
            {
                CBmostrarContra.Text = "Ocultar contraseña";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
