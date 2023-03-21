using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace VISTA
{
    public partial class ClientesForm : Syncfusion.Windows.Forms.Office2007Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        //VARIBALE GLOBAL
        string tipoOperacion;//GUARDARA EL VALOR DE "NUEVO" O "MODIFICAR" PARA SABER QUE BOTON PRESIONO EL USUARIO
        DataTable dt = new DataTable();//Recibira el metodo de "DevolverUsuarios"
        ClienteDB clienteDB = new ClienteDB();//Lo ejecutaremos desde varios lugares
        Cliente cliente = new Cliente();//Se lo pasamos a la BD

        //NOS PERMITIRA HABILITAR LOS CONTROLES DESHABILITADOS  AL DARLE NUEVO
        private void habilitarControles()
        {
            Identidad_textBox.Enabled = true;
            Nombre_textBox.Enabled = true;
            Telefono_textBox.Enabled = true;
            Correo_textBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            EstaActivo_checkBox.Enabled = true;
            FechaNacimientodateTimePicker.Enabled = true;
            Guardar_button.Enabled = true;
            Cancelar_button.Enabled = true;
            Modificar_button.Enabled = false;
        }
        private void DeshabilitarControles()
        {
            Identidad_textBox.Enabled = false;
            Nombre_textBox.Enabled = false;
            Telefono_textBox.Enabled = false;
            Correo_textBox.Enabled = false;
            DirecciontextBox.Enabled = false;
            EstaActivo_checkBox.Enabled = false;
            Guardar_button.Enabled = false;
            Cancelar_button.Enabled = false;
            Modificar_button.Enabled = true;
            FechaNacimientodateTimePicker.Enabled = false;
        }
        private void LimpiarControles()
        {
            Identidad_textBox.Clear();
            Nombre_textBox.Clear();
            Telefono_textBox.Clear();
            Correo_textBox.Clear();
            DirecciontextBox.Text = string.Empty;
            EstaActivo_checkBox.Checked = false;
            FechaNacimientodateTimePicker.Value = DateTime.Today;


        }
        private void Nuevo_button_Click(object sender, EventArgs e)
        {

            Identidad_textBox.Focus();//ASI EL MOUSE SE IRA AL APARTADO QUE QUERRAMOS Y EL UUARIO NO TENDRA QUE MOVERLO, SE PASA AUTOMATICO
            habilitarControles();
            tipoOperacion = "Nuevo";//SABRA QUE EL USUARIO DIO CLIC AL BOTON NUEVO
        }
        private void Cancelar_button_Click(object sender, EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }
        private void Guardar_button_Click(object sender, EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                DateTime FechaNacimiento = FechaNacimientodateTimePicker.Value;
                //VALIADADNO QUE LOS TEXTBOX ESTEN LLENOS
                if (string.IsNullOrEmpty(Identidad_textBox.Text))
                {
                    errorProvider2.SetError(Identidad_textBox, "INGRESE UNA IDENTIDAD");
                    return;
                }
                errorProvider2.Clear();
                if (string.IsNullOrEmpty(Nombre_textBox.Text))
                {
                    errorProvider2.SetError(Nombre_textBox, "INGRESE UN NOMBRE");
                    return;
                }
                errorProvider2.Clear();
                if (string.IsNullOrEmpty(Telefono_textBox.Text))
                {
                    errorProvider2.SetError(Telefono_textBox, "INGRESE UN TELEFONO");
                    return;
                }
                errorProvider2.Clear();
                if (string.IsNullOrEmpty(DirecciontextBox.Text))
                {
                    errorProvider2.SetError(DirecciontextBox, "INGRESE UNA DIRECCION");
                    return;
                }
                errorProvider2.Clear();
                if (string.IsNullOrEmpty(Convert.ToString(FechaNacimiento))) 
                {
                    errorProvider2.SetError(FechaNacimientodateTimePicker, "INGRESE UNA FECHA");
                    return;
                }
                errorProvider2.Clear();


                // TODO ESTO SE PASARA A UNA LISTA Y LUEGO SE PASA AL DATAGRIDVIEW 
                cliente.IdentidadCliente = Identidad_textBox.Text;
                cliente.Nombre = Nombre_textBox.Text;
                cliente.Telefono = Telefono_textBox.Text;
                cliente.Correo = Correo_textBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                cliente.EstaActivo = EstaActivo_checkBox.Checked;/*EL CHECKED ES PARA VER SI ESTA ACTIVO Y LE MANDA
                                                                 UN TRUE SI, SI O UN FLASE SINO.*/

                //Validadno que se ingreso un registro a la BD
                bool inserto = clienteDB.InsertarCliente(cliente);//Si "inserto" trae un ture es porque si hay usuario nuevo
                if (inserto)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerCliente();
                    MessageBox.Show("CLIENTE GUARDADO SATISFACTORIAMENTE");
                }
                else
                {
                    MessageBox.Show("CLIENTE NO GUARDADO ");

                }


            }
            else if (tipoOperacion == "Modificar")
            {
                // TODO ESTO SE PASARA A UNA LISTA Y LUEGO SE PASA AL DATAGRIDVIEW 
                cliente.IdentidadCliente = Identidad_textBox.Text;
                cliente.Nombre = Nombre_textBox.Text;
                cliente.Telefono = Telefono_textBox.Text;
                cliente.Correo = Correo_textBox.Text;
                cliente.Direccion = DirecciontextBox.Text;
                cliente.FechaNacimiento = FechaNacimientodateTimePicker.Value;
                cliente.EstaActivo = EstaActivo_checkBox.Checked;/*EL CHECKED ES PARA VER SI ESTA ACTIVO Y LE MANDA
                                                                 UN TRUE SI, SI O UN FLASE SINO.*/


                bool modifico = clienteDB.EditarCliente(cliente);
                if (modifico)
                {
                    LimpiarControles();
                    DeshabilitarControles();
                    TraerCliente();
                    MessageBox.Show("REGSITRO ACTUALIZADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("ERROR AL ACTUALIZAR DATOS");
                }

            }
        }
        private void Modificar_button_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";//SABRA QUE EL USUARIO DIO CLIC AL BOTON MODIFICAR
            if (Clientes_dataGridView.SelectedRows.Count > 0)//Si el usuario slecciono una fila para modificar
            {
                //Pasamos lo que tiene la celda "Codigo Usuario" al textbox que le corresponde
                Identidad_textBox.Text = Clientes_dataGridView.CurrentRow.Cells["IdentidadCliente"].Value.ToString();
                Nombre_textBox.Text = Clientes_dataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                Telefono_textBox.Text = Clientes_dataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                DirecciontextBox.Text = Clientes_dataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                Correo_textBox.Text = Clientes_dataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                FechaNacimientodateTimePicker.Value = Convert.ToDateTime(Clientes_dataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                EstaActivo_checkBox.Checked = Convert.ToBoolean(Clientes_dataGridView.CurrentRow.Cells["EstaActivo"].Value);
                habilitarControles();

               // string fechaNacimientoString = Clientes_dataGridView.CurrentRow.Cells["FechaNacimiento"].Value.ToString();//Guarda en la variable lo que tiene la celda
                //DateTime fechaNacimiento = DateTime.ParseExact(fechaNacimientoString, "dd/MM/yyyy", CultureInfo.InvariantCulture);//con el metodo "ParseExact", analizo la cadena de texto "fechaNacimientoString" y convertirla en un objeto DateTime.
                //FechaNacimientodateTimePicker.Value = fechaNacimiento;

            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR UN REGISTRO");
            }
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            TraerCliente();
        }
        private void TraerCliente()
        {
            dt = clienteDB.DevolverClientes();//Pasando clientes al dt
            Clientes_dataGridView.DataSource = dt;//Mostramos los datos con el DataSource en el DGV

        }
        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            if (Clientes_dataGridView.SelectedRows.Count > 0)
            {

                DialogResult resultado = MessageBox.Show("ESTA SEGURO QUE DESEA ELIMINAR EL REGISTRO", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    bool elimino = clienteDB.Eliminar(Clientes_dataGridView.CurrentRow.Cells["IdentidadCliente"].Value.ToString());
                    if (elimino)
                    {
                        LimpiarControles();
                        DeshabilitarControles();
                        TraerCliente();
                        MessageBox.Show("REGISTRO DE CLIENTE ELIMINADO");
                    }
                    else
                    {
                        MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO DE CLIENTE");
                    }
                }

            }
            else
            {
                MessageBox.Show("NO SE PUDO ELIMINAR EL REGISTRO DE CLIENTE");
            }

        }

       
    }
    

       

        
}