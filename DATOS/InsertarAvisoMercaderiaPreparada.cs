using SISTEMA;
using System;
using ENTIDADES;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.TÑasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DATOS
{
    public class InsertarAvisoMercaderiaPreparada
    {
        private Conexion conexion =new Conexion();
        public void Insertar(AvisoMercaderiaPreparada aviso)
        {
            try
            {
               SqlCommand comando =new SqlCommand("sp_alta_aviso_mercaderia_preparada" , conexion.ObtenerConexion());
                comando.CommandType=CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_nota_pedido", aviso.IdNotaPedido);
                comando.Parameters.AddWithValue("@id_usuario", aviso.IdUsuario);
                comando.Parameters.AddWithValue("@fecha_emision", aviso.FechaEmision);
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
