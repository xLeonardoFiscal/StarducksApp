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
            cmbTamano = new ComboBox();
            lblTamaño = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
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
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(3, 159);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = Color.FromArgb(102, 102, 102);
            lblDescripcion.Location = new Point(3, 193);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.FromArgb(0, 98, 65);
            lblPrecio.Location = new Point(134, 274);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 23);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // cmbTamano
            // 
            cmbTamano.FormattingEnabled = true;
            cmbTamano.Location = new Point(84, 216);
            cmbTamano.Name = "cmbTamano";
            cmbTamano.Size = new Size(133, 28);
            cmbTamano.TabIndex = 4;
            // 
            // lblTamaño
            // 
            lblTamaño.AutoSize = true;
            lblTamaño.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTamaño.ForeColor = SystemColors.ActiveCaptionText;
            lblTamaño.Location = new Point(0, 219);
            lblTamaño.Name = "lblTamaño";
            lblTamaño.Size = new Size(79, 25);
            lblTamaño.TabIndex = 5;
            lblTamaño.Text = "Tamaño";
            lblTamaño.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.FromArgb(0, 98, 65);
            btnAgregar.Location = new Point(3, 274);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(114, 326);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Green;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(3, 326);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // TarjetaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTamaño);
            Controls.Add(cmbTamano);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(pbImagen);
            Name = "TarjetaProducto";
            Size = new Size(220, 386);
            Load += TarjetaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagen;
        public Label lblNombre;
        public Label lblDescripcion;
        public Label lblPrecio;
        public ComboBox cmbTamano;
        public Label lblTamaño;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
    }
}
