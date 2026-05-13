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
            panel1 = new Panel();
            btnSalir = new Button();
            label1 = new Label();
            btnRegistrarse = new Button();
            btnSesion = new Button();
            panel4 = new Panel();
            txtContra = new TextBox();
            pictureBox2 = new PictureBox();
            CBmostrarContra = new CheckBox();
            panel3 = new Panel();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnRegistrarse);
            panel1.Controls.Add(btnSesion);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(520, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 680);
            panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkGreen;
            btnSalir.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(656, 642);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(70, 25);
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
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtContra);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(CBmostrarContra);
            panel4.Location = new Point(58, 353);
            panel4.Name = "panel4";
            panel4.Size = new Size(640, 102);
            panel4.TabIndex = 1;
            // 
            // txtContra
            // 
            txtContra.Cursor = Cursors.IBeam;
            txtContra.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.ForeColor = Color.DarkGreen;
            txtContra.Location = new Point(89, 30);
            txtContra.Multiline = true;
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(518, 47);
            txtContra.TabIndex = 4;
            txtContra.TextChanged += txtContra_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.key;
            pictureBox2.Location = new Point(17, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
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
            CBmostrarContra.UseVisualStyleBackColor = false;
            CBmostrarContra.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(58, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(640, 102);
            panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Comic Sans MS", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkGreen;
            textBox1.Location = new Point(89, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(518, 47);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(17, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            label4.Location = new Point(1139, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 19);
            label4.TabIndex = 7;
            label4.Text = "REYNOSA TAMPS";
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
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtContra;
        private Button btnSalir;
    }
}