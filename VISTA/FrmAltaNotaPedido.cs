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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VISTA
{
    public partial class FrmAltaNotaPedido : Form
    {
        public FrmAltaNotaPedido()
        {
            InitializeComponent();
        }
        private InsertarDetalleNotaPedidoLogica insertarDetalle = new InsertarDetalleNotaPedidoLogica();
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
            txtfecha.Text = DateTime.Now.ToString();
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
                notapedido.IdUsuario = Convert.ToInt32(txtisusuario.Text);

                if (string.IsNullOrWhiteSpace(txtpresupuestoventa.Text))
                {
                    notapedido.IdPresupuestoVenta = null;
                }
                else
                {
                    notapedido.IdPresupuestoVenta = Convert.ToInt32(txtpresupuestoventa.Text);
                }

                fechaUsada = notapedido.FechaEmision;

                insertar.Insertar(notapedido);
                MessageBox.Show("datos ingresados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<DetallesNotaPedido> detalles = new List<DetallesNotaPedido>();


        private void btnagregarlinea_Click(object sender, EventArgs e)
        {
            try
            {
                DetallesNotaPedido notaPedido = new DetallesNotaPedido();
                notaPedido.Cantidad = Convert.ToInt32(txtcantidad.Text);
                notaPedido.PrecioUnitario = Convert.ToDecimal(txtprecio.Text);
                notaPedido.IdProducto = Convert.ToInt32(txtidproducto.Text);

                if (notaPedido.Cantidad <= 0)
                {
                    throw new Exception("La cantidad debe ser mayor a cero");
                }
                detalles.Add(notaPedido);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = detalles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DateTime fechaUsada;
        private void btnagregartodo_Click(object sender, EventArgs e)
        {
            if (detalles.Count == 0)
            {
                MessageBox.Show("Agregue al menos una línea con el botón Agregar línea antes de guardar todo.");
                return;
            }

            ListarNotaPedidoLogica listar = new ListarNotaPedidoLogica();
            List<NotaPedido> lista = listar.Listar(null);
            NotaPedido notaEncontrada = lista.FirstOrDefault(n => n.FechaEmision == fechaUsada);

            if (notaEncontrada == null)
            {
                MessageBox.Show("Primero guarde la nota con el botón Agregar, después cargue las líneas con Agregar línea y por último use Agregar todo.");
                return;
            }

            foreach (DetallesNotaPedido linea in detalles)
            {
                linea.IdNotaPedido = notaEncontrada.IdNotasPedido;
                insertarDetalle.Insertar(linea);
            }

            Limpiar();
            MessageBox.Show("Las líneas se guardaron correctamente.");
        }

        private void Limpiar()
        {
            txtcantidad.Clear();
            txtprecio.Clear();
            txtidproducto.Clear();
            txtidcliente.Clear();
            txtisusuario.Clear();
            txtpresupuestoventa.Clear();
            cmbestado.SelectedIndex = -1;

            txtfecha.Text = DateTime.Now.ToString();

            detalles.Clear();
            dataGridView1.DataSource = null;

            fechaUsada = DateTime.MinValue;
        }
    }
}
