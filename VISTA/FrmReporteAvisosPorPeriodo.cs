using DATOS;
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
    public partial class FrmReporteAvisosPorPeriodo : Form
    {
        public FrmReporteAvisosPorPeriodo()
        {
            InitializeComponent();
        }
        private void CargarGrilla()
        {
            ListarAvisoMercaderiaPreparadaLogica logica = new ListarAvisoMercaderiaPreparadaLogica();
            List<AvisoMercaderiaPreparada> lista;
            lista = logica.Listar(dtpdesde.Value , dtphasta.Value);
            dataGridView1.DataSource=lista;
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }
    }
}
