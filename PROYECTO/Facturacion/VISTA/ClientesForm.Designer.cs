namespace VISTA
{
    partial class ClientesForm
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
            this.EstaActivo_checkBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Correo_textBox = new System.Windows.Forms.TextBox();
            this.Telefono_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Identidad_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Clientes_dataGridView = new System.Windows.Forms.DataGridView();
            this.Cancelar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Modificar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechaNacimientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // EstaActivo_checkBox
            // 
            this.EstaActivo_checkBox.AutoSize = true;
            this.EstaActivo_checkBox.Enabled = false;
            this.EstaActivo_checkBox.Location = new System.Drawing.Point(118, 251);
            this.EstaActivo_checkBox.Name = "EstaActivo_checkBox";
            this.EstaActivo_checkBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivo_checkBox.TabIndex = 23;
            this.EstaActivo_checkBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Estado Activo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Correo:";
            // 
            // Correo_textBox
            // 
            this.Correo_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Correo_textBox.Enabled = false;
            this.Correo_textBox.Location = new System.Drawing.Point(167, 127);
            this.Correo_textBox.Name = "Correo_textBox";
            this.Correo_textBox.Size = new System.Drawing.Size(229, 20);
            this.Correo_textBox.TabIndex = 18;
            // 
            // Telefono_textBox
            // 
            this.Telefono_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Telefono_textBox.Enabled = false;
            this.Telefono_textBox.Location = new System.Drawing.Point(166, 87);
            this.Telefono_textBox.Name = "Telefono_textBox";
            this.Telefono_textBox.Size = new System.Drawing.Size(229, 20);
            this.Telefono_textBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefono:";
            // 
            // Identidad_textBox
            // 
            this.Identidad_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Identidad_textBox.Enabled = false;
            this.Identidad_textBox.Location = new System.Drawing.Point(166, 16);
            this.Identidad_textBox.Name = "Identidad_textBox";
            this.Identidad_textBox.Size = new System.Drawing.Size(229, 20);
            this.Identidad_textBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // Nombre_textBox
            // 
            this.Nombre_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nombre_textBox.Enabled = false;
            this.Nombre_textBox.Location = new System.Drawing.Point(166, 51);
            this.Nombre_textBox.Name = "Nombre_textBox";
            this.Nombre_textBox.Size = new System.Drawing.Size(229, 20);
            this.Nombre_textBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Identidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Direccion:";
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirecciontextBox.Enabled = false;
            this.DirecciontextBox.Location = new System.Drawing.Point(166, 173);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(229, 20);
            this.DirecciontextBox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha De Nacimineto:";
            // 
            // Clientes_dataGridView
            // 
            this.Clientes_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clientes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Clientes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clientes_dataGridView.Location = new System.Drawing.Point(6, 305);
            this.Clientes_dataGridView.Name = "Clientes_dataGridView";
            this.Clientes_dataGridView.Size = new System.Drawing.Size(699, 201);
            this.Clientes_dataGridView.TabIndex = 33;
            // 
            // Cancelar_button
            // 
            this.Cancelar_button.Enabled = false;
            this.Cancelar_button.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Cancelar_button.Image = global::VISTA.Properties.Resources.archivo;
            this.Cancelar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar_button.Location = new System.Drawing.Point(555, 265);
            this.Cancelar_button.Name = "Cancelar_button";
            this.Cancelar_button.Size = new System.Drawing.Size(91, 34);
            this.Cancelar_button.TabIndex = 32;
            this.Cancelar_button.Text = "Cancelar";
            this.Cancelar_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cancelar_button.UseVisualStyleBackColor = true;
            this.Cancelar_button.Click += new System.EventHandler(this.Cancelar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Eliminar_button.Image = global::VISTA.Properties.Resources.usuario;
            this.Eliminar_button.Location = new System.Drawing.Point(458, 265);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(91, 34);
            this.Eliminar_button.TabIndex = 31;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Enabled = false;
            this.Guardar_button.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Guardar_button.Image = global::VISTA.Properties.Resources.guardar_el_archivo;
            this.Guardar_button.Location = new System.Drawing.Point(361, 265);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(91, 34);
            this.Guardar_button.TabIndex = 30;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Modificar_button
            // 
            this.Modificar_button.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Modificar_button.Image = global::VISTA.Properties.Resources.curriculum1;
            this.Modificar_button.Location = new System.Drawing.Point(264, 265);
            this.Modificar_button.Name = "Modificar_button";
            this.Modificar_button.Size = new System.Drawing.Size(91, 34);
            this.Modificar_button.TabIndex = 29;
            this.Modificar_button.Text = "Modificar";
            this.Modificar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Modificar_button.UseVisualStyleBackColor = true;
            this.Modificar_button.Click += new System.EventHandler(this.Modificar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Nuevo_button.Image = global::VISTA.Properties.Resources.nuevo__1_;
            this.Nuevo_button.Location = new System.Drawing.Point(167, 265);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(91, 34);
            this.Nuevo_button.TabIndex = 28;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FechaNacimientodateTimePicker
            // 
            this.FechaNacimientodateTimePicker.Enabled = false;
            this.FechaNacimientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientodateTimePicker.Location = new System.Drawing.Point(167, 218);
            this.FechaNacimientodateTimePicker.Name = "FechaNacimientodateTimePicker";
            this.FechaNacimientodateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.FechaNacimientodateTimePicker.TabIndex = 34;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 520);
            this.Controls.Add(this.FechaNacimientodateTimePicker);
            this.Controls.Add(this.Clientes_dataGridView);
            this.Controls.Add(this.Cancelar_button);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Modificar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.EstaActivo_checkBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Correo_textBox);
            this.Controls.Add(this.Telefono_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Identidad_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_textBox);
            this.Controls.Add(this.label1);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Clientes_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EstaActivo_checkBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Correo_textBox;
        private System.Windows.Forms.TextBox Telefono_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Identidad_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView Clientes_dataGridView;
        private System.Windows.Forms.Button Cancelar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Modificar_button;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DateTimePicker FechaNacimientodateTimePicker;
    }
}