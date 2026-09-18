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
    public class ModificarEstadoNotaPedido
    {
        private Conexion conexion = new Conexion();
        public void Modificar(int IdNotasPedido , string Estado)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_modificar_estado_nota_pedido", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_notas_pedido", IdNotasPedido);
                comando.Parameters.AddWithValue("@estado", Estado);
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
