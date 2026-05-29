namespace Starducks.Vista
{
    partial class BienvenidaForm
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
            picLogo = new PictureBox();
            lblTitulo = new Label();
            timerCarg = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            lblPorcentaje = new Label();
            panelProgreso = new Panel();
            panelBarraBg = new Panel();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelBarraBg.SuspendLayout();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.LogoPato;
            picLogo.Location = new Point(41, 94);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(229, 224);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(244, 241, 231);
            lblTitulo.Location = new Point(315, 144);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(349, 47);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "¡BIENVENIDOS A ";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // timerCarg
            // 
            timerCarg.Interval = 30;
            timerCarg.Tick += timerCarg_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 241, 231);
            label1.Location = new Point(339, 191);
            label1.Name = "label1";
            label1.Size = new Size(499, 47);
            label1.TabIndex = 4;
            label1.Text = "CAFETERIA STARDUCKS!";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.ForeColor = Color.FromArgb(244, 241, 234);
            lblPorcentaje.Location = new Point(352, 393);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(161, 20);
            lblPorcentaje.TabIndex = 5;
            lblPorcentaje.Text = "Cargando sistema... 0%";
            // 
            // panelProgreso
            // 
            panelProgreso.BackColor = Color.FromArgb(216, 169, 74);
            panelProgreso.Location = new Point(0, 0);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.Size = new Size(10, 15);
            panelProgreso.TabIndex = 0;
            // 
            // panelBarraBg
            // 
            panelBarraBg.BackColor = Color.FromArgb(244, 241, 234);
            panelBarraBg.Controls.Add(panelProgreso);
            panelBarraBg.Location = new Point(137, 416);
            panelBarraBg.Name = "panelBarraBg";
            panelBarraBg.Size = new Size(600, 15);
            panelBarraBg.TabIndex = 6;
            panelBarraBg.Paint += panelBarraBg_Paint;
            // 
            // BienvenidaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 59, 46);
            ClientSize = new Size(850, 500);
            Controls.Add(panelBarraBg);
            Controls.Add(lblPorcentaje);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BienvenidaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BienvenidaForm";
            Load += BienvenidaForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelBarraBg.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitulo;
        private System.Windows.Forms.Timer timerCarg;
        private Label label1;
        private Label lblPorcentaje;
        private Panel panelProgreso;
        private Panel panelBarraBg;
    }
}