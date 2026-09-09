using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class DetallesNotaPedido
    {
        public int IdDetallesNotasPedido { get; set; }
        public int IdNotaPedido { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public DetallesNotaPedido() { }
        public DetallesNotaPedido(int IdDetallesNotasPedido, int IdNotaPedido, int IdProducto, int Cantidad, decimal PrecioUnitario)
        {
            this.IdDetallesNotasPedido = IdDetallesNotasPedido;
            this.IdNotaPedido = IdNotaPedido;
            this.IdProducto = IdProducto;
            this.Cantidad = Cantidad;
            this.PrecioUnitario = PrecioUnitario;
        }
    }
}
