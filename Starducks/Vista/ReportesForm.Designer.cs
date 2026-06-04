namespace Starducks.Vista
{
    partial class ReportesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesForm));
            dgvReporte = new DataGridView();
            btnPDF = new Button();
            treeReportes = new TreeView();
            lblFiltro = new Label();
            cmbFiltro = new ComboBox();
            txtFiltro = new TextBox();
            btnGenerar = new Button();
            panel1 = new Panel();
            lblBienvenida = new Label();
            label1 = new Label();
            pbLogo = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            btnSalir = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(283, 298);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(1514, 576);
            dgvReporte.TabIndex = 1;
            dgvReporte.CellContentClick += dgvReporte_CellContentClick;
            // 
            // btnPDF
            // 
            btnPDF.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDF.ForeColor = Color.DarkGreen;
            btnPDF.Location = new Point(1534, 168);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(171, 73);
            btnPDF.TabIndex = 3;
            btnPDF.Text = "EXPORTAR PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // treeReportes
            // 
            treeReportes.Dock = DockStyle.Left;
            treeReportes.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            treeReportes.ForeColor = Color.DarkGreen;
            treeReportes.Location = new Point(0, 0);
            treeReportes.Name = "treeReportes";
            treeReportes.Size = new Size(284, 1055);
            treeReportes.TabIndex = 4;
            treeReportes.AfterSelect += treeReportes_AfterSelect;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltro.ForeColor = Color.DarkGreen;
            lblFiltro.Location = new Point(303, 117);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(95, 37);
            lblFiltro.TabIndex = 5;
            lblFiltro.Text = "Filtro:";
            // 
            // cmbFiltro
            // 
            cmbFiltro.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFiltro.ForeColor = Color.DarkGreen;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(303, 186);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(354, 39);
            cmbFiltro.TabIndex = 6;
            // 
            // txtFiltro
            // 
            txtFiltro.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = Color.DarkGreen;
            txtFiltro.Location = new Point(303, 186);
            txtFiltro.Multiline = true;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(354, 41);
            txtFiltro.TabIndex = 7;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.ForeColor = Color.DarkGreen;
            btnGenerar.Location = new Point(1001, 171);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(171, 67);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "GENERAR";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(lblBienvenida);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbLogo);
            panel1.Location = new Point(283, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1639, 98);
            panel1.TabIndex = 9;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.Snow;
            lblBienvenida.Location = new Point(1288, 74);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(0, 24);
            lblBienvenida.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(432, 9);
            label1.Name = "label1";
            label1.Size = new Size(686, 73);
            label1.TabIndex = 10;
            label1.Text = "STARDUCKS  -  REPORTES";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logopato2;
            pbLogo.Location = new Point(1533, 5);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(90, 90);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1797, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 982);
            panel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(70, 613);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Snow;
            btnSalir.Location = new Point(1611, 899);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(171, 67);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.DarkGreen;
            btnRegresar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Snow;
            btnRegresar.Location = new Point(303, 899);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(171, 67);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1918, 1055);
            Controls.Add(panel1);
            Controls.Add(btnGenerar);
            Controls.Add(btnSalir);
            Controls.Add(txtFiltro);
            Controls.Add(btnRegresar);
            Controls.Add(cmbFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(treeReportes);
            Controls.Add(btnPDF);
            Controls.Add(dgvReporte);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReportesForm";
            Text = "ReportesForm";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvReporte;
        private Button btnPDF;
        private TreeView treeReportes;
        private Label lblFiltro;
        private ComboBox cmbFiltro;
        private TextBox txtFiltro;
        private Button btnGenerar;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label lblBienvenida;
        private Label label2;
        private Button btnSalir;
        private Button btnRegresar;
        private PictureBox pbLogo;
    }
}