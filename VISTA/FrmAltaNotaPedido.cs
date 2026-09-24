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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VISTA
{
    public partial class FrmAltaNotaPedido : Form
    {
        public FrmAltaNotaPedido()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaNotaPedido_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("Pendiente");
            cmbestado.Items.Add("Preparado");
            cmbestado.Items.Add("Entregado");
            cmbestado.Items.Add("Facturado");
        }
        private InsertarNotaPedidoLogica insertar = new InsertarNotaPedidoLogica();
        private ErrorProvider error = new ErrorProvider();
        private void btnagregar_Click(object sender, EventArgs e)
        {
            error.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(cmbestado.Text))
            {
                error.SetError(cmbestado, "este campo es obligatorio");
                valido = false;
            }
            if (!valido) return;
            try
            {
                NotaPedido notapedido = new NotaPedido();
                notapedido.FechaEmision = Convert.ToDateTime(txtfecha.Text);
                notapedido.Estado = Convert.ToString(cmbestado.Text);
                notapedido.IdCliente = Convert.ToInt32(txtidcliente.Text);
                notapedido.IdNotasPedido = Convert.ToInt32(txtnotapedido.Text);
                if (string.IsNullOrWhiteSpace(txtpresupuestoventa.Text))
                {
                    notapedido.IdPresupuestoVenta = null;

                }
                else
                {
                    notapedido.IdPresupuestoVenta = Convert.ToInt32(txtpresupuestoventa.Text);
                }
                insertar.Insertar(notapedido);
                MessageBox.Show("datos ingresados");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
