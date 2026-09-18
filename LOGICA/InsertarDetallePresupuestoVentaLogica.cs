using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGICA
{
    public class InsertarDetallePresupuestoVentaLogica
    {
        private InsertarDetallePresupuestoVenta insertar = new InsertarDetallePresupuestoVenta();
        public void Insertar (DetallePresupuestoVenta detallePresupuestoVenta)
        {
            if (detallePresupuestoVenta.Cantidad <= 0)
            {
                throw new Exception("La cantidad debe ser mayor a cero");
            }

            insertar.Insertar(detallePresupuestoVenta);
        }
    }
}
