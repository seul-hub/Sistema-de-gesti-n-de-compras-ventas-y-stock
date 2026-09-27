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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaAvisoMercaderiaPreparada frm = new FrmAltaAvisoMercaderiaPreparada();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAltaNotaPedido frm = new FrmAltaNotaPedido();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAltaPresupuestoVenta frm = new FrmAltaPresupuestoVenta();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmListarNotaPedido frm = new FrmListarNotaPedido();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmListarPresupuestoVenta frm = new FrmListarPresupuestoVenta();
            frm.ShowDialog();
        }

        private void btnaviso_Click(object sender, EventArgs e)
        {
            FrmReporteAvisosPorPeriodo frm = new FrmReporteAvisosPorPeriodo();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmReporteTiempoPromedio frm = new FrmReporteTiempoPromedio();
            frm.Show();
        }
    }
}
