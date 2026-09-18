using Microsoft.Data.SqlClient;
using SISTEMA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
namespace DATOS
{
    public class InsertarDetalleNotaPedido
    {
        private Conexion conexion = new Conexion();
        public void Insertar(DetallesNotaPedido insertarDetalleNotaPedido)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_alta_detalles_notas_pedido", conexion.ObtenerConexion());

                comando.CommandType = CommandType.StoredProcedure;
              

                comando.Parameters.AddWithValue("@cantidad", insertarDetalleNotaPedido.Cantidad);
                comando.Parameters.AddWithValue("@precio_unitario", insertarDetalleNotaPedido.PrecioUnitario);
                comando.Parameters.AddWithValue("@id_nota_pedido", insertarDetalleNotaPedido.IdNotaPedido);
                comando.Parameters.AddWithValue("@id_producto", insertarDetalleNotaPedido.IdProducto);

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
