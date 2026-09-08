using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class NotaPedido
    {
        public int IdNotasPedido { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario { get; set; }
        public int? IdPresupuestoVenta { get; set; }

        public NotaPedido() { }
        public NotaPedido(int IdNotasPedido, DateTime FechaEmision, string Estado, int IdCliente, int IdUsuario, int? IdPresupuestoVenta)
        {
            this.IdNotasPedido = IdNotasPedido;
            this.FechaEmision = FechaEmision;
            this.Estado = Estado;
            this.IdCliente = IdCliente;
            this.IdUsuario = IdUsuario;
            this.IdPresupuestoVenta = IdPresupuestoVenta;
        }
    }
}
