using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class InsertarNotaPedidoLogica
    {
        private InsertarNotaPedido insertar = new InsertarNotaPedido();
        public void Insertar(NotaPedido notapedido)
        {
            insertar.Insertar(notapedido);
        }
    }
}
