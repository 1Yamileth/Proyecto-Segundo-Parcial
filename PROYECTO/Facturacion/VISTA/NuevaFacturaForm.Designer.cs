namespace VISTA
{
    partial class NuevaFacturaForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClienteNombretextBox = new System.Windows.Forms.TextBox();
            this.BusquedaIdbutton = new System.Windows.Forms.Button();
            this.Id_ClientetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DescripcionProductotextBox = new System.Windows.Forms.TextBox();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.CodigoProductotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.isvtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DesceuntotextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.GuardarFacturabutton = new System.Windows.Forms.Button();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.FechadateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Usuario_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1158, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(909, 17);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(145, 26);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label3.Location = new System.Drawing.Point(749, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Factura:";
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Location = new System.Drawing.Point(100, 17);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.ReadOnly = true;
            this.Usuario_textBox.Size = new System.Drawing.Size(224, 26);
            this.Usuario_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ClienteNombretextBox);
            this.groupBox2.Controls.Add(this.BusquedaIdbutton);
            this.groupBox2.Controls.Add(this.Id_ClientetextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.Location = new System.Drawing.Point(15, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1156, 57);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // ClienteNombretextBox
            // 
            this.ClienteNombretextBox.Location = new System.Drawing.Point(381, 25);
            this.ClienteNombretextBox.Name = "ClienteNombretextBox";
            this.ClienteNombretextBox.ReadOnly = true;
            this.ClienteNombretextBox.Size = new System.Drawing.Size(748, 26);
            this.ClienteNombretextBox.TabIndex = 6;
            // 
            // BusquedaIdbutton
            // 
            this.BusquedaIdbutton.Image = global::VISTA.Properties.Resources.lupa;
            this.BusquedaIdbutton.Location = new System.Drawing.Point(331, 25);
            this.BusquedaIdbutton.Name = "BusquedaIdbutton";
            this.BusquedaIdbutton.Size = new System.Drawing.Size(44, 26);
            this.BusquedaIdbutton.TabIndex = 5;
            this.BusquedaIdbutton.UseVisualStyleBackColor = true;
            this.BusquedaIdbutton.Click += new System.EventHandler(this.BusquedaIdbutton_Click);
            // 
            // Id_ClientetextBox
            // 
            this.Id_ClientetextBox.Location = new System.Drawing.Point(99, 25);
            this.Id_ClientetextBox.Name = "Id_ClientetextBox";
            this.Id_ClientetextBox.Size = new System.Drawing.Size(224, 26);
            this.Id_ClientetextBox.TabIndex = 4;
            this.Id_ClientetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Id_ClientetextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identidad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.CantidadtextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ExistenciatextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DescripcionProductotextBox);
            this.groupBox3.Controls.Add(this.BuscarProductobutton);
            this.groupBox3.Controls.Add(this.CodigoProductotextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox3.Location = new System.Drawing.Point(15, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1156, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Producto";
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadtextBox.Location = new System.Drawing.Point(904, 61);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(224, 26);
            this.CantidadtextBox.TabIndex = 10;
            this.CantidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadtextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(806, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cantidad:";
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(99, 61);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.Size = new System.Drawing.Size(224, 26);
            this.ExistenciatextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Existencia:";
            // 
            // DescripcionProductotextBox
            // 
            this.DescripcionProductotextBox.Location = new System.Drawing.Point(381, 21);
            this.DescripcionProductotextBox.Name = "DescripcionProductotextBox";
            this.DescripcionProductotextBox.ReadOnly = true;
            this.DescripcionProductotextBox.Size = new System.Drawing.Size(748, 26);
            this.DescripcionProductotextBox.TabIndex = 7;
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.Image = global::VISTA.Properties.Resources.lupa;
            this.BuscarProductobutton.Location = new System.Drawing.Point(331, 21);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(44, 26);
            this.BuscarProductobutton.TabIndex = 7;
            this.BuscarProductobutton.UseVisualStyleBackColor = true;
            this.BuscarProductobutton.Click += new System.EventHandler(this.BuscarProductobutton_Click);
            // 
            // CodigoProductotextBox
            // 
            this.CodigoProductotextBox.Location = new System.Drawing.Point(99, 22);
            this.CodigoProductotextBox.Name = "CodigoProductotextBox";
            this.CodigoProductotextBox.Size = new System.Drawing.Size(224, 26);
            this.CodigoProductotextBox.TabIndex = 7;
            this.CodigoProductotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodigoProductotextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Codigo:";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalledataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(14, 252);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(1159, 135);
            this.DetalledataGridView.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(820, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Subtotal:";
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.SubtotaltextBox.Location = new System.Drawing.Point(919, 393);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.ReadOnly = true;
            this.SubtotaltextBox.Size = new System.Drawing.Size(224, 26);
            this.SubtotaltextBox.TabIndex = 12;
            // 
            // isvtextBox
            // 
            this.isvtextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.isvtextBox.Location = new System.Drawing.Point(919, 425);
            this.isvtextBox.Name = "isvtextBox";
            this.isvtextBox.ReadOnly = true;
            this.isvtextBox.Size = new System.Drawing.Size(224, 26);
            this.isvtextBox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(820, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "ISV:";
            // 
            // DesceuntotextBox
            // 
            this.DesceuntotextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.DesceuntotextBox.Location = new System.Drawing.Point(919, 457);
            this.DesceuntotextBox.Name = "DesceuntotextBox";
            this.DesceuntotextBox.Size = new System.Drawing.Size(224, 26);
            this.DesceuntotextBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(820, 465);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Descuento:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.TotaltextBox.Location = new System.Drawing.Point(919, 489);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(224, 26);
            this.TotaltextBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.Location = new System.Drawing.Point(820, 497);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Total:";
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Font = new System.Drawing.Font("Arial", 12F);
            this.Cancelarbutton.Image = global::VISTA.Properties.Resources.boton_x;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.Location = new System.Drawing.Point(16, 410);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(108, 41);
            this.Cancelarbutton.TabIndex = 20;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // GuardarFacturabutton
            // 
            this.GuardarFacturabutton.Font = new System.Drawing.Font("Arial", 12F);
            this.GuardarFacturabutton.Image = global::VISTA.Properties.Resources.cheque;
            this.GuardarFacturabutton.Location = new System.Drawing.Point(148, 410);
            this.GuardarFacturabutton.Name = "GuardarFacturabutton";
            this.GuardarFacturabutton.Size = new System.Drawing.Size(108, 41);
            this.GuardarFacturabutton.TabIndex = 19;
            this.GuardarFacturabutton.Text = "Guardar";
            this.GuardarFacturabutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuardarFacturabutton.UseVisualStyleBackColor = true;
            this.GuardarFacturabutton.Click += new System.EventHandler(this.GuardarFacturabutton_Click);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // NuevaFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.CaptionForeColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1178, 532);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.GuardarFacturabutton);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DesceuntotextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.isvtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuevaFacturaForm";
            this.Text = "NuevaFacturaForm";
            this.Load += new System.EventHandler(this.NuevaFacturaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ClienteNombretextBox;
        private System.Windows.Forms.Button BusquedaIdbutton;
        private System.Windows.Forms.TextBox Id_ClientetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DescripcionProductotextBox;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.TextBox CodigoProductotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.TextBox isvtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DesceuntotextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button GuardarFacturabutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}