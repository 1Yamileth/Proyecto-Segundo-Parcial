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
    public partial class NuevaFacturaForm : Syncfusion.Windows.Forms.Office2007Form
    {
        public NuevaFacturaForm()
        {
            InitializeComponent();
        }

       
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        Producto miProducto = null;
        ProductoDB productoDB = new ProductoDB();
        List<DetalleFactura> listaDetalle = new List<DetalleFactura>();
        FacturaDB facturaDB= new FacturaDB();
        decimal subtotal = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;
        decimal descuento = 0;

        private void Id_ClientetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {//Buscamos el cliente por identidad
            if (e.KeyChar== (char)Keys.Enter && !string.IsNullOrEmpty(Id_ClientetextBox.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorId(Id_ClientetextBox.Text);//Le pasamos la identidad que esta en CLIENTEDB a MICLIENTE
                ClienteNombretextBox.Text = miCliente.Nombre;
;
            }
            else
            {//Si algo sale mal, el objeto sale nulo y limpiamos el textbox donde se muestran los nombres
                miCliente = null;
                ClienteNombretextBox.Clear();
            }
        }

        private void BusquedaIdbutton_Click(object sender, EventArgs e)
        {
            BuscarCliente form = new BuscarCliente();
            form.ShowDialog();//Nos permite mostrar el form en cuadro de dialogo, mientras este activo no se podra
                              // hacer nada, a menos que lo cerremos.
            miCliente = new Cliente();
            miCliente = form.cliente;
            //Le pasamos los datos del cliente
            Id_ClientetextBox.Text = miCliente.IdentidadCliente;
            ClienteNombretextBox.Text = miCliente.Nombre;
                
        }
        private void NuevaFacturaForm_Load(object sender, EventArgs e)
        {
            //Le pasamos el codigo de usuario, al textbox correspondiente, asi en factura saldra
            Usuario_textBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;

        }

        private void CodigoProductotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Buscamos el producto por codigo
                if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigoProductotextBox.Text))
                {
                    miProducto = new Producto();
                    miProducto = productoDB.DevolverProductoPorCodigo(CodigoProductotextBox.Text);
                    DescripcionProductotextBox.Text = miProducto.Descripcion;//FALLA
                    ExistenciatextBox.Text = miProducto.Existencia.ToString();

                }
                else
                {//Si algo sale mal, el objeto sale nulo y limpiamos el textbox donde se muestran los nombres
                    miProducto = null;
                    DescripcionProductotextBox.Clear();
                    ExistenciatextBox.Clear();
                }
            }
            catch (Exception)
            {
            }
            
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProductoForm form = new BuscarProductoForm();
            form.ShowDialog();
            miProducto = new Producto();
            miProducto = form.producto;//LE ESTAMOS PASANDO EL OBJETO PUBLICO DEL FORMULARIO PRODUCTO
            CodigoProductotextBox.Text = miProducto.CodigoProducto;
            DescripcionProductotextBox.Text = miProducto.Descripcion;
            ExistenciatextBox.Text = miProducto.Existencia.ToString();
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                //CAMBIANO LA REGIN ASI NO TENDRE PROBLEMAS CON LOS .000
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

                DetalleFactura detalle = new DetalleFactura();
                detalle.CodigoProducto = miProducto.CodigoProducto;
                detalle.Cantidad = Convert.ToInt32 (CantidadtextBox.Text);
                detalle.Precio = Convert.ToDecimal(miProducto.Precio);
                detalle.Total = Convert.ToInt32(CantidadtextBox.Text) * miProducto.Precio;
                detalle.Descripcion = miProducto.Descripcion;

                subtotal += detalle.Total;
                isv = subtotal * 0.15M;
                totalAPagar = subtotal + isv - descuento;

                listaDetalle.Add(detalle);
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = listaDetalle;//PASANDO LA LISTA DE LOS DETALLES DE PRODUCTOS

                SubtotaltextBox.Text = subtotal.ToString();
                isvtextBox.Text = isv.ToString();
                TotaltextBox.Text = totalAPagar.ToString();

                //LIMPIEZA
                miProducto = null;
                CodigoProductotextBox.Clear();
                DescripcionProductotextBox.Clear();
                ExistenciatextBox.Clear();
                CantidadtextBox.Clear();
                CodigoProductotextBox.Focus();

            }
        }

        private void GuardarFacturabutton_Click(object sender, EventArgs e)
        {
            //INGRESAR LOS ERRORES


            Factura mifactura = new Factura();
            mifactura.FechaFactura = FechadateTimePicker.Value;
            mifactura.CodigoUsuario= System.Threading.Thread.CurrentPrincipal.Identity.Name;
            mifactura.IdentidadCliento = miCliente.IdentidadCliente;
            mifactura.Subtotal = subtotal;
            mifactura.ISV = isv;
            mifactura.Descuento = descuento;
            mifactura.Total = totalAPagar;
            


            bool inserto = facturaDB.GuardarFactura(mifactura, listaDetalle);

            if (inserto)
            {
                limpiarcontroles();
                Id_ClientetextBox.Focus();
                MessageBox.Show("SE REGISTRO LA FACTURA EXITOSAMENTE");

            }
            else
            {
                MessageBox.Show("NO SE PUDO REGISTRAR LA FACTURA ");

            }


        }
        private void limpiarcontroles()
        {
            miCliente = null;
            miProducto = null;
            listaDetalle = null;
            FechadateTimePicker.Value = DateTime.Now;
            Id_ClientetextBox.Clear();
            ClienteNombretextBox.Clear();
            CodigoProductotextBox.Clear();
            DescripcionProductotextBox.Clear();
            ExistenciatextBox.Clear();
            CantidadtextBox.Clear();
            DetalledataGridView.DataSource = null;
            subtotal = 0;
            SubtotaltextBox.Clear();
            isv = 0;
            isvtextBox.Clear();
            descuento = 0;
            DesceuntotextBox.Clear();
            totalAPagar = 0;
            TotaltextBox.Clear();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
