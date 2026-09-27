using ENTIDADES;
using LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FrmReporteTiempoPromedio : Form
    {
        public FrmReporteTiempoPromedio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            ListarNotaPedidoLogica logicaPedidos = new ListarNotaPedidoLogica();
            List<NotaPedido> pedidos = logicaPedidos.Listar(null);

            ListarAvisoMercaderiaPreparadaLogica logicaAvisos = new ListarAvisoMercaderiaPreparadaLogica();
            DateTime desde = new DateTime(2000, 1, 1);
            DateTime hasta = new DateTime(2100, 1, 1);
            List<AvisoMercaderiaPreparada> avisos = logicaAvisos.Listar(desde, hasta);
            double sumahoras=0;
            int cantidad=0;
            foreach(NotaPedido pedido in pedidos )
            {
                AvisoMercaderiaPreparada avisoEncontrado = avisos.FirstOrDefault(a => a.IdNotaPedido == pedido.IdNotasPedido);
                if(avisoEncontrado != null )
                {
                    TimeSpan diferencia = avisoEncontrado.FechaEmision - pedido.FechaEmision;
                    double horas = diferencia.TotalHours;
                    sumahoras += horas;
                    cantidad += 1;
                }
            }
            if(cantidad==0)
            {
                MessageBox.Show("no se puede hacer este calculo");
            }
            else
            {
                double promedio = sumahoras / cantidad;
                txtresultado.Text = promedio.ToString();
            }
           
        }
    }
}
