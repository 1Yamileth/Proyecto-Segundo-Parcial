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
    public partial class BuscarProductoForm : Form
    {
        public BuscarProductoForm()
        {
            InitializeComponent();
        }
        ProductoDB productoDB= new ProductoDB();
        public Producto producto= new Producto();//Pasaremos al form de factura
        private void BuscarProductoForm_Load(object sender, EventArgs e)
        {
            //Consultaremos todos los productos
            Productos_dataGridView.DataSource = productoDB.DevolverProductos();
        }

        private void DescripciontextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Productos_dataGridView.DataSource = productoDB.DevolverProductosPorDescripcion(DescripciontextBox.Text);

        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (Productos_dataGridView.RowCount>0)//Vemos que haya datos en el DGV
            {
                if (Productos_dataGridView.SelectedRows.Count>0)//Validamos que haya selecionado un registro
                {
                    producto.CodigoProducto = Productos_dataGridView.CurrentRow.Cells["CodigoProducto"].Value.ToString();
                    producto.Descripcion = Productos_dataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                    producto.Existencia = Convert.ToInt32 (Productos_dataGridView.CurrentRow.Cells["Existencia"].Value);
                    producto.Precio = Convert.ToDecimal(Productos_dataGridView.CurrentRow.Cells["Precio"].Value);
                    producto.EstaActivo = Convert.ToBoolean(Productos_dataGridView.CurrentRow.Cells["EstaActivo"].Value);
                    Close();
                }
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
