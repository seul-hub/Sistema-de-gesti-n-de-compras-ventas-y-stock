using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class InsertarDetalleNotaPedidoLogica
    {
        private InsertarDetalleNotaPedido insertar = new InsertarDetalleNotaPedido();
        public void Insertar(DetallesNotaPedido detallesNotaPedido)
        {
            if (detallesNotaPedido.Cantidad <=0)
            {
                throw new Exception("la cantidad debe ser mayor a cero");
            }
            insertar.Insertar(detallesNotaPedido);
        }
    }
}
