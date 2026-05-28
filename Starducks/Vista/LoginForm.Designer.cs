namespace Starducks.Vista
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            label2 = new Label();
            lblConteo2 = new Label();
            lblInhabilitado2 = new Label();
            lblPorcentaje = new Label();
            lblInhabilitado = new Label();
            lblConteo = new Label();
            progressBar1 = new ProgressBar();
            btnSalir = new Button();
            label1 = new Label();
            btnRegistrarse = new Button();
            btnSesion = new Button();
            pContra = new Panel();
            txtContra = new TextBox();
            pbContra = new PictureBox();
            CBmostrarContra = new CheckBox();
            pUsuario = new Panel();
            txtUsuario = new TextBox();
            pbUsuario = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerBloqueo = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            pContra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbContra).BeginInit();
            pUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblConteo2);
            panel1.Controls.Add(lblInhabilitado2);
            panel1.Controls.Add(lblPorcentaje);
            panel1.Controls.Add(lblInhabilitado);
            panel1.Controls.Add(lblConteo);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegistrarse);
            panel1.Controls.Add(btnSesion);
            panel1.Controls.Add(pContra);
            panel1.Controls.Add(pUsuario);
            panel1.Location = new Point(520, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 680);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 479);
            label2.Name = "label2";
            label2.Size = new Size(0, 41);
            label2.TabIndex = 15;
            // 
            // lblConteo2
            // 
            lblConteo2.AutoSize = true;
            lblConteo2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConteo2.Location = new Point(605, 603);
            lblConteo2.Name = "lblConteo2";
            lblConteo2.Size = new Size(0, 24);
            lblConteo2.TabIndex = 14;
            lblConteo2.Click += label6_Click;
            // 
            // lblInhabilitado2
            // 
            lblInhabilitado2.AutoSize = true;
            lblInhabilitado2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInhabilitado2.ForeColor = Color.Red;
            lblInhabilitado2.Location = new Point(548, 508);
            lblInhabilitado2.Name = "lblInhabilitado2";
            lblInhabilitado2.Size = new Size(0, 24);
            lblInhabilitado2.TabIndex = 13;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.BackColor = Color.Snow;
            lblPorcentaje.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPorcentaje.ForeColor = Color.ForestGreen;
            lblPorcentaje.Location = new Point(366, 591);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(31, 24);
            lblPorcentaje.TabIndex = 12;
            lblPorcentaje.Text = "0%";
            // 
            // lblInhabilitado
            // 
            lblInhabilitado.AutoSize = true;
            lblInhabilitado.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInhabilitado.ForeColor = Color.Red;
            lblInhabilitado.Location = new Point(70, 508);
            lblInhabilitado.Name = "lblInhabilitado";
            lblInhabilitado.Size = new Size(0, 24);
            lblInhabilitado.TabIndex = 11;
            // 
            // lblConteo
            // 
            lblConteo.AutoSize = true;
            lblConteo.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConteo.Location = new Point(122, 603);
            lblConteo.Name = "lblConteo";
            lblConteo.Size = new Size(0, 24);
            lblConteo.TabIndex = 10;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(245, 549);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(265, 39);
            progressBar1.TabIndex = 9;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkGreen;
            btnSalir.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(650, 635);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(76, 32);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(180, 111);
            label1.Name = "label1";
            label1.Size = new Size(413, 49);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO AL LOGIN";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.White;
            btnRegistrarse.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.DarkGreen;
            btnRegistrarse.Location = new Point(534, 535);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(164, 65);
            btnRegistrarse.TabIndex = 3;
            btnRegistrarse.Text = "REGISTRARSE";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.White;
            btnSesion.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSesion.ForeColor = Color.DarkGreen;
            btnSesion.Location = new Point(58, 535);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(164, 65);
            btnSesion.TabIndex = 2;
            btnSesion.Text = "INICIAR SESION";
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += btnSesion_Click;
            // 
            // pContra
            // 
            pContra.BackColor = Color.White;
            pContra.Controls.Add(txtContra);
            pContra.Controls.Add(pbContra);
            pContra.Controls.Add(CBmostrarContra);
            pContra.Location = new Point(58, 353);
            pContra.Name = "pContra";
            pContra.Size = new Size(640, 102);
            pContra.TabIndex = 1;
            // 
            // txtContra
            // 
            txtContra.Cursor = Cursors.IBeam;
            txtContra.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.ForeColor = Color.DarkGreen;
            txtContra.Location = new Point(89, 30);
            txtContra.Multiline = true;
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(518, 47);
            txtContra.TabIndex = 4;
            txtContra.TextChanged += txtContra_TextChanged;
            // 
            // pbContra
            // 
            pbContra.Image = (Image)resources.GetObject("pbContra.Image");
            pbContra.Location = new Point(17, 21);
            pbContra.Name = "pbContra";
            pbContra.Size = new Size(66, 66);
            pbContra.SizeMode = PictureBoxSizeMode.CenterImage;
            pbContra.TabIndex = 1;
            pbContra.TabStop = false;
            // 
            // CBmostrarContra
            // 
            CBmostrarContra.AutoSize = true;
            CBmostrarContra.BackColor = Color.Transparent;
            CBmostrarContra.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBmostrarContra.Location = new Point(89, 83);
            CBmostrarContra.Name = "CBmostrarContra";
            CBmostrarContra.Size = new Size(148, 22);
            CBmostrarContra.TabIndex = 4;
            CBmostrarContra.Text = "Mostrar contraseña";
            CBmostrarContra.UseVisualStyleBackColor = true;
            CBmostrarContra.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pUsuario
            // 
            pUsuario.BackColor = Color.White;
            pUsuario.Controls.Add(txtUsuario);
            pUsuario.Controls.Add(pbUsuario);
            pUsuario.Location = new Point(58, 205);
            pUsuario.Name = "pUsuario";
            pUsuario.Size = new Size(640, 102);
            pUsuario.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.DarkGreen;
            txtUsuario.Location = new Point(89, 31);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(518, 47);
            txtUsuario.TabIndex = 3;
            // 
            // pbUsuario
            // 
            pbUsuario.BackColor = Color.Transparent;
            pbUsuario.Image = Properties.Resources.user;
            pbUsuario.Location = new Point(17, 21);
            pbUsuario.Name = "pbUsuario";
            pbUsuario.Size = new Size(66, 66);
            pbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuario.TabIndex = 0;
            pbUsuario.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1273, 99);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(578, 13);
            label3.Name = "label3";
            label3.Size = new Size(200, 69);
            label3.TabIndex = 6;
            label3.Text = "DUCKS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Forte", 40F);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(409, 9);
            label5.Name = "label5";
            label5.Size = new Size(188, 73);
            label5.TabIndex = 8;
            label5.Text = "STAR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(1136, 80);
            label4.Name = "label4";
            label4.Size = new Size(125, 19);
            label4.TabIndex = 7;
            label4.Text = "REYNOSA TAMPS";
            // 
            // timer1
            // 
            timer1.Interval = 80;
            timer1.Tick += timer1_Tick;
            // 
            // timerBloqueo
            // 
            timerBloqueo.Interval = 1000;
            timerBloqueo.Tick += timerBloqueo_Tick;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1258, 679);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pContra.ResumeLayout(false);
            pContra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbContra).EndInit();
            pUsuario.ResumeLayout(false);
            pUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsuario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CheckBox CBmostrarContra;
        private Button btnRegistrarse;
        private Button btnSesion;
        private Panel pContra;
        private PictureBox pbContra;
        private Panel pUsuario;
        private PictureBox pbUsuario;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Button btnSalir;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerBloqueo;
        private Label lblConteo;
        private Label lblInhabilitado;
        private Label lblConteo2;
        private Label lblInhabilitado2;
        private Label lblPorcentaje;
        private Label label2;
    }
}