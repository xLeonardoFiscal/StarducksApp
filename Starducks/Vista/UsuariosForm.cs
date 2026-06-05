using MySql.Data.MySqlClient;
using Starducks.Controlador;
using Starducks.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using static Starducks.Vista.UsuariosForm;

namespace Starducks.Vista
{
    public partial class UsuariosForm : Form
    {
        // Variable para guardar el ID seleccionado
        private int idUsuarioSeleccionado = 0;

        public UsuariosForm()
        {
            InitializeComponent();
        }


        private void CargarUsuarios()
        {
            UsuarioController controller = new UsuarioController();

            dgvUsuarios.DataSource = controller.ObtenerUsuarios();
            // Ocultar columnas innecesarias
            dgvUsuarios.Columns["Password"].Visible = false;
            dgvUsuarios.Columns["Telefono"].Visible = false;
            dgvUsuarios.Columns["Direccion"].Visible = false;
            dgvUsuarios.Columns["Foto"].Visible = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public class Usuario
        {
            public string Nombre { get; set; }
            public string Rol { get; set; }
            public string Foto { get; set; }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

            // Configurar ComboBox
            cmbRol.Items.Clear();

            cmbRol.Items.Add("administrador");
            cmbRol.Items.Add("usuario operador");
            cmbRol.Items.Add("consultor");

            //Bloquear edicion de Nombre y Usuario
            txtNombre.ReadOnly = true;
            txtUsuario.ReadOnly = true;

            //No mostrar botones 
            btnDesactivarUsuario.Visible = false;
            btnReactivar.Visible = false;

            MakePictureBoxCircular(pbLogo);
        }

        //METODO PARA REDONDEAR LAS PICTUREBOX
        private void MakePictureBoxCircular(PictureBox pb)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(gp);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Llenar controles dentro del evento CellClick
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["IdUsuario"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();

                txtUsuario.Text = fila.Cells["User"].Value.ToString();

                cmbRol.Text = fila.Cells["Rol"].Value.ToString();

                // Mostrar el boton necesario segun el contexto en la operacion
                int activo = Convert.ToInt32(fila.Cells["Activo"].Value);

                if (activo == 1)
                {
                    btnDesactivarUsuario.Visible = true;
                    btnReactivar.Visible = false;
                }
                else
                {
                    btnDesactivarUsuario.Visible = false;
                    btnReactivar.Visible = true;
                }
            }
        }


        private void btnActualizarRol_Click(object sender, EventArgs e)
        {
            // Validaciones

            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un rol.");
                return;
            }

            UsuarioController controller = new UsuarioController();

            bool actualizado = controller.ActualizarRol(idUsuarioSeleccionado, cmbRol.Text);

            if (actualizado)
            {
                MessageBox.Show("Rol actualizado correctamente.");

                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idUsuarioSeleccionado = 0;

            txtNombre.Clear();

            txtUsuario.Clear();

            cmbRol.SelectedIndex = -1;
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario.");

                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea desactivar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                UsuarioController controller = new UsuarioController();

                bool resultado = controller.DesactivarUsuario(idUsuarioSeleccionado);

                if (resultado)
                {
                    MessageBox.Show("Usuario desactivado.");

                    CargarUsuarios();

                    btnLimpiar.PerformClick();
                }
            }
        }

        private void btnReactivar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario.");

                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea Reactivar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                UsuarioController controller = new UsuarioController();

                bool resultado = controller.ReactivarUsuario(idUsuarioSeleccionado);

                if (resultado)
                {
                    MessageBox.Show("Usuario reactivado.");

                    CargarUsuarios();

                    btnLimpiar.PerformClick();
                }
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }
    }
}
