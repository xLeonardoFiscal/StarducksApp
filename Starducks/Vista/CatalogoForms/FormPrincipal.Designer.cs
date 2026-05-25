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
            panel1 = new Panel();
            txtBusqueda = new TextBox();
            lblTitulo = new Label();
            flowLayoutPanelPanelProductos = new Panel();
            btnPostres = new Button();
            btnCafecaliente = new Button();
            btnCafefrio = new Button();
            btnTodos = new Button();
            flowLayoutPanelProductos = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanelPanelProductos.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 80);
            panel1.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(248, 35);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(214, 27);
            txtBusqueda.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(33, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Starducks";
            // 
            // flowLayoutPanelPanelProductos
            // 
            flowLayoutPanelPanelProductos.Controls.Add(btnPostres);
            flowLayoutPanelPanelProductos.Controls.Add(btnCafecaliente);
            flowLayoutPanelPanelProductos.Controls.Add(btnCafefrio);
            flowLayoutPanelPanelProductos.Controls.Add(btnTodos);
            flowLayoutPanelPanelProductos.Dock = DockStyle.Top;
            flowLayoutPanelPanelProductos.Location = new Point(0, 80);
            flowLayoutPanelPanelProductos.Name = "flowLayoutPanelPanelProductos";
            flowLayoutPanelPanelProductos.Size = new Size(988, 50);
            flowLayoutPanelPanelProductos.TabIndex = 1;
            
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
            // btnTodos
            // 
            btnTodos.FlatStyle = FlatStyle.Flat;
            btnTodos.Location = new Point(157, 15);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(94, 29);
            btnTodos.TabIndex = 0;
            btnTodos.Text = "TODOS";
            btnTodos.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelProductos
            // 
            flowLayoutPanelProductos.AutoScroll = true;
            flowLayoutPanelProductos.Dock = DockStyle.Fill;
            flowLayoutPanelProductos.Location = new Point(0, 130);
            flowLayoutPanelProductos.Name = "flowLayoutPanelProductos";
            flowLayoutPanelProductos.Size = new Size(988, 464);
            flowLayoutPanelProductos.TabIndex = 2;
            
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 594);
            Controls.Add(flowLayoutPanelProductos);
            Controls.Add(flowLayoutPanelPanelProductos);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanelPanelProductos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private TextBox txtBusqueda;
        private Panel flowLayoutPanelPanelProductos;
        private Button btnTodos;
        private Button btnCafefrio;
        private Button btnPostres;
        private Button btnCafecaliente;
        private FlowLayoutPanel flowLayoutPanelProductos;
    }
}