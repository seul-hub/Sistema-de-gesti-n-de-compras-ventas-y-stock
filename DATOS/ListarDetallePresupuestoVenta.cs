using ENTIDADES;
using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ListarDetallePresupuestoVenta
    {
        private Conexion conexion = new Conexion();
        public List<DetallePresupuestoVenta> Listar(int IdDetallePresupuestoVenta)
        {
            List<DetallePresupuestoVenta> lista = new List<DetallePresupuestoVenta>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_detalle_presupuesto_venta", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_presupuesto_venta", IdDetallePresupuestoVenta);
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DetallePresupuestoVenta detallePresupuesto = new DetallePresupuestoVenta();
                    detallePresupuesto.Cantidad = Convert.ToInt32(reader["cantidad"]);
                    detallePresupuesto.PrecioUnitario = Convert.ToDecimal(reader["precio_unitario"]);
                    detallePresupuesto.IdPresupuestoVenta = Convert.ToInt32(reader["id_presupuesto_venta"]);
                    detallePresupuesto.IdProducto = Convert.ToInt32(reader["id_producto"]);
                    lista.Add(detallePresupuesto);
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return lista;
        }
    }
}
