using SISTEMA;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DATOS
{
    public class ListarDetalleNotaPedido
    {
        private Conexion conexion=new Conexion();
        public List<DetallesNotaPedido> Listar(int IdDetallesNotasPedido)
        {
            List<DetallesNotaPedido> listar = new List<DetallesNotaPedido>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_detalle_nota_pedido", conexion.ObtenerConexion());
                comando.CommandType=CommandType.StoredProcedure;
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    DetallesNotaPedido detallesNotaPedido = new DetallesNotaPedido();
                    detallesNotaPedido.IdNotaPedido=Convert.ToInt32(reader["id_nota_pedido"]);
                    detallesNotaPedido.IdProducto=Convert.ToInt32(reader["id_producto"]);
                    detallesNotaPedido.Cantidad=Convert.ToInt32(reader["cantidad"]);              
                    detallesNotaPedido.PrecioUnitario=Convert.ToDecimal(reader["precio_unitario"]);
                   
                    listar.Add(detallesNotaPedido);
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
            return listar;
        }
    }
}
