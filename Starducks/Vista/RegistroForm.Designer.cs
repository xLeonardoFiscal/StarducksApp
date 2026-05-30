namespace Starducks.Vista
{
    partial class RegistroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblUsuario = new Label();
            lblPassword = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            picFoto = new PictureBox();
            lblFoto = new Label();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            btnSeleccionarFoto = new Button();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(62, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(83, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += label1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(62, 89);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(84, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(62, 139);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(117, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(62, 187);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(94, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(62, 240);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(101, 20);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección:";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(199, 291);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(142, 125);
            picFoto.TabIndex = 5;
            picFoto.TabStop = false;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFoto.Location = new Point(62, 291);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(57, 20);
            lblFoto.TabIndex = 6;
            lblFoto.Text = "Foto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(199, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(368, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(199, 86);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(368, 23);
            txtUsuario.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(199, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(368, 23);
            txtPassword.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(199, 184);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(368, 23);
            txtTelefono.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(199, 237);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(368, 23);
            txtDireccion.TabIndex = 11;
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeleccionarFoto.Location = new Point(368, 340);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Size = new Size(169, 30);
            btnSeleccionarFoto.TabIndex = 12;
            btnSeleccionarFoto.Text = "Seleccionar Foto";
            btnSeleccionarFoto.UseVisualStyleBackColor = true;
            btnSeleccionarFoto.Click += btnSeleccionarFoto_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(612, 133);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(145, 30);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // RegistroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSeleccionarFoto);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(lblFoto);
            Controls.Add(picFoto);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblPassword);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombre);
            Name = "RegistroForm";
            Text = "FrmRegistro";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblUsuario;
        private Label lblPassword;
        private Label lblTelefono;
        private Label lblDireccion;
        private PictureBox picFoto;
        private Label lblFoto;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Button btnSeleccionarFoto;
        private Button btnRegistrar;
    }
}