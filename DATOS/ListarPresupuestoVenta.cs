using SISTEMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DATOS
{
    public class ListarPresupuestoVenta
    {
        private Conexion conexion = new Conexion();
        public List<PresupuestoVenta>Listar(string Estado , int? IdCliente = null)
        {
            List<PresupuestoVenta> lista = new List<PresupuestoVenta>();

            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_presupuestos_venta", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@estado", Estado);
                if (IdCliente.HasValue)
                {
                    comando.Parameters.AddWithValue("@id_cliente", IdCliente.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@id_cliente", DBNull.Value);
                }
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                while(reader.Read())
                {
                    PresupuestoVenta presupuestoVenta = new PresupuestoVenta();

                    presupuestoVenta.IdPresupuestoVenta = Convert.ToInt32(reader["id_presupuesto_venta"]);
                    presupuestoVenta.FechaEmision = Convert.ToDateTime(reader["fecha_emision"]);
                    presupuestoVenta.Estado = Convert.ToString(reader["estado"]);
                    presupuestoVenta.IdCliente = Convert.ToInt32(reader["id_cliente"]);
                    presupuestoVenta.IdUsuario = Convert.ToInt32(reader["id_usuario"]);

                    lista.Add(presupuestoVenta);
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
