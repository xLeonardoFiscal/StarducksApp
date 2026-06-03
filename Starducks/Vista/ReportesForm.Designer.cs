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
            dgvReporte = new DataGridView();
            btnPDF = new Button();
            treeReportes = new TreeView();
            lblFiltro = new Label();
            cmbFiltro = new ComboBox();
            txtFiltro = new TextBox();
            btnGenerar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(248, 314);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(1174, 327);
            dgvReporte.TabIndex = 1;
            dgvReporte.CellContentClick += dgvReporte_CellContentClick;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(519, 112);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(120, 56);
            btnPDF.TabIndex = 3;
            btnPDF.Text = "EXPORTAR PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // treeReportes
            // 
            treeReportes.Dock = DockStyle.Left;
            treeReportes.Location = new Point(0, 0);
            treeReportes.Name = "treeReportes";
            treeReportes.Size = new Size(250, 641);
            treeReportes.TabIndex = 4;
            treeReportes.AfterSelect += treeReportes_AfterSelect;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(305, 29);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(46, 20);
            lblFiltro.TabIndex = 5;
            lblFiltro.Text = "Filtro:";
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(305, 73);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(151, 28);
            cmbFiltro.TabIndex = 6;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(305, 127);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(125, 27);
            txtFiltro.TabIndex = 7;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(305, 204);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(94, 29);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "GENERAR";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 641);
            Controls.Add(btnGenerar);
            Controls.Add(txtFiltro);
            Controls.Add(cmbFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(treeReportes);
            Controls.Add(btnPDF);
            Controls.Add(dgvReporte);
            Name = "ReportesForm";
            Text = "ReportesForm";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
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
    }
}