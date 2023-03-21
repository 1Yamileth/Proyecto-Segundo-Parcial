using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }
        ClienteDB clienteDB= new ClienteDB();
        public Cliente cliente= new Cliente();//Nos ayudara a devolver cuando demos clic en aceptar, lo llevamos de este form al form factura
        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            ClientesdataGridView.DataSource= clienteDB.DevolverClientes();//los clientes en el data 
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            //Mandaremos nuestro objeto cliente dependiendo de lo que el cliente escoja
            if (ClientesdataGridView.SelectedRows.Count>0)//Si ha seleccionado un valor
            {
                cliente.IdentidadCliente = ClientesdataGridView.CurrentRow.Cells["IdentidadCliente"].Value.ToString();
                cliente.Nombre = ClientesdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
                cliente.Telefono = ClientesdataGridView.CurrentRow.Cells["Telefono"].Value.ToString();
                cliente.Correo = ClientesdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
                cliente.Direccion = ClientesdataGridView.CurrentRow.Cells["Direccion"].Value.ToString();
                cliente.FechaNacimiento = Convert.ToDateTime(ClientesdataGridView.CurrentRow.Cells["FechaNacimiento"].Value);
                cliente.EstaActivo = Convert.ToBoolean(ClientesdataGridView.CurrentRow.Cells["EstaActivo"].Value);
                this.Close();

            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombretextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //  SE ACTIVA CUANDO EL USUARIO DEJA DE RESIONAR LA TECLA
            //LLAMAREMOS AL METODO DEVOLVER USUARIO POR NOMBRE
            ClientesdataGridView.DataSource = clienteDB.DevolverClientesPorNombres(NombretextBox.Text);//LE PASAMOS LO QUE ESCRIBA EL USUARIO
        }
    }
}
