using Datos;
using Entidades;
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
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2007Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        //VARIBALE GLOBAL
        string tipoOperacion;//GUARDARA EL VALOR DE "NUEVO" O "MODIFICAR" PARA SABER QUE BOTON PRESIONO EL USUARIO
        DataTable dt = new DataTable();//Recibira el metodo de "DevolverUsuarios"
        UsuarioDB UsuarioDB = new UsuarioDB();//Lo ejecutaremos desde avrios lugares
        Usuario user = new Usuario();//Se lo pasamos a la BD

        //NOS PERMITIRA HABILITAR LOS CONTROLES DESHABILITADOS  AL DARLE NUEVO
        private void habilitarControles()
        {
            Codigo_textBox.Enabled = true;
            Nombre_textBox1.Enabled = true;
            Contra_textBox.Enabled = true;
            Correo_textBox.Enabled = true;
            Rol_comboBox.Enabled = true;
            EstaActivo_checkBox.Enabled = true;
            AdjuntarFoto_button.Enabled = true;
            Guardar_button3.Enabled = true;
            Cancelar_button5.Enabled = true;
            Modificar_button2.Enabled = false;


        }
        //NOS PERMITIRA DESHABILITAR LOS CONTROLES HABILITADOS AL DARLE CANCELAR
        private void DeshabilitarControles()
        {
            Codigo_textBox.Enabled = false;
            Nombre_textBox1.Enabled = false;
            Contra_textBox.Enabled = false;
            Correo_textBox.Enabled = false;
            Rol_comboBox.Enabled = false;
            EstaActivo_checkBox.Enabled = false;
            AdjuntarFoto_button.Enabled = false;
            Guardar_button3.Enabled = false;
            Cancelar_button5.Enabled = false;
            Modificar_button2.Enabled = true ;



        }
        //LIMPIARA TODOS LOS CONTROLES 
        private void LimpiarControles()
        {
            Codigo_textBox.Clear();
            Nombre_textBox1.Clear();
            Contra_textBox.Clear();
            Correo_textBox.Clear();
            Rol_comboBox.Text = string.Empty;
            EstaActivo_checkBox.Checked = false;
            FotoUsuario_pictureBox1.Image= null;//ASI LE PONEMO UN VALOR NULL A LA PARTE DE LA IMAGEN


        }
        private void Nuevo_button1_Click(object sender, EventArgs e)
        {
            
            Codigo_textBox.Focus();//ASI EL MOUSE SE IRA AL APARTADO QUE QUERRAMOS Y EL UUARIO NO TENDRA QUE MOVERLO, SE PASA AUTOMATICO
            habilitarControles();
            tipoOperacion = "Nuevo";//SABRA QUE EL USUARIO DIO CLIC AL BOTON NUEVO
        }
       
        private void Cancelar_button5_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void Guardar_button3_Click(object sender, EventArgs e)
        {
            if (tipoOperacion=="Nuevo")
            {    //VALIADADNO QUE LOS TEXTBOX ESTEN LLENOS
                if (string.IsNullOrEmpty(Codigo_textBox.Text))
                {
                    errorProvider1.SetError(Codigo_textBox, "INGRESE EL CODIGO");
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Nombre_textBox1.Text))
                {
                    errorProvider1.SetError(Nombre_textBox1, "INGRESE EL NOMBRE");
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Contra_textBox.Text))
                {
                    errorProvider1.SetError(Contra_textBox, "INGRESE UNA CONTRASEÑA");
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(Rol_comboBox.Text))
                {
                    errorProvider1.SetError(Rol_comboBox, "SELECCIONE UN ROL");
                    return;
                }
                errorProvider1.Clear();

               
                // TODO ESTO SE PASARA A UNA LISTA Y LUEGO SE PASA AL DATAGRIDVIEW 
                user.CodigoUsuario = Codigo_textBox.Text;
                user.Nombre = Nombre_textBox1.Text;
                user.Contraseña = Contra_textBox.Text;
                user.Rol = Rol_comboBox.Text; 
                user.Correo = Correo_textBox.Text;
                user.EstadoActivo = EstaActivo_checkBox.Checked;/*EL CHECKED ES PARA VER SI ESTA ACTIVO Y LE MANDA
                                                                 UN TRUE SI, SI O UN FLASE SINO.*/
                //MANDAR LA FOTO AL USER 
                if (FotoUsuario_pictureBox1.Image !=   null)
                {
                   System.IO.MemoryStream pasandoFoto = new System.IO.MemoryStream();/*INSTANCIANDO UN OBJETO DE LA CLASE MEMORY STREAM.
                                                                              SIRVE PARA ARCHIVOS EN GENERAL*/
                    FotoUsuario_pictureBox1.Image.Save(pasandoFoto, System.Drawing.Imaging.ImageFormat.Jpeg); //CON EL METODO "SAVE" LE ESTAMOS PASANDO EL ARCHIVO AL OBJETO ANTERIOR INSTANCIADO
                    user.Foto = pasandoFoto.GetBuffer();/*ESTE METODO DEVUELVE LA MATRIZ DE BYTE DEL MEMORY STRING */   

                }

                //Validadno que se ingreso un registro a la BD
                bool inserto = UsuarioDB.Insertar(user);//Si "inserto" trae un ture es porque si hay usuario nuevo
                if (inserto)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuario();
                    MessageBox.Show("Registro Guardado Satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("Registro No Guardado ");

                }


            }
            else if (tipoOperacion == "Modificar")
            {
                // TODO ESTO SE PASARA A UNA LISTA Y LUEGO SE PASA AL DATAGRIDVIEW 
                user.CodigoUsuario = Codigo_textBox.Text;
                user.Nombre = Nombre_textBox1.Text;
                user.Contraseña = Contra_textBox.Text;
                user.Rol = Rol_comboBox.Text;
                user.Correo = Correo_textBox.Text;
                user.EstadoActivo = EstaActivo_checkBox.Checked;/*EL CHECKED ES PARA VER SI ESTA ACTIVO Y LE MANDA
                                                                 UN TRUE SI, SI O UN FLASE SINO.*/
                //MANDAR LA FOTO AL USER 
                if (FotoUsuario_pictureBox1.Image != null)
                {
                    System.IO.MemoryStream pasandoFoto = new System.IO.MemoryStream();/*INSTANCIANDO UN OBJETO DE LA CLASE MEMORY STREAM.
                                                                              SIRVE PARA ARCHIVOS EN GENERAL*/
                    FotoUsuario_pictureBox1.Image.Save(pasandoFoto, System.Drawing.Imaging.ImageFormat.Jpeg); //CON EL METODO "SAVE" LE ESTAMOS PASANDO EL ARCHIVO AL OBJETO ANTERIOR INSTANCIADO
                    user.Foto = pasandoFoto.GetBuffer();/*ESTE METODO DEVUELVE LA MATRIZ DE BYTE DEL MEMORY STRING */

                }

                bool modifico = UsuarioDB.EditarUsuario(user);
                if (modifico)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerUsuario();
                    MessageBox.Show("REGSITRO ACTUALIZADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR AL ACTUALIZAR DATOS");
                }

            }
        }

        private void Modificar_button2_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";//SABRA QUE EL USUARIO DIO CLIC AL BOTON MODIFICAR
            if (Usuarios_dataGridView1.SelectedRows.Count>0)//Si el usuario slecciono una fila para modificar
            {
                //Pasamos lo que tiene la celda "Codigo Usuario" al textbox que le corresponde
                Codigo_textBox.Text = Usuarios_dataGridView1.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
                Nombre_textBox1.Text = Usuarios_dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                Contra_textBox.Text = Usuarios_dataGridView1.CurrentRow.Cells["Contrasena"].Value.ToString();
                Correo_textBox.Text = Usuarios_dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                Rol_comboBox.Text = Usuarios_dataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
                EstaActivo_checkBox.Checked =  Convert.ToBoolean(Usuarios_dataGridView1.CurrentRow.Cells["EstadoActivo"].Value) ;

                byte[] miFoto = UsuarioDB.DevolverFoto(Usuarios_dataGridView1.CurrentRow.Cells["CodigoUsuario"].Value.ToString());//Le pasamos el codigo de usuraio oara que sepa de que usuario es
                
                if (miFoto.Length>0)//Validamos si el usuario no tiene foto, el usario devolveria un 0
                {
                    MemoryStream ms = new MemoryStream(miFoto);
                    FotoUsuario_pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                }


                habilitarControles();

            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
            }
        }

        private void AdjuntarFoto_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();//ABRIRA UNA VENTANA PARA SACAR EL ARCHIVO
            DialogResult resultado = foto.ShowDialog();/*dialog result captra es imagen.
                                                        LE ESTAMOS PASANDO LO QUE EL USUARIO CAPTURO EN LA VENTANA*/

            //SOLO SI SELECCIONO UNA IMAGEN SE ABIRA ESTE IF
            if(resultado == DialogResult.OK)//SI FUE SATISTACTORIA LA BUSQUEDA
            {
                FotoUsuario_pictureBox1.Image = Image.FromFile(foto.FileName);/*from file, es de donde tomaremos el archivo y lo tomaremos
                                                                               del objeto "foto" y file name e para capturar el nombre de archivo*/
            }

        }


        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            TraerUsuario();

        }

        //METODO
        private void TraerUsuario()
        {
            dt = UsuarioDB.DevolverUsuarios();//Pasando usuarios al dt
            Usuarios_dataGridView1.DataSource = dt;//Mostramos los datos con el DataSource en el DGV
        
        }

        private void Eliminar_button4_Click(object sender, EventArgs e)
        {
            if (Usuarios_dataGridView1.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = UsuarioDB.Eliminar(Usuarios_dataGridView1.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerUsuario();
                        MessageBox.Show("REGISTRO ELIMINADO");
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO");
            }
        }
    }

}
