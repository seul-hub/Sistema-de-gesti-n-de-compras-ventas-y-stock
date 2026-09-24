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
    public partial class FrmListarPresupuestoVenta : Form
    {
        public FrmListarPresupuestoVenta()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            ListarPresupuestoVentaLogica logica = new ListarPresupuestoVentaLogica();
            List<PresupuestoVenta> lista;

            if (cmbfiltroestado.Text == "Todos")
            {
                lista = logica.Listar(null);
            }
            else
            {
                lista = logica.Listar(cmbfiltroestado.Text);
            }
            dataGridView1.DataSource = lista;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();

        }
        private void FrmListarPresupuestoVenta_Load(object sender, EventArgs e)
        {
            cmbfiltroestado.Items.Add("Todos");
            cmbfiltroestado.Items.Add("Pendiente");
            cmbfiltroestado.Items.Add("Aprobado");
            cmbfiltroestado.Items.Add("Rechazado");

            cmbfiltroestado.SelectedIndex = 0;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}