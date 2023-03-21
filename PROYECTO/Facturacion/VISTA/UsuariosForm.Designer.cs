namespace VISTA
{
    partial class UsuariosForm
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
            this.Nombre_textBox1 = new System.Windows.Forms.TextBox();
            this.Codigo_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contra_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Correo_textBox = new System.Windows.Forms.TextBox();
            this.Rol_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EstaActivo_checkBox = new System.Windows.Forms.CheckBox();
            this.Usuarios_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cancelar_button5 = new System.Windows.Forms.Button();
            this.Eliminar_button4 = new System.Windows.Forms.Button();
            this.Guardar_button3 = new System.Windows.Forms.Button();
            this.Modificar_button2 = new System.Windows.Forms.Button();
            this.Nuevo_button1 = new System.Windows.Forms.Button();
            this.AdjuntarFoto_button = new System.Windows.Forms.Button();
            this.FotoUsuario_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoUsuario_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // Nombre_textBox1
            // 
            this.Nombre_textBox1.Enabled = false;
            this.Nombre_textBox1.Location = new System.Drawing.Point(129, 60);
            this.Nombre_textBox1.Name = "Nombre_textBox1";
            this.Nombre_textBox1.Size = new System.Drawing.Size(229, 20);
            this.Nombre_textBox1.TabIndex = 1;
            // 
            // Codigo_textBox
            // 
            this.Codigo_textBox.Enabled = false;
            this.Codigo_textBox.Location = new System.Drawing.Point(129, 25);
            this.Codigo_textBox.Name = "Codigo_textBox";
            this.Codigo_textBox.Size = new System.Drawing.Size(229, 20);
            this.Codigo_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // Contra_textBox
            // 
            this.Contra_textBox.Enabled = false;
            this.Contra_textBox.Location = new System.Drawing.Point(129, 96);
            this.Contra_textBox.Name = "Contra_textBox";
            this.Contra_textBox.PasswordChar = '*';
            this.Contra_textBox.Size = new System.Drawing.Size(229, 20);
            this.Contra_textBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Correo:";
            // 
            // Correo_textBox
            // 
            this.Correo_textBox.Enabled = false;
            this.Correo_textBox.Location = new System.Drawing.Point(130, 136);
            this.Correo_textBox.Name = "Correo_textBox";
            this.Correo_textBox.Size = new System.Drawing.Size(229, 20);
            this.Correo_textBox.TabIndex = 6;
            // 
            // Rol_comboBox
            // 
            this.Rol_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Rol_comboBox.Enabled = false;
            this.Rol_comboBox.FormattingEnabled = true;
            this.Rol_comboBox.Items.AddRange(new object[] {
            "Administrador ",
            "Usuario"});
            this.Rol_comboBox.Location = new System.Drawing.Point(130, 175);
            this.Rol_comboBox.Name = "Rol_comboBox";
            this.Rol_comboBox.Size = new System.Drawing.Size(229, 21);
            this.Rol_comboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado Activo:";
            // 
            // EstaActivo_checkBox
            // 
            this.EstaActivo_checkBox.AutoSize = true;
            this.EstaActivo_checkBox.Enabled = false;
            this.EstaActivo_checkBox.Location = new System.Drawing.Point(129, 221);
            this.EstaActivo_checkBox.Name = "EstaActivo_checkBox";
            this.EstaActivo_checkBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivo_checkBox.TabIndex = 11;
            this.EstaActivo_checkBox.UseVisualStyleBackColor = true;
            // 
            // Usuarios_dataGridView1
            // 
            this.Usuarios_dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Usuarios_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Usuarios_dataGridView1.Location = new System.Drawing.Point(13, 292);
            this.Usuarios_dataGridView1.Name = "Usuarios_dataGridView1";
            this.Usuarios_dataGridView1.Size = new System.Drawing.Size(636, 201);
            this.Usuarios_dataGridView1.TabIndex = 19;
            // 
            // Cancelar_button5
            // 
            this.Cancelar_button5.Enabled = false;
            this.Cancelar_button5.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Cancelar_button5.Image = global::VISTA.Properties.Resources.archivo;
            this.Cancelar_button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar_button5.Location = new System.Drawing.Point(562, 252);
            this.Cancelar_button5.Name = "Cancelar_button5";
            this.Cancelar_button5.Size = new System.Drawing.Size(91, 34);
            this.Cancelar_button5.TabIndex = 18;
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
            this.Eliminar_button4.Location = new System.Drawing.Point(465, 252);
            this.Eliminar_button4.Name = "Eliminar_button4";
            this.Eliminar_button4.Size = new System.Drawing.Size(91, 34);
            this.Eliminar_button4.TabIndex = 17;
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
            this.Guardar_button3.Location = new System.Drawing.Point(368, 252);
            this.Guardar_button3.Name = "Guardar_button3";
            this.Guardar_button3.Size = new System.Drawing.Size(91, 34);
            this.Guardar_button3.TabIndex = 16;
            this.Guardar_button3.Text = "Guardar";
            this.Guardar_button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Guardar_button3.UseVisualStyleBackColor = true;
            this.Guardar_button3.Click += new System.EventHandler(this.Guardar_button3_Click);
            // 
            // Modificar_button2
            // 
            this.Modificar_button2.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Modificar_button2.Image = global::VISTA.Properties.Resources.curriculum1;
            this.Modificar_button2.Location = new System.Drawing.Point(271, 252);
            this.Modificar_button2.Name = "Modificar_button2";
            this.Modificar_button2.Size = new System.Drawing.Size(91, 34);
            this.Modificar_button2.TabIndex = 15;
            this.Modificar_button2.Text = "Modificar";
            this.Modificar_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Modificar_button2.UseVisualStyleBackColor = true;
            this.Modificar_button2.Click += new System.EventHandler(this.Modificar_button2_Click);
            // 
            // Nuevo_button1
            // 
            this.Nuevo_button1.Font = new System.Drawing.Font("MS PGothic", 9.75F);
            this.Nuevo_button1.Image = global::VISTA.Properties.Resources.nuevo__1_;
            this.Nuevo_button1.Location = new System.Drawing.Point(174, 252);
            this.Nuevo_button1.Name = "Nuevo_button1";
            this.Nuevo_button1.Size = new System.Drawing.Size(91, 34);
            this.Nuevo_button1.TabIndex = 14;
            this.Nuevo_button1.Text = "Nuevo";
            this.Nuevo_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Nuevo_button1.UseVisualStyleBackColor = true;
            this.Nuevo_button1.Click += new System.EventHandler(this.Nuevo_button1_Click);
            // 
            // AdjuntarFoto_button
            // 
            this.AdjuntarFoto_button.Enabled = false;
            this.AdjuntarFoto_button.Image = global::VISTA.Properties.Resources.lupa;
            this.AdjuntarFoto_button.Location = new System.Drawing.Point(511, 171);
            this.AdjuntarFoto_button.Name = "AdjuntarFoto_button";
            this.AdjuntarFoto_button.Size = new System.Drawing.Size(38, 36);
            this.AdjuntarFoto_button.TabIndex = 13;
            this.AdjuntarFoto_button.UseVisualStyleBackColor = true;
            this.AdjuntarFoto_button.Click += new System.EventHandler(this.AdjuntarFoto_button_Click);
            // 
            // FotoUsuario_pictureBox1
            // 
            this.FotoUsuario_pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.FotoUsuario_pictureBox1.Location = new System.Drawing.Point(439, 12);
            this.FotoUsuario_pictureBox1.Name = "FotoUsuario_pictureBox1";
            this.FotoUsuario_pictureBox1.Size = new System.Drawing.Size(172, 151);
            this.FotoUsuario_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoUsuario_pictureBox1.TabIndex = 12;
            this.FotoUsuario_pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.Usuarios_dataGridView1);
            this.Controls.Add(this.Cancelar_button5);
            this.Controls.Add(this.Eliminar_button4);
            this.Controls.Add(this.Guardar_button3);
            this.Controls.Add(this.Modificar_button2);
            this.Controls.Add(this.Nuevo_button1);
            this.Controls.Add(this.AdjuntarFoto_button);
            this.Controls.Add(this.FotoUsuario_pictureBox1);
            this.Controls.Add(this.EstaActivo_checkBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rol_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Correo_textBox);
            this.Controls.Add(this.Contra_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Codigo_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UsuariosForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Usuarios_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoUsuario_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre_textBox1;
        private System.Windows.Forms.TextBox Codigo_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contra_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Correo_textBox;
        private System.Windows.Forms.ComboBox Rol_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox EstaActivo_checkBox;
        private System.Windows.Forms.PictureBox FotoUsuario_pictureBox1;
        private System.Windows.Forms.Button AdjuntarFoto_button;
        private System.Windows.Forms.Button Nuevo_button1;
        private System.Windows.Forms.Button Modificar_button2;
        private System.Windows.Forms.Button Guardar_button3;
        private System.Windows.Forms.Button Eliminar_button4;
        private System.Windows.Forms.Button Cancelar_button5;
        private System.Windows.Forms.DataGridView Usuarios_dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}