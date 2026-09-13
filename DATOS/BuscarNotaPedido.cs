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
    public class BuscarNotaPedido
    {
        private Conexion conexion = new Conexion();
        public NotaPedido Buscar(int IdNotasPedidos)
        {
            NotaPedido notapedido = null;
            try
            {
                SqlCommand comando = new SqlCommand("sp_buscar_nota_pedido", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_notas_pedido", IdNotasPedidos);
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    notapedido = new NotaPedido();
                    notapedido.IdNotasPedido = Convert.ToInt32(reader["id_notas_pedido"]);
                    notapedido.FechaEmision = Convert.ToDateTime(reader["fecha_emision"]);
                    notapedido.Estado = Convert.ToString(reader["estado"]);
                    notapedido.IdCliente = Convert.ToInt32(reader["id_cliente"]);
                    notapedido.IdUsuario = Convert.ToInt32(reader["id_usuario"]);
                    notapedido.IdPresupuestoVenta = Convert.ToInt32(reader["id_presupuesto_venta"]);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return notapedido;
        }
    }
}
