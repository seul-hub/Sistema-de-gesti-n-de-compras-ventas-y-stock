using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class DetallePresupuestoVenta
    {
        public int IdDetallePresupuestoVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int IdPresupuestoVenta { get; set; }
        public int IdProducto { get; set; }

        public DetallePresupuestoVenta() { }
        public DetallePresupuestoVenta(int IdDetallePresupuestoVenta, int Cantidad, decimal PrecioUnitario, int IdPresupuestoVenta, int IdProducto)
        {
            this.IdDetallePresupuestoVenta = IdDetallePresupuestoVenta;
            this.Cantidad = Cantidad;
            this.PrecioUnitario = PrecioUnitario;
            this.IdPresupuestoVenta = IdPresupuestoVenta;
            this.IdProducto = IdProducto;
        }
    }
}
