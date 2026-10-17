using SISTEMA;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DATOS
{
    public class ListarNotaPedido
    {
        private Conexion conexion = new Conexion();

        public List<NotaPedido> Listar(string Estado)
        {
            List<NotaPedido> lista = new List<NotaPedido>();

            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_notas_pedido", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@estado", Estado);
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    NotaPedido notapedido = new NotaPedido();
                    notapedido.IdNotasPedido = Convert.ToInt32(reader["id_notas_pedido"]);
                    notapedido.FechaEmision = Convert.ToDateTime(reader["fecha_emision"]);
                    notapedido.Estado = Convert.ToString(reader["estado"]);
                    notapedido.IdCliente = Convert.ToInt32(reader["id_cliente"]);
                    notapedido.IdUsuario = Convert.ToInt32(reader["id_usuario"]);
                    notapedido.IdPresupuestoVenta = reader["id_presupuesto_venta"] == DBNull.Value ? null : (int?)Convert.ToInt32(reader["id_presupuesto_venta"]);
                    lista.Add(notapedido);
                }
            }
            catch (Exception ex)
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
