using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class ListarDetallePresupuestoVentaLogica
    {
        private ListarDetallePresupuestoVenta listar = new ListarDetallePresupuestoVenta();
        public List<DetallePresupuestoVenta> Listar(int IdDetallePresupuestoVenta)
        {
            return listar.Listar(IdDetallePresupuestoVenta);
        }
    }
}
