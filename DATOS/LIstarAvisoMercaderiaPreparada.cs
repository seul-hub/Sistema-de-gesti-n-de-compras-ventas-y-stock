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
    public class LIstarAvisoMercaderiaPreparada
    {
        private Conexion conexion = new Conexion();

        public List<AvisoMercaderiaPreparada> Listar(DateTime fechadesde, DateTime fechahasta)
        {
            List<AvisoMercaderiaPreparada> lista = new List<AvisoMercaderiaPreparada>();
            try
            {
                SqlCommand comando = new SqlCommand("sp_listar_avisos_por_fecha", conexion.ObtenerConexion());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@fecha_desde", fechadesde);
                comando.Parameters.AddWithValue("@fecha_hasta", fechahasta);
                conexion.AbrirConexion();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    AvisoMercaderiaPreparada avisoMercaderiaPreparada = new AvisoMercaderiaPreparada();
                    avisoMercaderiaPreparada.IdAvisosMercaderiaPreparada = Convert.ToInt32(reader["id_avisos_mercaderia_preparada"]);
                    avisoMercaderiaPreparada.IdNotaPedido = Convert.ToInt32(reader["id_nota_pedido"]);
                    avisoMercaderiaPreparada.IdUsuario = Convert.ToInt32(reader["id_usuario"]);
                    avisoMercaderiaPreparada.FechaEmision = Convert.ToDateTime(reader["fecha_emision"]);

                    lista.Add(avisoMercaderiaPreparada);
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