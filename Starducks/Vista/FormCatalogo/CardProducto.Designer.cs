namespace Starducks.Vista.FormCatalogo
{
    partial class CardProducto
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
            picImagen = new PictureBox();
            lblNombre = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // picImagen
            // 
            picImagen.Location = new Point(19, 24);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(145, 171);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(183, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(196, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre Del Producto";
            lblNombre.Click += label1_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ButtonHighlight;
            lblPrecio.Location = new Point(196, 81);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(75, 25);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precioo";
            lblPrecio.Click += label2_Click;
            // 
            // CardProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(picImagen);
            Name = "CardProducto";
            Size = new Size(423, 217);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagen;
        private Label lblNombre;
        private Label lblPrecio;
    }
}
