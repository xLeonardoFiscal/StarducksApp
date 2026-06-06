namespace Starducks.Vista
{
    partial class ConsultasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasForm));
            lbltxt = new Label();
            txtFiltro = new TextBox();
            cmbFiltro = new ComboBox();
            dtInicio = new DateTimePicker();
            dtFin = new DateTimePicker();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            dgvConsulta = new DataGridView();
            lblTotal = new Label();
            treeConsultas = new TreeView();
            panel1 = new Panel();
            label1 = new Label();
            pbLogo = new PictureBox();
            panel2 = new Panel();
            btnSalir = new Button();
            btnRegresar = new Button();
            lblcmb = new Label();
            lblInicio = new Label();
            lblFin = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lbltxt
            // 
            lbltxt.AutoSize = true;
            lbltxt.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltxt.ForeColor = Color.DarkGreen;
            lbltxt.Location = new Point(231, 140);
            lbltxt.Name = "lbltxt";
            lbltxt.Size = new Size(71, 28);
            lbltxt.TabIndex = 0;
            lbltxt.Text = "Filtro:";
            lbltxt.Visible = false;
            // 
            // txtFiltro
            // 
            txtFiltro.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = Color.DarkGreen;
            txtFiltro.Location = new Point(231, 183);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(432, 35);
            txtFiltro.TabIndex = 1;
            txtFiltro.Visible = false;
            // 
            // cmbFiltro
            // 
            cmbFiltro.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFiltro.ForeColor = Color.DarkGreen;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Location = new Point(231, 269);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(352, 36);
            cmbFiltro.TabIndex = 2;
            cmbFiltro.Visible = false;
            // 
            // dtInicio
            // 
            dtInicio.CalendarFont = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInicio.CalendarForeColor = Color.DarkGreen;
            dtInicio.Location = new Point(758, 187);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(250, 27);
            dtInicio.TabIndex = 3;
            dtInicio.Visible = false;
            // 
            // dtFin
            // 
            dtFin.CalendarFont = new Font("Rockwell", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFin.CalendarForeColor = Color.DarkGreen;
            dtFin.Location = new Point(758, 273);
            dtFin.Name = "dtFin";
            dtFin.Size = new Size(250, 27);
            dtFin.TabIndex = 4;
            dtFin.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.DarkGreen;
            btnBuscar.Location = new Point(1101, 177);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 48);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Visible = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.DarkGreen;
            btnLimpiar.Location = new Point(1101, 262);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 51);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Visible = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvConsulta
            // 
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(231, 353);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.RowHeadersWidth = 51;
            dgvConsulta.Size = new Size(1056, 275);
            dgvConsulta.TabIndex = 7;
            dgvConsulta.CellContentClick += dgvConsulta_CellContentClick;
            dgvConsulta.CellDoubleClick += dgvConsulta_CellDoubleClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(673, 631);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(184, 28);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total registros: 0 ";
            // 
            // treeConsultas
            // 
            treeConsultas.Dock = DockStyle.Left;
            treeConsultas.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            treeConsultas.ForeColor = Color.DarkGreen;
            treeConsultas.Location = new Point(0, 0);
            treeConsultas.Name = "treeConsultas";
            treeConsultas.Size = new Size(196, 841);
            treeConsultas.TabIndex = 9;
            treeConsultas.AfterSelect += treeConsultas_AfterSelect;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbLogo);
            panel1.Location = new Point(195, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1252, 123);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(242, 22);
            label1.Name = "label1";
            label1.Size = new Size(724, 73);
            label1.TabIndex = 12;
            label1.Text = "STARDUCKS  -  CONSULTAS";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logopato2;
            pbLogo.Location = new Point(1166, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(70, 70);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Location = new Point(1317, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 727);
            panel2.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Snow;
            btnSalir.Location = new Point(1158, 778);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 51);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.DarkGreen;
            btnRegresar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = Color.Snow;
            btnRegresar.Location = new Point(231, 778);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(146, 51);
            btnRegresar.TabIndex = 13;
            btnRegresar.Text = "REGRESAR";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblcmb
            // 
            lblcmb.AutoSize = true;
            lblcmb.Font = new Font("Candara", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcmb.ForeColor = Color.DarkGreen;
            lblcmb.Location = new Point(231, 228);
            lblcmb.Name = "lblcmb";
            lblcmb.Size = new Size(71, 28);
            lblcmb.TabIndex = 14;
            lblcmb.Text = "Filtro:";
            lblcmb.Visible = false;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicio.ForeColor = Color.DarkGreen;
            lblInicio.Location = new Point(826, 160);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(110, 24);
            lblInicio.TabIndex = 15;
            lblInicio.Text = "Fecha inicio";
            lblInicio.Visible = false;
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFin.ForeColor = Color.DarkGreen;
            lblFin.Location = new Point(826, 246);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(102, 24);
            lblFin.TabIndex = 16;
            lblFin.Text = "Fecha final";
            lblFin.Visible = false;
            // 
            // ConsultasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1445, 841);
            Controls.Add(lblFin);
            Controls.Add(lblInicio);
            Controls.Add(lblcmb);
            Controls.Add(btnRegresar);
            Controls.Add(btnSalir);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(treeConsultas);
            Controls.Add(lblTotal);
            Controls.Add(dgvConsulta);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(dtFin);
            Controls.Add(dtInicio);
            Controls.Add(cmbFiltro);
            Controls.Add(txtFiltro);
            Controls.Add(lbltxt);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsultasForm";
            Text = "ConsultasForm";
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltxt;
        private TextBox txtFiltro;
        private ComboBox cmbFiltro;
        private DateTimePicker dtInicio;
        private DateTimePicker dtFin;
        private Button btnBuscar;
        private Button btnLimpiar;
        private DataGridView dgvConsulta;
        private Label lblTotal;
        private TreeView treeConsultas;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pbLogo;
        private Button btnSalir;
        private Button btnRegresar;
        private Label lblcmb;
        private Label lblInicio;
        private Label lblFin;
    }
}