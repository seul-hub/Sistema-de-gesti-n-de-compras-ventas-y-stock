using ENTIDADES;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class BuscarPresupuestoVentaLogica
    {
        private BuscarPresupuestoVenta buscar = new BuscarPresupuestoVenta();
        public PresupuestoVenta Buscar(int IdPresupuestoVenta)
        {
            return buscar.Buscar(IdPresupuestoVenta);
        }
    }
}
