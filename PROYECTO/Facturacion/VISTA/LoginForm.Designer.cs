namespace VISTA
{
    partial class LoginForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.USUARIOtextBox = new System.Windows.Forms.TextBox();
            this.CONTRAtextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MostrarContra_button = new System.Windows.Forms.Button();
            this.ACEPTARbutton = new System.Windows.Forms.Button();
            this.CANCELAR_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // USUARIOtextBox
            // 
            this.USUARIOtextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIOtextBox.Location = new System.Drawing.Point(140, 46);
            this.USUARIOtextBox.Name = "USUARIOtextBox";
            this.USUARIOtextBox.Size = new System.Drawing.Size(222, 23);
            this.USUARIOtextBox.TabIndex = 4;
            // 
            // CONTRAtextBox
            // 
            this.CONTRAtextBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTRAtextBox.Location = new System.Drawing.Point(140, 97);
            this.CONTRAtextBox.Name = "CONTRAtextBox";
            this.CONTRAtextBox.PasswordChar = '*';
            this.CONTRAtextBox.Size = new System.Drawing.Size(222, 23);
            this.CONTRAtextBox.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MostrarContra_button
            // 
            this.errorProvider1.SetIconAlignment(this.MostrarContra_button, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.MostrarContra_button.Image = global::VISTA.Properties.Resources.ver;
            this.MostrarContra_button.Location = new System.Drawing.Point(368, 97);
            this.MostrarContra_button.Name = "MostrarContra_button";
            this.MostrarContra_button.Size = new System.Drawing.Size(33, 26);
            this.MostrarContra_button.TabIndex = 7;
            this.MostrarContra_button.UseVisualStyleBackColor = true;
            this.MostrarContra_button.Click += new System.EventHandler(this.MostrarContra_button_Click);
            // 
            // ACEPTARbutton
            // 
            this.ACEPTARbutton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACEPTARbutton.Image = global::VISTA.Properties.Resources.cheque;
            this.ACEPTARbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ACEPTARbutton.Location = new System.Drawing.Point(98, 150);
            this.ACEPTARbutton.Name = "ACEPTARbutton";
            this.ACEPTARbutton.Size = new System.Drawing.Size(108, 37);
            this.ACEPTARbutton.TabIndex = 0;
            this.ACEPTARbutton.Text = "ACEPTAR";
            this.ACEPTARbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ACEPTARbutton.UseVisualStyleBackColor = true;
            this.ACEPTARbutton.Click += new System.EventHandler(this.ACEPTARbutton_Click);
            // 
            // CANCELAR_button
            // 
            this.CANCELAR_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CANCELAR_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCELAR_button.Image = global::VISTA.Properties.Resources.boton_x;
            this.CANCELAR_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CANCELAR_button.Location = new System.Drawing.Point(228, 150);
            this.CANCELAR_button.Name = "CANCELAR_button";
            this.CANCELAR_button.Size = new System.Drawing.Size(108, 37);
            this.CANCELAR_button.TabIndex = 1;
            this.CANCELAR_button.Text = "CANCELAR";
            this.CANCELAR_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CANCELAR_button.UseVisualStyleBackColor = true;
            this.CANCELAR_button.Click += new System.EventHandler(this.CANCELAR_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::VISTA.Properties.Resources.silueta_de_multiples_usuarios;
            this.pictureBox1.Location = new System.Drawing.Point(431, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.ACEPTARbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CANCELAR_button;
            this.ClientSize = new System.Drawing.Size(652, 238);
            this.ControlBox = false;
            this.Controls.Add(this.MostrarContra_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CONTRAtextBox);
            this.Controls.Add(this.USUARIOtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CANCELAR_button);
            this.Controls.Add(this.ACEPTARbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ACEPTARbutton;
        private System.Windows.Forms.Button CANCELAR_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox USUARIOtextBox;
        private System.Windows.Forms.TextBox CONTRAtextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button MostrarContra_button;
    }
}

