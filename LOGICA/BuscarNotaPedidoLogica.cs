using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
   public class BuscarNotaPedidoLogica
    {
        private BuscarNotaPedido buscar = new BuscarNotaPedido();
        public NotaPedido Buscar(int IdNotasPedidos)
        {
            return buscar.Buscar(IdNotasPedidos);
        }
    }
}
