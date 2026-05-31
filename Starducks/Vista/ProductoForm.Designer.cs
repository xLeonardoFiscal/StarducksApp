namespace Starducks.Vista
{
    partial class ProductoForm
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
            lblTituloGestion = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            Descripcion = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            pbProducto = new PictureBox();
            btnCargarImagen = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProducto).BeginInit();
            SuspendLayout();
            // 
            // lblTituloGestion
            // 
            lblTituloGestion.AutoSize = true;
            lblTituloGestion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGestion.Location = new Point(119, 9);
            lblTituloGestion.Name = "lblTituloGestion";
            lblTituloGestion.Size = new Size(354, 38);
            lblTituloGestion.TabIndex = 0;
            lblTituloGestion.Text = "GESTIÓN DE PRODUCTOS";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(42, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(42, 140);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(76, 28);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Descripcion.Location = new Point(42, 231);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(128, 28);
            Descripcion.TabIndex = 3;
            Descripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(36, 182);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(219, 27);
            txtPrecio.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(36, 277);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(216, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // pbProducto
            // 
            pbProducto.BorderStyle = BorderStyle.FixedSingle;
            pbProducto.Location = new Point(317, 79);
            pbProducto.Name = "pbProducto";
            pbProducto.Size = new Size(180, 180);
            pbProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pbProducto.TabIndex = 7;
            pbProducto.TabStop = false;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarImagen.Location = new Point(338, 277);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(135, 29);
            btnCargarImagen.TabIndex = 8;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.UseVisualStyleBackColor = true;
            btnCargarImagen.Click += btnCargarImagen_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(303, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCargarImagen_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(123, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnCargarImagen_Click;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 403);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargarImagen);
            Controls.Add(pbProducto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(Descripcion);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblTituloGestion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProductoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductoForm";
            
            ((System.ComponentModel.ISupportInitialize)pbProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloGestion;
        private Label lblNombre;
        private Label lblPrecio;
        private Label Descripcion;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private PictureBox pbProducto;
        private Button btnCargarImagen;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}