using DATOS;
using ENTIDADES;
using LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class FrmListarNotaPedido : Form
    {
        public FrmListarNotaPedido()
        {
            InitializeComponent();
        }

        private void FrmListarNotaPedido_Load(object sender, EventArgs e)
        {
            cmbfiltro.Items.Add("Todos");
            cmbfiltro.Items.Add("Pendiente");
            cmbfiltro.Items.Add("Preparado");
            cmbfiltro.Items.Add("Entregado");
            cmbfiltro.Items.Add("Facturado");

            cmbfiltro.SelectedIndex = 0;


            cmbfiltro2.Items.Add("Pendiente");
            cmbfiltro2.Items.Add("Preparado");
            cmbfiltro2.Items.Add("Entregado");
            cmbfiltro2.Items.Add("Facturado");
        }
        private void CargarGrilla()
        {
            ListarNotaPedidoLogica logica = new ListarNotaPedidoLogica();
            List<NotaPedido> lista;
            if (cmbfiltro.Text == "Todos")
            {
                lista = logica.Listar(null);
            }
            else
            {
                lista = logica.Listar(cmbfiltro.Text);
            }
            dataGridView1.DataSource = lista;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarGrilla();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un estado primero.");
                return;
            }
            try
            {
                ModificarEstadoNotaPedidoLogica modificarEstadoNotaPedido = new ModificarEstadoNotaPedidoLogica();
                NotaPedido notaseleccioanada = (NotaPedido)dataGridView1.CurrentRow.DataBoundItem;
                int IdNotasPedido = notaseleccioanada.IdNotasPedido;
                modificarEstadoNotaPedido.Modificar(IdNotasPedido, cmbfiltro2.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
