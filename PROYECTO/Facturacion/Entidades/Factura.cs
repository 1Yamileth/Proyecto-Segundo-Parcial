
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public string IdentidadCliento { get; set; }
        public string CodigoUsuario { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {
        }

        public Factura(int idFactura, DateTime fechaFactura, string identidadCliento, string codigoUsuario, decimal iSV, decimal descuento, decimal subtotal, decimal total)
        {
            IdFactura = idFactura;
            FechaFactura = fechaFactura;
            IdentidadCliento = identidadCliento;
            CodigoUsuario = codigoUsuario;
            ISV = iSV;
            Descuento = descuento;
            Subtotal = subtotal;
            Total = total;
        }
    }
}
