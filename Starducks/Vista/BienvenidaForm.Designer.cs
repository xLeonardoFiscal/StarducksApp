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
            lblMensaje = new Label();
            panelProgreso = new Panel();
            panelBarraBg = new ProgressBar();
            timerCarg = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelProgreso.SuspendLayout();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Location = new Point(52, 109);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(125, 62);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(266, 93);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(215, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "STARDUCKS";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(192, 321);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(180, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "Iniciando subsistemas...";
           
            // 
            // panelProgreso
            // 
            panelProgreso.Controls.Add(panelBarraBg);
            panelProgreso.Location = new Point(104, 239);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.Size = new Size(377, 63);
            panelProgreso.TabIndex = 3;
        
            // 
            // panelBarraBg
            // 
            panelBarraBg.BackColor = SystemColors.ActiveCaption;
            panelBarraBg.Location = new Point(3, 15);
            panelBarraBg.Name = "panelBarraBg";
            panelBarraBg.Size = new Size(374, 29);
            panelBarraBg.TabIndex = 0;
          
            // 
            // timerCarg
            // 
            timerCarg.Interval = 30;
            // 
            // BienvenidaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
            Controls.Add(panelProgreso);
            Controls.Add(lblMensaje);
            Controls.Add(lblTitulo);
            Controls.Add(picLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BienvenidaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BienvenidaForm";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelProgreso.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblMensaje;
        private Panel panelProgreso;
        private ProgressBar panelBarraBg;
        private System.Windows.Forms.Timer timerCarg;
    }
}