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
            txtContra.UseSystemPasswordChar = ! CBmostrarContra.Checked; //Tapa la contraseña si el check esta activado

            if (CBmostrarContra.Checked)
            {
                CBmostrarContra.Text = "Mostrar contraseña"; 
            }
            else
            {
                CBmostrarContra.Text = "Ocultar contraseña";
            }
        }
    }
}
