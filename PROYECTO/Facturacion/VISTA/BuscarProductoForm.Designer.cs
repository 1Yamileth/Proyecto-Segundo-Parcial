namespace VISTA
{
    partial class BuscarProductoForm
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
            this.Productos_dataGridView = new System.Windows.Forms.DataGridView();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Productos_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Productos_dataGridView
            // 
            this.Productos_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos_dataGridView.Location = new System.Drawing.Point(13, 123);
            this.Productos_dataGridView.Name = "Productos_dataGridView";
            this.Productos_dataGridView.Size = new System.Drawing.Size(775, 178);
            this.Productos_dataGridView.TabIndex = 9;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.Location = new System.Drawing.Point(264, 71);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(92, 29);
            this.Cancelarbutton.TabIndex = 8;
            this.Cancelarbutton.Text = "CANCELAR";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptarbutton.Location = new System.Drawing.Point(143, 71);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(92, 29);
            this.Aceptarbutton.TabIndex = 7;
            this.Aceptarbutton.Text = "ACEPTAR";
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripciontextBox.Location = new System.Drawing.Point(143, 22);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(587, 27);
            this.DescripciontextBox.TabIndex = 6;
            this.DescripciontextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DescripciontextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripcion:";
            // 
            // BuscarProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.Productos_dataGridView);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label1);
            this.Name = "BuscarProductoForm";
            this.Text = "BuscarProductoForm";
            this.Load += new System.EventHandler(this.BuscarProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Productos_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Productos_dataGridView;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label1;
    }
}