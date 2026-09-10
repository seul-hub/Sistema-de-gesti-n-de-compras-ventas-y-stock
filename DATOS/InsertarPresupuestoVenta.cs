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
    public class InsertarPresupuestoVenta
    {
        private Conexion conexion = new Conexion();
        public void Insertar (PresupuestoVenta presupuestoVenta)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_alta_presupuesto_venta", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@fecha_emision", presupuestoVenta.FechaEmision);
                comando.Parameters.AddWithValue("@estado", presupuestoVenta.Estado);
                comando.Parameters.AddWithValue("@id_cliente", presupuestoVenta. IdCliente);
                comando.Parameters.AddWithValue("@Id_usuario", presupuestoVenta.IdUsuario);

                conexion.AbrirConexion();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
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
