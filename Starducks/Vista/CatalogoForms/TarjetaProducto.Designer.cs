namespace Starducks.Vista.CatalogoForms
{
    partial class TarjetaProducto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pbImagen = new PictureBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.Dock = DockStyle.Top;
            pbImagen.Location = new Point(0, 0);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(220, 140);
            pbImagen.SizeMode = PictureBoxSizeMode.AutoSize;
            pbImagen.TabIndex = 0;
            pbImagen.TabStop = false;
            pbImagen.Click += pbImagen_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ActiveCaptionText;
            lblNombre.Location = new Point(3, 159);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            lblNombre.Click += lblNombre_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(3, 184);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(77, 234);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(57, 23);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(21, 273);
            button1.Name = "button1";
            button1.Size = new Size(175, 29);
            button1.TabIndex = 4;
            button1.Text = "ver detalle";
            button1.UseVisualStyleBackColor = true;
            // 
            // TarjetaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNombre);
            Controls.Add(button1);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(pbImagen);
            Name = "TarjetaProducto";
            Size = new Size(220, 320);
            Load += TarjetaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagen;
        private Button button1;
        public Label lblNombre;
        public Label lblDescripcion;
        public Label lblPrecio;
    }
}
