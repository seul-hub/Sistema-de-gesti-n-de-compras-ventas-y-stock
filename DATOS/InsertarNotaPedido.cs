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
    public class InsertarNotaPedido
    {
        private Conexion conexion = new Conexion();
        public void Insertar(NotaPedido notaPedido)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_alta_nota_de_pedido", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@fecha_emision", notaPedido.FechaEmision);
                comando.Parameters.AddWithValue("@estado", notaPedido.Estado);
                comando.Parameters.AddWithValue("@id_cliente", notaPedido.IdCliente);
                comando.Parameters.AddWithValue("@id_usuario", notaPedido.IdUsuario);
                comando.Parameters.AddWithValue("@id_presupuesto_venta", notaPedido.IdPresupuestoVenta);
                conexion.AbrirConexion();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
