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
            txtBusqueda = new TextBox();
            lblTitulo = new Label();
            panelMenu = new Panel();
            btnTodos = new Button();
            btnPostres = new Button();
            btnCafecaliente = new Button();
            btnCafefrio = new Button();
            flowLayoutPanelPanelProductos = new FlowLayoutPanel();
            panelBusqueda.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(txtBusqueda);
            panelBusqueda.Controls.Add(lblTitulo);
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(0, 0);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(988, 76);
            panelBusqueda.TabIndex = 0;
            panelBusqueda.Paint += panel1_Paint;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(270, 33);
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
            panelMenu.Controls.Add(btnTodos);
            panelMenu.Controls.Add(btnPostres);
            panelMenu.Controls.Add(btnCafecaliente);
            panelMenu.Controls.Add(btnCafefrio);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 76);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(988, 50);
            panelMenu.TabIndex = 1;
            // 
            // btnTodos
            // 
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Location = new Point(123, 15);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(94, 29);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "TODOS";
            btnTodos.UseVisualStyleBackColor = true;
            // 
            // btnPostres
            // 
            btnPostres.FlatStyle = FlatStyle.Flat;
            btnPostres.Location = new Point(687, 18);
            btnPostres.Name = "btnPostres";
            btnPostres.Size = new Size(94, 29);
            btnPostres.TabIndex = 3;
            btnPostres.Text = "POSTRES";
            btnPostres.UseVisualStyleBackColor = true;
            btnPostres.Click += btnPostres_Click;
            // 
            // btnCafecaliente
            // 
            btnCafecaliente.FlatStyle = FlatStyle.Flat;
            btnCafecaliente.Location = new Point(476, 15);
            btnCafecaliente.Name = "btnCafecaliente";
            btnCafecaliente.Size = new Size(147, 29);
            btnCafecaliente.TabIndex = 2;
            btnCafecaliente.Text = "CAFE CALIENTES";
            btnCafecaliente.UseVisualStyleBackColor = true;
            // 
            // btnCafefrio
            // 
            btnCafefrio.FlatStyle = FlatStyle.Flat;
            btnCafefrio.Location = new Point(284, 15);
            btnCafefrio.Name = "btnCafefrio";
            btnCafefrio.Size = new Size(139, 29);
            btnCafefrio.TabIndex = 1;
            btnCafefrio.Text = "CAFES FRIOS";
            btnCafefrio.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelPanelProductos
            // 
            flowLayoutPanelPanelProductos.AutoScroll = true;
            flowLayoutPanelPanelProductos.Dock = DockStyle.Fill;
            flowLayoutPanelPanelProductos.Location = new Point(0, 126);
            flowLayoutPanelPanelProductos.Name = "flowLayoutPanelPanelProductos";
            flowLayoutPanelPanelProductos.Size = new Size(988, 468);
            flowLayoutPanelPanelProductos.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 594);
            Controls.Add(flowLayoutPanelPanelProductos);
            Controls.Add(panelMenu);
            Controls.Add(panelBusqueda);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}