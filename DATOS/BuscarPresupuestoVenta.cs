using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISTEMA;
using DATOS;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using ENTIDADES;

namespace DATOS
{
    public class BuscarPresupuestoVenta
    {
        private Conexion conexion = new Conexion();

        public PresupuestoVenta Buscar (int IdPresupuestoVenta)
        {

            PresupuestoVenta buscarPresupuesto = null ;/* variable que empieza en null */

            try
            {
                SqlCommand comando = new SqlCommand("sp_buscar_presupuesto_venta", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_presupuesto_venta", IdPresupuestoVenta/* el parámetro que recibiste */);

                conexion.AbrirConexion();
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    buscarPresupuesto = new PresupuestoVenta();
                    buscarPresupuesto.IdPresupuestoVenta = Convert.ToInt32(lector["id_presupuesto_venta"]);
                    buscarPresupuesto.FechaEmision = Convert.ToDateTime(lector["fecha_emision"]);
                    buscarPresupuesto.Estado = Convert.ToString(lector["estado"]);
                    buscarPresupuesto.IdCliente = Convert.ToInt32(lector["id_cliente"]);
                    buscarPresupuesto.IdUsuario = Convert.ToInt32(lector["id_usuario"]);
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return buscarPresupuesto/* la variable */;
        }
    }
}
