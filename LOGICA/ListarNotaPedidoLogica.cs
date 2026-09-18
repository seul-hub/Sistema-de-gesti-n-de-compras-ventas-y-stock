using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ListarNotaPedidoLogica
    {
        private ListarNotaPedido listar = new ListarNotaPedido();
        public List<NotaPedido> Listar(string Estado)
        {
            return listar.Listar(Estado);
        }
    }
}
