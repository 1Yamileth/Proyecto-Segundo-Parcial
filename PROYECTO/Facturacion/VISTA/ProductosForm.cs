using Datos;
using Entidades;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace VISTA
{
    public partial class ProductosForm : Syncfusion.Windows.Forms.Office2007Form
    {
        public ProductosForm()
        {
            InitializeComponent();
        }
        //VARIBALE GLOBAL
        string operacion;
        Producto producto;
        ProductoDB productoDB = new ProductoDB();
        

        //HABLITAR CONTROLES
        private void habilitarControles()
        {
            CodigoProducto_textBox1.Enabled = true;
            Descripcion_textBox1.Enabled = true;
            Existencia_textBox2.Enabled = true;
            Precio_textBox1.Enabled = true;
            AdjuntarImagen_button1.Enabled = true;
            Guardar_button3.Enabled = true;
            Cancelar_button5.Enabled = true;
            EstaActivo_checkBox.Enabled = true;
            Nuevo_button1.Enabled = false;

        }

        private void LimpiarControles()
        {

            CodigoProducto_textBox1.Clear();
            Descripcion_textBox1.Clear();
;           Existencia_textBox2.Clear();
            Precio_textBox1.Clear();
            EstaActivo_checkBox.Checked = false;
            ImagenProduct_pictureBox1.Image = null;
            producto = null;

            
        }
        //DESHABLITAR CONTROLES
        private void DeshabilitarControles()
        {
            CodigoProducto_textBox1.Enabled = false;
            Descripcion_textBox1.Enabled = false;
            Existencia_textBox2.Enabled = false;
            Precio_textBox1.Enabled = false;
            EstaActivo_checkBox.Enabled = false;
            AdjuntarImagen_button1.Enabled = false;
            Guardar_button3.Enabled = false;
            Cancelar_button5.Enabled = false;
            Nuevo_button1.Enabled = true;

        }

        private void Cancelar_button5_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }
        private void Nuevo_button1_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            habilitarControles();
        }

        private void Modificar_button2_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (Productos_dataGridView1.SelectedRows.Count>0)
            {
                CodigoProducto_textBox1.Text = Productos_dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                Descripcion_textBox1.Text = Productos_dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                Existencia_textBox2.Text = Productos_dataGridView1.CurrentRow.Cells["Existencia"].Value.ToString();
                Precio_textBox1.Text = Productos_dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                EstaActivo_checkBox.Checked = Convert.ToBoolean(Productos_dataGridView1.CurrentRow.Cells["EstaActivo"].Value);

                byte[] img = productoDB.DevolverFoto(Productos_dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                if (img.Length>0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    ImagenProduct_pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                }
                habilitarControles();
                CodigoProducto_textBox1.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
            }
        }

        private void Guardar_button3_Click(object sender, EventArgs e)
        {
            producto = new Producto();//Instanciacion
            //LO PONEMOS ACA PARA QUE NO DUPLIQUEMOS CODIGO
            //ACCEDERA A LA PROPIEDAD DEL OBJETO "PRODUCTO" Y LE INGRESARA LOS DATOS DE LOS TEXTBOX
            producto.CodigoProducto = CodigoProducto_textBox1.Text;
            producto.Descripcion = Descripcion_textBox1.Text;
            producto.Precio = Convert.ToDecimal(Precio_textBox1.Text);
            producto.Existencia = Convert.ToInt32(Existencia_textBox2.Text);
            producto.EstaActivo = EstaActivo_checkBox.Checked;

            if (ImagenProduct_pictureBox1.Image != null)
            {
                System.IO.MemoryStream pasandoFoto = new System.IO.MemoryStream();/*INSTANCIANDO UN OBJETO DE LA CLASE MEMORY STREAM.
                                                                              SIRVE PARA ARCHIVOS EN GENERAL*/
                ImagenProduct_pictureBox1.Image.Save(pasandoFoto, System.Drawing.Imaging.ImageFormat.Jpeg); //CON EL METODO "SAVE" LE ESTAMOS PASANDO EL ARCHIVO AL OBJETO ANTERIOR INSTANCIADO
                producto.Foto = pasandoFoto.GetBuffer();/*ESTE METODO DEVUELVE LA MATRIZ DE BYTE DEL MEMORY STRING */

            }
            if (operacion=="Nuevo")
            {
                //VALIDACION DE LOS ESPACIOS VACIOS
                if (string.IsNullOrEmpty(CodigoProducto_textBox1.Text))
                {
                    errorProvider1.SetError(CodigoProducto_textBox1, "INGRESE UN CODIGO DE PRODUCTO");
                    CodigoProducto_textBox1.Focus();//MANDANDO EL FOCO A EL TEXTBOX DEL CODIGO
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Descripcion_textBox1.Text))
                {
                    errorProvider1.SetError(Descripcion_textBox1, "INGRESE UNA DESCRIPCION DE PRODUCTO");
                    Descripcion_textBox1.Focus();//MANDANDO EL FOCO A EL TEXTBOX DEL CODIGO
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Existencia_textBox2.Text))
                {
                    errorProvider1.SetError(Existencia_textBox2, "INGRESE LA EXISTENCIA DEL PRODUCTO");
                    Existencia_textBox2.Focus();//MANDANDO EL FOCO A EL TEXTBOX DEL CODIGO
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Precio_textBox1.Text))
                {
                    errorProvider1.SetError(Precio_textBox1, "INGRESE EL PRECIO DE PRODUCTO");
                    Precio_textBox1.Focus();//MANDANDO EL FOCO A EL TEXTBOX DEL CODIGO
                    return;
                }
                errorProvider1.Clear();
               

                bool inserto = productoDB.Insertar(producto);
                if (inserto)
                {
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("PRODUCTO REGISTRADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PRODUCTO NO REGISTRADO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else if (operacion=="Modificar")
            {
                bool modifico = productoDB.Editar(producto);
                if (modifico)
                {
                    CodigoProducto_textBox1.ReadOnly = false;
                    DeshabilitarControles();
                    LimpiarControles();
                    TraerProductos();
                    MessageBox.Show("PRODUCTO ACTUALIZADO CON EXITO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("PRODUCTO NO ACTUALIZADO", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        //NO INGRESARA LETRAS
        private void Existencia_textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsNumber(e.KeyChar))//ESTAMOS DANDO A ENTENDER QUE SI EL CARACTER "E" NO ES UN NUMERO 
            {
                e.Handled = true;//CANCELA LO QUE TRAE SI NO ES UN NUMERO
            }
        }

        private void Precio_textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && e.KeyChar != '\b')/*DIGIT, ENGLOBA LO QUE ES DECIMAL, YA QUE ES PRECIO
                                                              CON LA SEGUNDA VALIDACION ESTMAOS VALIDNAOD QUE DEJE INGRESAR PUNTOS*/
            {
                e.Handled = true;
            }


            if ((e.KeyChar=='.')  && (sender as TextBox).Text.IndexOf('.') > -1)/*CON EL "AS" ESTAMOS CONVIRTIENDO A TEXTBOX.
                                                                     CON EL "INDEXOF" CAPTURA EL TIPO DE CARACTER Y NO DEJARA AGREGAR OTRO PUNTO*/
            {
                e.Handled = true;
            }
        }

        private void AdjuntarImagen_button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();//ABRIRA UNA VENTANA PARA SACAR EL ARCHIVO
            DialogResult resultado = foto.ShowDialog();/*dialog result captra es imagen.
                                                        LE ESTAMOS PASANDO LO QUE EL USUARIO CAPTURO EN LA VENTANA*/

            //SOLO SI SELECCIONO UNA IMAGEN SE ABIRA ESTE IF
            if (resultado == DialogResult.OK)//SI FUE SATISTACTORIA LA BUSQUEDA
            {
                ImagenProduct_pictureBox1.Image = Image.FromFile(foto.FileName);/*from file, es de donde tomaremos el archivo y lo tomaremos
                                                                               del objeto "foto" y file name e para capturar el nombre de archivo*/
            }

        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            TraerProductos();
        }

        private void TraerProductos()
        {
            Productos_dataGridView1.DataSource = productoDB.DevolverProductos();
        }

        private void Eliminar_button4_Click(object sender, EventArgs e)
        {
            if (Productos_dataGridView1.SelectedRows.Count>0)
            {
                DialogResult resultado = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = productoDB.Eliminar(Productos_dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerProductos();
                        MessageBox.Show("REGISTRO ELIMINADO");
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO");
                    }
                }

            }
        }
    }
}
