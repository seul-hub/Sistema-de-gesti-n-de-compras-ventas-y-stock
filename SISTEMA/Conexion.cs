using System;
using Microsoft.Data.SqlClient;
namespace SISTEMA
{
    public class Conexion
    {
        private SqlConnection conexion;
        public Conexion()
        {
            conexion = new SqlConnection("Server=DESKTOP-7MSL8IO;" +
                "Database=Presupuestos_y_pedidos_de_venta;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate=True;");
        }
        public SqlConnection ObtenerConexion()
        {
            return conexion;
        }
        public void AbrirConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        public void CerrarConexion()
        { 
        if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}