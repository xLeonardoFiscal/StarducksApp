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
            lblPrecioTall = new Label();
            Descripcion = new Label();
            txtNombre = new TextBox();
            txtPrecioTall = new TextBox();
            txtDescripcion = new TextBox();
            pbProducto = new PictureBox();
            btnCargarImagen = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            txtId = new TextBox();
            txtPrecioGrande = new TextBox();
            lblPrecioGrande = new Label();
            txtPrecioVenti = new TextBox();
            lblPrecioVenti = new Label();
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
            lblNombre.Location = new Point(19, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecioTall
            // 
            lblPrecioTall.AutoSize = true;
            lblPrecioTall.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioTall.Location = new Point(19, 267);
            lblPrecioTall.Name = "lblPrecioTall";
            lblPrecioTall.Size = new Size(115, 28);
            lblPrecioTall.TabIndex = 2;
            lblPrecioTall.Text = "Precio Tall:";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Descripcion.Location = new Point(19, 114);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(128, 28);
            Descripcion.TabIndex = 3;
            Descripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(13, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtPrecioTall
            // 
            txtPrecioTall.Location = new Point(13, 309);
            txtPrecioTall.Name = "txtPrecioTall";
            txtPrecioTall.Size = new Size(219, 27);
            txtPrecioTall.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(13, 160);
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
            btnCancelar.Location = new Point(408, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(267, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(135, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "CAFES FRIOS", "CAFES CALIENTES", "POSTRES" });
            cmbCategoria.Location = new Point(12, 226);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(213, 28);
            cmbCategoria.TabIndex = 11;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(19, 195);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(108, 28);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "Categoria:";
            // 
            // txtId
            // 
            txtId.Location = new Point(348, 50);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 13;
            // 
            // txtPrecioGrande
            // 
            txtPrecioGrande.Location = new Point(13, 391);
            txtPrecioGrande.Name = "txtPrecioGrande";
            txtPrecioGrande.Size = new Size(219, 27);
            txtPrecioGrande.TabIndex = 15;
            // 
            // lblPrecioGrande
            // 
            lblPrecioGrande.AutoSize = true;
            lblPrecioGrande.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioGrande.Location = new Point(19, 349);
            lblPrecioGrande.Name = "lblPrecioGrande";
            lblPrecioGrande.Size = new Size(150, 28);
            lblPrecioGrande.TabIndex = 14;
            lblPrecioGrande.Text = "Precio Grande:";
            // 
            // txtPrecioVenti
            // 
            txtPrecioVenti.Location = new Point(13, 463);
            txtPrecioVenti.Name = "txtPrecioVenti";
            txtPrecioVenti.Size = new Size(219, 27);
            txtPrecioVenti.TabIndex = 17;
            // 
            // lblPrecioVenti
            // 
            lblPrecioVenti.AutoSize = true;
            lblPrecioVenti.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioVenti.Location = new Point(19, 421);
            lblPrecioVenti.Name = "lblPrecioVenti";
            lblPrecioVenti.Size = new Size(131, 28);
            lblPrecioVenti.TabIndex = 16;
            lblPrecioVenti.Text = "Precio Venti:";
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 585);
            Controls.Add(txtPrecioVenti);
            Controls.Add(lblPrecioVenti);
            Controls.Add(txtPrecioGrande);
            Controls.Add(lblPrecioGrande);
            Controls.Add(txtId);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnCargarImagen);
            Controls.Add(pbProducto);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecioTall);
            Controls.Add(txtNombre);
            Controls.Add(Descripcion);
            Controls.Add(lblPrecioTall);
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
        private Label lblPrecioTall;
        private Label Descripcion;
        private TextBox txtNombre;
        private TextBox txtPrecioTall;
        private TextBox txtDescripcion;
        private PictureBox pbProducto;
        private Button btnCargarImagen;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private TextBox txtId;
        private TextBox txtPrecioGrande;
        private Label lblPrecioGrande;
        private TextBox txtPrecioVenti;
        private Label lblPrecioVenti;
    }
}