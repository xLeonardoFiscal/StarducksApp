namespace Starducks.Vista
{
    partial class UsuariosForm
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
            dgvUsuarios = new DataGridView();
            txtNombre = new TextBox();
            txtUsuario = new TextBox();
            cmbRol = new ComboBox();
            btnActualizarRol = new Button();
            btnDesactivarUsuario = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            btnReactivar = new Button();
            panel2 = new Panel();
            pbLogo = new PictureBox();
            label1 = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(40, 332);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(892, 406);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.DarkGreen;
            txtNombre.Location = new Point(40, 140);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(439, 35);
            txtNombre.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DarkGreen;
            txtUsuario.Location = new Point(40, 212);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(439, 35);
            txtUsuario.TabIndex = 2;
            // 
            // cmbRol
            // 
            cmbRol.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.ForeColor = Color.DarkGreen;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(40, 278);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(326, 36);
            cmbRol.TabIndex = 3;
            // 
            // btnActualizarRol
            // 
            btnActualizarRol.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarRol.ForeColor = Color.DarkGreen;
            btnActualizarRol.Location = new Point(736, 260);
            btnActualizarRol.Name = "btnActualizarRol";
            btnActualizarRol.Size = new Size(196, 40);
            btnActualizarRol.TabIndex = 4;
            btnActualizarRol.Text = "ACTUALIZAR ROL";
            btnActualizarRol.UseVisualStyleBackColor = true;
            btnActualizarRol.Click += btnActualizarRol_Click;
            // 
            // btnDesactivarUsuario
            // 
            btnDesactivarUsuario.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDesactivarUsuario.ForeColor = Color.FromArgb(192, 0, 0);
            btnDesactivarUsuario.Location = new Point(780, 146);
            btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            btnDesactivarUsuario.Size = new Size(152, 58);
            btnDesactivarUsuario.TabIndex = 5;
            btnDesactivarUsuario.Text = "DESACTIVAR USUARIO";
            btnDesactivarUsuario.UseVisualStyleBackColor = true;
            btnDesactivarUsuario.Click += btnDesactivarUsuario_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.DarkGreen;
            btnLimpiar.Location = new Point(605, 260);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(106, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.DarkGreen;
            btnRegresar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Snow;
            btnRegresar.Location = new Point(12, 761);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(135, 44);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnReactivar
            // 
            btnReactivar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReactivar.ForeColor = Color.DarkGreen;
            btnReactivar.Location = new Point(605, 146);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(144, 58);
            btnReactivar.TabIndex = 8;
            btnReactivar.Text = "REACTIVAR USUARIO";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(pbLogo);
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.DarkGreen;
            panel2.Location = new Point(-5, -9);
            panel2.Name = "panel2";
            panel2.Size = new Size(1289, 105);
            panel2.TabIndex = 10;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logopato2;
            pbLogo.Location = new Point(913, 21);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(65, 65);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(93, 27);
            label1.Name = "label1";
            label1.Size = new Size(794, 58);
            label1.TabIndex = 0;
            label1.Text = "STARDUCKS  -  MANEJO DE USUARIOS";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Snow;
            btnSalir.Location = new Point(838, 761);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(135, 44);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // UsuariosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 817);
            Controls.Add(btnSalir);
            Controls.Add(panel2);
            Controls.Add(btnReactivar);
            Controls.Add(btnRegresar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDesactivarUsuario);
            Controls.Add(btnActualizarRol);
            Controls.Add(cmbRol);
            Controls.Add(txtUsuario);
            Controls.Add(txtNombre);
            Controls.Add(dgvUsuarios);
            Name = "UsuariosForm";
            Text = "UsuariosForm";
            Load += UsuariosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private TextBox txtNombre;
        private TextBox txtUsuario;
        private ComboBox cmbRol;
        private Button btnActualizarRol;
        private Button btnDesactivarUsuario;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Button btnReactivar;
        private Panel panel2;
        private Button btnSalir;
        private PictureBox pbLogo;
        private Label label1;
    }
}