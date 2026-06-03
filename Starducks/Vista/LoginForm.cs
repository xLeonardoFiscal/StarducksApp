using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Starducks.Modelo;
using Starducks.Controlador;

namespace Starducks.Vista
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        int tiempoBloqueo = 10;
        int intentos = 0;

        public void reiniciarLogin()
        {
            txtUsuario.Text = ""; //Limpia label
            txtContra.Text = "";

            progressBar1.Value = 0;
            lblPorcentaje.Text = "0"; //muestra % del progressbar

            btnRegistrarse.Enabled = true;
            btnSesion.Enabled = true;
            btnSalir.Enabled = true; // habilita los botones

            intentos = 0;
            tiempoBloqueo = 10;         //establece intenos, tiempo del bloqueo
            lblInhabilitado.Text = "";
            lblInhabilitado2.Text = "";
            lblConteo.Text = "";
            lblConteo2.Text = "";

            timer1.Stop();
            timerBloqueo.Stop();  // para ambos timer
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
            MakePictureBoxCircular(pbStarducks);

            lblInhabilitado.Text = "";
            lblInhabilitado2.Text = "";
            lblConteo.Text = "";
            lblConteo2.Text = "";
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



        private void btnSesion_Click(object sender, EventArgs e)
        {
            LoginController login = new LoginController();

            Usuario usuario =
                login.IniciarSesion(
                txtUsuario.Text,
                txtContra.Text);
            string contra = txtContra.Text;

            if (contra == "")
            {
                MessageBox.Show("No se permiten campos vacios"); //Evito campos vacios
                return;
            }

            if (usuario != null)
            {
                Sesion.UsuarioActual = usuario.Nombre;

                intentos = 0;

                btnRegistrarse.Enabled = false; //Deshabilitamos los botones
                btnSesion.Enabled = false;

                progressBar1.Value = 0;
                timer1.Start();
                lblPorcentaje.Text = "0%";


                MessageBox.Show(
                    "Bienvenido " + usuario.Nombre);


            }
            else
            {
                if (intentos < 3)
                {
                    intentos++;
                    MessageBox.Show(
                        "Usuario no encontrado.\n" +
                        "Si no tienes cuenta, " + "\nIntento num: " + intentos);
                    txtContra.Clear();  //Muestra intentos y limpia campos
                    txtUsuario.Clear();
                }
                else
                {
                    btnSesion.Enabled = false; //Deshabilita btnSesion
                    tiempoBloqueo = 10;
                    lblInhabilitado.Text = "INHABILITADO";
                    lblInhabilitado2.Text = "INHABILITADO";
                    lblConteo.Text = "(10s)";
                    lblConteo2.Text = "(10s)";
                    MessageBox.Show("Bloqueado por 10 segundos");
                    txtContra.Clear();
                    txtUsuario.Clear();

                    timerBloqueo.Start();
                }
            }
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





        private void timerBloqueo_Tick(object sender, EventArgs e)
        {
            tiempoBloqueo--; //Disminuye tiempo de bloqueo
            lblConteo.Text = "(" + tiempoBloqueo.ToString() + "s)"; //Muestra tiempo restante
            lblConteo2.Text = "(" + tiempoBloqueo.ToString() + "s)";

            if (tiempoBloqueo <= 0)  //detecta si ya termino el timer
            {
                timerBloqueo.Stop(); //detiene timer
                btnSesion.Enabled = true; //habilita el btn Ingresar
                intentos = 0; //restablece intentos
                tiempoBloqueo = 10;
                MessageBox.Show("Tiempo bloqueado terminado.");

                if (tiempoBloqueo > 0)
                {
                    lblConteo.Text = "";
                    lblConteo2.Text = "";
                    lblInhabilitado.Text = ""; //limpiando los lbl
                    lblInhabilitado2.Text = "";
                }
            }
        }





        private void label6_Click(object sender, EventArgs e)
        {

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5; //Valor del progressbar

            lblPorcentaje.Text = progressBar1.Value.ToString() + "%"; //Muestra mediante label el % del Progressbar

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                BienvenidaForm bienvenida = new BienvenidaForm();
                bienvenida.Show(); //Muestra la BienvenidaForm
                this.Hide();

            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm();
            registro.Show(); // Muestra el registro
            this.Hide();
        }
    }
}
