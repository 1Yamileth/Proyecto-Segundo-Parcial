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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Usuarios_toolStripButton_Click(object sender, EventArgs e)
        {
            //INSTANCIAMOS UN OBJETO DEL FORM DE USUARIOS DE "VISTA"
            UsuariosForm userForm = new UsuariosForm();
            userForm.MdiParent = this;/*ESTAMOS DANDO A ENTENER QUE EL USERFORM TENDRA UN 
                                       PADRE Y SERA ".THIS", O SEA, ESTE FORMULADO MENU*/
            userForm.Show();//MOSTRANDO OTRA VENTANA
        }

        private void Productos_toolStripButton_Click(object sender, EventArgs e)
        {
            //INSTANCIAMOS UN OBJETO DEL FORM DE USUARIOS DE "VISTA"
            ProductosForm producForm = new ProductosForm();
            producForm.MdiParent = this;
            producForm.Show();//MOSTRANDO OTRA VENTANA
        }

        private void Clientes_toolStripButton_Click(object sender, EventArgs e)
        {
            ClientesForm clientes = new ClientesForm();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void NuevaFactura_toolStripButton3_Click(object sender, EventArgs e)
        {
            NuevaFacturaForm factura = new NuevaFacturaForm();
            factura.MdiParent = this;
            factura.Show();

        }
    }
}
