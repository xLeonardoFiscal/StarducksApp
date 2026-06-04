namespace Starducks.Vista.CatalogoForms
{
    partial class FormPrincipal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelBusqueda = new Panel();
            btnReportesForm = new Button();
            pcbLogoCatalogo = new PictureBox();
            btnPostres = new Button();
            btnCafefrio = new Button();
            btnCafecaliente = new Button();
            btnTodos = new Button();
            txtBusqueda = new TextBox();
            lblTitulo = new Label();
            panelMenu = new Panel();
            flowLayoutPanelPanelProductos = new FlowLayoutPanel();
            dgvCarrito = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colTamano = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            lblTituloPedido = new Label();
            btnPagar = new Button();
            lblTotalCarrito = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnAgregarProducto = new Button();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogoCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.White;
            panelBusqueda.Controls.Add(btnAgregarProducto);
            panelBusqueda.Controls.Add(btnReportesForm);
            panelBusqueda.Controls.Add(pcbLogoCatalogo);
            panelBusqueda.Controls.Add(btnPostres);
            panelBusqueda.Controls.Add(btnCafefrio);
            panelBusqueda.Controls.Add(btnCafecaliente);
            panelBusqueda.Controls.Add(btnTodos);
            panelBusqueda.Controls.Add(txtBusqueda);
            panelBusqueda.Controls.Add(lblTitulo);
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.ForeColor = SystemColors.ControlText;
            panelBusqueda.Location = new Point(0, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(1924, 81);
            panelBusqueda.TabIndex = 0;
            // 
            // btnReportesForm
            // 
            btnReportesForm.BackColor = Color.Firebrick;
            btnReportesForm.FlatStyle = FlatStyle.Flat;
            btnReportesForm.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportesForm.ForeColor = Color.White;
            btnReportesForm.Location = new Point(1075, 26);
            btnReportesForm.Name = "btnReportesForm";
            btnReportesForm.Size = new Size(108, 29);
            btnReportesForm.TabIndex = 5;
            btnReportesForm.Text = "REPORTES";
            btnReportesForm.UseVisualStyleBackColor = false;
            btnReportesForm.Click += btnReportesForm_Click;
            // 
            // pcbLogoCatalogo
            // 
            pcbLogoCatalogo.Image = Properties.Resources.logopato2;
            pcbLogoCatalogo.Location = new Point(12, 6);
            pcbLogoCatalogo.Name = "pcbLogoCatalogo";
            pcbLogoCatalogo.Size = new Size(65, 69);
            pcbLogoCatalogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogoCatalogo.TabIndex = 4;
            pcbLogoCatalogo.TabStop = false;
            // 
            // btnPostres
            // 
            btnPostres.BackColor = Color.FromArgb(0, 98, 65);
            btnPostres.FlatStyle = FlatStyle.Flat;
            btnPostres.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostres.ForeColor = Color.White;
            btnPostres.Location = new Point(850, 29);
            btnPostres.Name = "btnPostres";
            btnPostres.Size = new Size(94, 29);
            btnPostres.TabIndex = 3;
            btnPostres.Text = "POSTRES";
            btnPostres.UseVisualStyleBackColor = false;
            // 
            // btnCafefrio
            // 
            btnCafefrio.BackColor = Color.FromArgb(0, 98, 65);
            btnCafefrio.FlatStyle = FlatStyle.Flat;
            btnCafefrio.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCafefrio.ForeColor = Color.White;
            btnCafefrio.Location = new Point(544, 29);
            btnCafefrio.Name = "btnCafefrio";
            btnCafefrio.Size = new Size(124, 29);
            btnCafefrio.TabIndex = 1;
            btnCafefrio.Text = "CAFES FRIOS";
            btnCafefrio.UseVisualStyleBackColor = false;
            // 
            // btnCafecaliente
            // 
            btnCafecaliente.BackColor = Color.FromArgb(0, 98, 65);
            btnCafecaliente.FlatStyle = FlatStyle.Flat;
            btnCafecaliente.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCafecaliente.ForeColor = Color.White;
            btnCafecaliente.Location = new Point(689, 29);
            btnCafecaliente.Name = "btnCafecaliente";
            btnCafecaliente.Size = new Size(155, 29);
            btnCafecaliente.TabIndex = 2;
            btnCafecaliente.Text = "CAFE CALIENTES";
            btnCafecaliente.UseVisualStyleBackColor = false;
            // 
            // btnTodos
            // 
            btnTodos.BackColor = Color.FromArgb(0, 98, 65);
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodos.ForeColor = Color.White;
            btnTodos.Location = new Point(432, 29);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(94, 30);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "TODOS";
            btnTodos.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(207, 31);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(203, 27);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(83, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(123, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Starducks";
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(225, 232, 228);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 81);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1924, 10);
            panelMenu.TabIndex = 1;
            // 
            // flowLayoutPanelPanelProductos
            // 
            flowLayoutPanelPanelProductos.AutoScroll = true;
            flowLayoutPanelPanelProductos.BackColor = Color.FromArgb(225, 232, 228);
            flowLayoutPanelPanelProductos.Dock = DockStyle.Left;
            flowLayoutPanelPanelProductos.ForeColor = Color.White;
            flowLayoutPanelPanelProductos.Location = new Point(0, 91);
            flowLayoutPanelPanelProductos.Name = "flowLayoutPanelPanelProductos";
            flowLayoutPanelPanelProductos.Size = new Size(1463, 949);
            flowLayoutPanelPanelProductos.TabIndex = 2;
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = Color.FromArgb(242, 242, 242);
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { colNombre, colTamano, colPrecio });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 98, 65);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCarrito.Location = new Point(1482, 117);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(430, 405);
            dgvCarrito.TabIndex = 1;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Producto";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colTamano
            // 
            colTamano.HeaderText = "Tamaño";
            colTamano.MinimumWidth = 6;
            colTamano.Name = "colTamano";
            colTamano.Width = 125;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.Width = 125;
            // 
            // lblTituloPedido
            // 
            lblTituloPedido.AutoSize = true;
            lblTituloPedido.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPedido.Location = new Point(1653, 94);
            lblTituloPedido.Name = "lblTituloPedido";
            lblTituloPedido.Size = new Size(126, 24);
            lblTituloPedido.TabIndex = 0;
            lblTituloPedido.Text = "TU PEDIDO";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(0, 98, 65);
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.Gold;
            btnPagar.Location = new Point(1653, 597);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(94, 38);
            btnPagar.TabIndex = 0;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblTotalCarrito
            // 
            lblTotalCarrito.AutoSize = true;
            lblTotalCarrito.Location = new Point(1663, 561);
            lblTotalCarrito.Name = "lblTotalCarrito";
            lblTotalCarrito.Size = new Size(84, 20);
            lblTotalCarrito.TabIndex = 4;
            lblTotalCarrito.Text = "Total: $0.00";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage_1;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.FromArgb(0, 98, 65);
            btnAgregarProducto.FlatStyle = FlatStyle.Flat;
            btnAgregarProducto.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.ForeColor = Color.Gold;
            btnAgregarProducto.Location = new Point(1214, 26);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(188, 29);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(117, 159, 137);
            ClientSize = new Size(1924, 1040);
            Controls.Add(lblTotalCarrito);
            Controls.Add(dgvCarrito);
            Controls.Add(btnPagar);
            Controls.Add(flowLayoutPanelPanelProductos);
            Controls.Add(lblTituloPedido);
            Controls.Add(panelMenu);
            Controls.Add(panelBusqueda);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogoCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBusqueda;
        private Label lblTitulo;
        private TextBox txtBusqueda;
        private Panel panelMenu;
        private Button btnTodos;
        private Button btnCafefrio;
        private Button btnPostres;
        private Button btnCafecaliente;
        private FlowLayoutPanel flowLayoutPanelPanelProductos;
        private DataGridView dgvCarrito;
        private Label lblTituloPedido;
        private Button btnPagar;
        private Label lblTotalCarrito;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTamano;
        private DataGridViewTextBoxColumn colPrecio;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pcbLogoCatalogo;
        private Button btnReportesForm;
        private Button btnAgregarProducto;
    }
}