using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using Microsoft.Data.SqlClient;
using SISTEMA;

namespace DATOS
{
    public class InsertarDetallePresupuestoVenta
    {
        private Conexion conexion = new Conexion();
        public void Insertar( DetallePresupuestoVenta detallePresupuestoVenta)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_alta_detalle_presupuesto_venta", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@cantidad", detallePresupuestoVenta.Cantidad);
                comando.Parameters.AddWithValue("@precio_unitario", detallePresupuestoVenta.PrecioUnitario);
                comando.Parameters.AddWithValue("@id_presupuesto_venta", detallePresupuestoVenta.IdPresupuestoVenta);
                comando.Parameters.AddWithValue("@id_producto", detallePresupuestoVenta.IdProducto);
                conexion.AbrirConexion();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
//@