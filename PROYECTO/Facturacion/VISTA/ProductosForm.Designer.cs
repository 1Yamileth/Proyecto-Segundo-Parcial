namespace VISTA
{
    partial class ProductosForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoProducto_textBox1 = new System.Windows.Forms.TextBox();
            this.Descripcion_textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Precio_textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Existencia_textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdjuntarImagen_button1 = new System.Windows.Forms.Button();
            this.ImagenProduct_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancelar_button5 = new System.Windows.Forms.Button();
            this.Eliminar_button4 = new System.Windows.Forms.Button();
            this.Guardar_button3 = new System.Windows.Forms.Button();
            this.Modificar_button2 = new System.Windows.Forms.Button();
            this.Nuevo_button1 = new System.Windows.Forms.Button();
            this.Productos_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.EstaActivo_checkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProduct_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // CodigoProducto_textBox1
            // 
            this.CodigoProducto_textBox1.Enabled = false;
            this.CodigoProducto_textBox1.Location = new System.Drawing.Point(126, 13);
            this.CodigoProducto_textBox1.Name = "CodigoProducto_textBox1";
            this.CodigoProducto_textBox1.Size = new System.Drawing.Size(171, 20);
            this.CodigoProducto_textBox1.TabIndex = 1;
            // 
            // Descripcion_textBox1
            // 
            this.Descripcion_textBox1.Enabled = false;
            this.Descripcion_textBox1.Location = new System.Drawing.Point(126, 55);
            this.Descripcion_textBox1.Name = "Descripcion_textBox1";
            this.Descripcion_textBox1.Size = new System.Drawing.Size(171, 20);
            this.Descripcion_textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // Precio_textBox1
            // 
            this.Precio_textBox1.Enabled = false;
            this.Precio_textBox1.Location = new System.Drawing.Point(125, 143);
            this.Precio_textBox1.Name = "Precio_textBox1";
            this.Precio_textBox1.Size = new System.Drawing.Size(171, 20);
            this.Precio_textBox1.TabIndex = 7;
            this.Precio_textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio:";
            // 
            // Existencia_textBox2
            // 
            this.Existencia_textBox2.Enabled = false;
            this.Existencia_textBox2.Location = new System.Drawing.Point(126, 101);
            this.Existencia_textBox2.Name = "Existencia_textBox2";
            this.Existencia_textBox2.Size = new System.Drawing.Size(171, 20);
            this.Existencia_textBox2.TabIndex = 5;
            this.Existencia_textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Existencia_textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Existencia:";
            // 
            // AdjuntarImagen_button1
            // 
            this.AdjuntarImagen_button1.Image = global::VISTA.Properties.Resources.producto;
            this.AdjuntarImagen_button1.Location = new System.Drawing.Point(447, 128);
            this.AdjuntarImagen_button1.Name = "AdjuntarImagen_button1";
            this.AdjuntarImagen_button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdjuntarImagen_button1.Size = new System.Drawing.Size(42, 35);
            this.AdjuntarImagen_button1.TabIndex = 9;
            this.AdjuntarImagen_button1.UseVisualStyleBackColor = true;
            this.AdjuntarImagen_button1.Click += new System.EventHandler(this.AdjuntarImagen_button1_Click);
            // 
            // ImagenProduct_pictureBox1
            // 
            this.ImagenProduct_pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.ImagenProduct_pictureBox1.Location = new System.Drawing.Point(337, 12);
            this.ImagenProduct_pictureBox1.Name = "ImagenProduct_pictureBox1";
            this.ImagenProduct_pictureBox1.Size = new System.Drawing.Size(203, 109);
            this.ImagenProduct_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenProduct_pictureBox1.TabIndex = 8;
            this.ImagenProduct_pictureBox1.TabStop = false;
            // 
            // Cancelar_button5
            // 
            this.Cancelar_button5.Enabled = false;
            this.Cancelar_button5.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Cancelar_button5.Image = global::VISTA.Properties.Resources.archivo;
            this.Cancelar_button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar_button5.Location = new System.Drawing.Point(572, 188);
            this.Cancelar_button5.Name = "Cancelar_button5";
            this.Cancelar_button5.Size = new System.Drawing.Size(91, 34);
            this.Cancelar_button5.TabIndex = 23;
            this.Cancelar_button5.Text = "Cancelar";
            this.Cancelar_button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar_button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cancelar_button5.UseVisualStyleBackColor = true;
            this.Cancelar_button5.Click += new System.EventHandler(this.Cancelar_button5_Click);
            // 
            // Eliminar_button4
            // 
            this.Eliminar_button4.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Eliminar_button4.Image = global::VISTA.Properties.Resources.usuario;
            this.Eliminar_button4.Location = new System.Drawing.Point(475, 188);
            this.Eliminar_button4.Name = "Eliminar_button4";
            this.Eliminar_button4.Size = new System.Drawing.Size(91, 34);
            this.Eliminar_button4.TabIndex = 22;
            this.Eliminar_button4.Text = "Eliminar";
            this.Eliminar_button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Eliminar_button4.UseVisualStyleBackColor = true;
            this.Eliminar_button4.Click += new System.EventHandler(this.Eliminar_button4_Click);
            // 
            // Guardar_button3
            // 
            this.Guardar_button3.Enabled = false;
            this.Guardar_button3.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Guardar_button3.Image = global::VISTA.Properties.Resources.guardar_el_archivo;
            this.Guardar_button3.Location = new System.Drawing.Point(378, 188);
            this.Guardar_button3.Name = "Guardar_button3";
            this.Guardar_button3.Size = new System.Drawing.Size(91, 34);
            this.Guardar_button3.TabIndex = 21;
            this.Guardar_button3.Text = "Guardar";
            this.Guardar_button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Guardar_button3.UseVisualStyleBackColor = true;
            this.Guardar_button3.Click += new System.EventHandler(this.Guardar_button3_Click);
            // 
            // Modificar_button2
            // 
            this.Modificar_button2.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Modificar_button2.Image = global::VISTA.Properties.Resources.curriculum1;
            this.Modificar_button2.Location = new System.Drawing.Point(281, 188);
            this.Modificar_button2.Name = "Modificar_button2";
            this.Modificar_button2.Size = new System.Drawing.Size(91, 34);
            this.Modificar_button2.TabIndex = 20;
            this.Modificar_button2.Text = "Modificar";
            this.Modificar_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Modificar_button2.UseVisualStyleBackColor = true;
            this.Modificar_button2.Click += new System.EventHandler(this.Modificar_button2_Click);
            // 
            // Nuevo_button1
            // 
            this.Nuevo_button1.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Nuevo_button1.Image = global::VISTA.Properties.Resources.nuevo__1_;
            this.Nuevo_button1.Location = new System.Drawing.Point(184, 188);
            this.Nuevo_button1.Name = "Nuevo_button1";
            this.Nuevo_button1.Size = new System.Drawing.Size(91, 34);
            this.Nuevo_button1.TabIndex = 19;
            this.Nuevo_button1.Text = "Nuevo";
            this.Nuevo_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Nuevo_button1.UseVisualStyleBackColor = true;
            this.Nuevo_button1.Click += new System.EventHandler(this.Nuevo_button1_Click);
            // 
            // Productos_dataGridView1
            // 
            this.Productos_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Productos_dataGridView1.Location = new System.Drawing.Point(30, 237);
            this.Productos_dataGridView1.Name = "Productos_dataGridView1";
            this.Productos_dataGridView1.Size = new System.Drawing.Size(675, 150);
            this.Productos_dataGridView1.TabIndex = 24;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstaActivo_checkBox
            // 
            this.EstaActivo_checkBox.AutoSize = true;
            this.EstaActivo_checkBox.Enabled = false;
            this.EstaActivo_checkBox.Location = new System.Drawing.Point(127, 187);
            this.EstaActivo_checkBox.Name = "EstaActivo_checkBox";
            this.EstaActivo_checkBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivo_checkBox.TabIndex = 26;
            this.EstaActivo_checkBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Estado Activo:";
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 403);
            this.Controls.Add(this.EstaActivo_checkBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Productos_dataGridView1);
            this.Controls.Add(this.Cancelar_button5);
            this.Controls.Add(this.Eliminar_button4);
            this.Controls.Add(this.Guardar_button3);
            this.Controls.Add(this.Modificar_button2);
            this.Controls.Add(this.Nuevo_button1);
            this.Controls.Add(this.AdjuntarImagen_button1);
            this.Controls.Add(this.ImagenProduct_pictureBox1);
            this.Controls.Add(this.Precio_textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Existencia_textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Descripcion_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoProducto_textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductosForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProduct_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Productos_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodigoProducto_textBox1;
        private System.Windows.Forms.TextBox Descripcion_textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Precio_textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Existencia_textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ImagenProduct_pictureBox1;
        private System.Windows.Forms.Button AdjuntarImagen_button1;
        private System.Windows.Forms.Button Cancelar_button5;
        private System.Windows.Forms.Button Eliminar_button4;
        private System.Windows.Forms.Button Guardar_button3;
        private System.Windows.Forms.Button Modificar_button2;
        private System.Windows.Forms.Button Nuevo_button1;
        private System.Windows.Forms.DataGridView Productos_dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox EstaActivo_checkBox;
        private System.Windows.Forms.Label label6;
    }
}