namespace Starducks.Vista
{
    partial class CatalogoPrincipal
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
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            domainUpDown1 = new DomainUpDown();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(237, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(344, 244);
            listBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(257, 114);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(407, 128);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(150, 27);
            domainUpDown1.TabIndex = 2;
            domainUpDown1.Text = "domainUpDown1";
            // 
            // CatalogoPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(domainUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Name = "CatalogoPrincipal";
            Text = "CatalogoPrincipal";
            Load += CatalogoPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private DomainUpDown domainUpDown1;
    }
}