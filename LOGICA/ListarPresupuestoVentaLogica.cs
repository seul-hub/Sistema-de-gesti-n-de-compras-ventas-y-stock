using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS;

namespace LOGICA
{
    public class ListarPresupuestoVentaLogica
    {
        private ListarPresupuestoVenta listar = new ListarPresupuestoVenta();
        public List<PresupuestoVenta> Listar(string Estado)
        {
            return listar.Listar(Estado);
        }
    }
}
