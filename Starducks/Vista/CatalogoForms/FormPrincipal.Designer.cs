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
            panelBusqueda = new Panel();
            btnPostres = new Button();
            btnCafefrio = new Button();
            btnCafecaliente = new Button();
            btnTodos = new Button();
            txtBusqueda = new TextBox();
            lblTitulo = new Label();
            panelMenu = new Panel();
            flowLayoutPanelPanelProductos = new FlowLayoutPanel();
            dgvCarrito = new DataGridView();
            lblTituloPedido = new Label();
            btnPagar = new Button();
            lblTotalCarrito = new Label();
            panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(btnPostres);
            panelBusqueda.Controls.Add(btnCafefrio);
            panelBusqueda.Controls.Add(btnCafecaliente);
            panelBusqueda.Controls.Add(btnTodos);
            panelBusqueda.Controls.Add(txtBusqueda);
            panelBusqueda.Controls.Add(lblTitulo);
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(0, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(988, 81);
            panelBusqueda.TabIndex = 0;
            panelBusqueda.Paint += panel1_Paint;
            // 
            // btnPostres
            // 
            btnPostres.FlatStyle = FlatStyle.Flat;
            btnPostres.Location = new Point(882, 34);
            btnPostres.Name = "btnPostres";
            btnPostres.Size = new Size(94, 29);
            btnPostres.TabIndex = 3;
            btnPostres.Text = "POSTRES";
            btnPostres.UseVisualStyleBackColor = true;
            btnPostres.Click += btnPostres_Click;
            // 
            // btnCafefrio
            // 
            btnCafefrio.FlatStyle = FlatStyle.Flat;
            btnCafefrio.Location = new Point(552, 31);
            btnCafefrio.Name = "btnCafefrio";
            btnCafefrio.Size = new Size(139, 29);
            btnCafefrio.TabIndex = 1;
            btnCafefrio.Text = "CAFES FRIOS";
            btnCafefrio.UseVisualStyleBackColor = true;
            btnCafefrio.Click += btnCafefrio_Click;
            // 
            // btnCafecaliente
            // 
            btnCafecaliente.FlatStyle = FlatStyle.Flat;
            btnCafecaliente.Location = new Point(713, 34);
            btnCafecaliente.Name = "btnCafecaliente";
            btnCafecaliente.Size = new Size(147, 29);
            btnCafecaliente.TabIndex = 2;
            btnCafecaliente.Text = "CAFE CALIENTES";
            btnCafecaliente.UseVisualStyleBackColor = true;
            btnCafecaliente.Click += btnCafecaliente_Click;
            // 
            // btnTodos
            // 
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Location = new Point(452, 33);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(94, 29);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "TODOS";
            btnTodos.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(232, 33);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(214, 27);
            txtBusqueda.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(108, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Starducks";
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 81);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(988, 64);
            panelMenu.TabIndex = 1;
            // 
            // flowLayoutPanelPanelProductos
            // 
            flowLayoutPanelPanelProductos.AutoScroll = true;
            flowLayoutPanelPanelProductos.BackColor = Color.FromArgb(229, 231, 235);
            flowLayoutPanelPanelProductos.Dock = DockStyle.Left;
            flowLayoutPanelPanelProductos.Location = new Point(0, 145);
            flowLayoutPanelPanelProductos.Name = "flowLayoutPanelPanelProductos";
            flowLayoutPanelPanelProductos.Size = new Size(828, 449);
            flowLayoutPanelPanelProductos.TabIndex = 2;
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = SystemColors.AppWorkspace;
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(829, 201);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(159, 302);
            dgvCarrito.TabIndex = 1;
            // 
            // lblTituloPedido
            // 
            lblTituloPedido.AutoSize = true;
            lblTituloPedido.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPedido.Location = new Point(850, 157);
            lblTituloPedido.Name = "lblTituloPedido";
            lblTituloPedido.Size = new Size(126, 24);
            lblTituloPedido.TabIndex = 0;
            lblTituloPedido.Text = "TU PEDIDO";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(0, 31, 63);
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.Gold;
            btnPagar.Location = new Point(860, 544);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(94, 38);
            btnPagar.TabIndex = 0;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            // 
            // lblTotalCarrito
            // 
            lblTotalCarrito.AutoSize = true;
            lblTotalCarrito.Location = new Point(860, 506);
            lblTotalCarrito.Name = "lblTotalCarrito";
            lblTotalCarrito.Size = new Size(84, 20);
            lblTotalCarrito.TabIndex = 4;
            lblTotalCarrito.Text = "Total: $0.00";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 594);
            Controls.Add(lblTotalCarrito);
            Controls.Add(dgvCarrito);
            Controls.Add(btnPagar);
            Controls.Add(flowLayoutPanelPanelProductos);
            Controls.Add(lblTituloPedido);
            Controls.Add(panelMenu);
            Controls.Add(panelBusqueda);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
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
    }
}