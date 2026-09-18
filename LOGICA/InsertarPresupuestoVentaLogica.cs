using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;

namespace LOGICA
{
   public class InsertarPresupuestoVentaLogica
    {
        private InsertarPresupuestoVenta insertar = new InsertarPresupuestoVenta();
        public void Insertar(PresupuestoVenta presupuesto)
        {
            insertar.Insertar(presupuesto);
        }
    }
}
