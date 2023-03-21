using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        //PROPIEDADES
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public byte[] Foto { get; set; }
        public bool EstaActivo { get; set; }

        //CONSTRUCTORES
        public Producto()
        {
        }

        public Producto(string codigoProducto, string descripcion, int existencia, decimal precio, byte[] foto, bool estaActivo)
        {
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Existencia = existencia;
            Precio = precio;
            Foto = foto;
            EstaActivo = estaActivo;
        }
    }
}
