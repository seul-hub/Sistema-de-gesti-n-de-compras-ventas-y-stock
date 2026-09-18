using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ListarDetalleNotaPedidoLogica
    {
        private ListarDetalleNotaPedido listar = new ListarDetalleNotaPedido();
        public List<DetallesNotaPedido> Listar(int IdDetallesNotasPedido)
        {
            return listar.Listar(IdDetallesNotasPedido);
        }
    }
}
