using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using ENTIDADES;
using LOGICA;
using System.Linq;

namespace VISTA
{
    public partial class FrmAltaPresupuestoVenta : Form
    {
        public FrmAltaPresupuestoVenta()
        {
            InitializeComponent();
        }
         private InsertarDetallePresupuestoVentaLogica insertarDetalleLogica = new InsertarDetallePresupuestoVentaLogica();
         private InsertarPresupuestoVentaLogica insertar = new InsertarPresupuestoVentaLogica();
        private InsertarDetallePresupuestoVenta insertarDetalle = new InsertarDetallePresupuestoVenta();
        private List<DetallePresupuestoVenta> detalle = new List<DetallePresupuestoVenta>();

        ErrorProvider error1 = new ErrorProvider();

        private ErrorProvider error = new ErrorProvider();

        private void FrmAltaPresupuestoVenta_Load(object sender, EventArgs e)
        {
            cmbestado.Items.Add("Pendiente");
            cmbestado.Items.Add("Aprobado");
            cmbestado.Items.Add("Rechazado");
            txtFecha.Text = DateTime.Now.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
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
                PresupuestoVenta presupuestoventa = new PresupuestoVenta();
                presupuestoventa.Estado = Convert.ToString(cmbestado.Text);
                presupuestoventa.FechaEmision = Convert.ToDateTime(txtFecha.Text);
                presupuestoventa.IdCliente = Convert.ToInt32(txtidcliente.Text);
                presupuestoventa.IdUsuario = Convert.ToInt32(txtusuario.Text);

                fechaUsada = presupuestoventa.FechaEmision;

                insertar.Insertar(presupuestoventa);
                MessageBox.Show("datos ingresados");
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
        private void btnagregarlinea_Click(object sender, EventArgs e)
        {
            error1.Clear();
            bool valido1 = true;
            if (string.IsNullOrWhiteSpace(txtcantidad.Text))
            {
                error1.SetError(txtcantidad, "este campo es obligatorio");
                valido1 = false;
            }
            if (!valido1) return;
            try
            {

                DetallePresupuestoVenta detallePresupuestoventa = new DetallePresupuestoVenta();

                detallePresupuestoventa.Cantidad = Convert.ToInt32(txtcantidad.Text);
                detallePresupuestoventa.PrecioUnitario = Convert.ToDecimal(txtpreciounitario.Text);
                detallePresupuestoventa.IdProducto = Convert.ToInt32(txtidproducto.Text);


                if (detallePresupuestoventa.Cantidad <= 0)
                {
                    throw new Exception("La cantidad debe ser mayor a cero");
                }
                detalle.Add(detallePresupuestoventa);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = detalle;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private DateTime fechaUsada;

        private void btnagregartodo_Click(object sender, EventArgs e)
        {
            if (detalle.Count == 0)
            {
                MessageBox.Show("Agregue al menos una línea con el botón Agregar línea antes de guardar todo.");
                return;
            }

            ListarPresupuestoVentaLogica listar = new ListarPresupuestoVentaLogica();
            List<PresupuestoVenta> lista = listar.Listar(null);
            PresupuestoVenta presupuestoEncontrado = lista.FirstOrDefault(p => p.FechaEmision == fechaUsada);

            if (presupuestoEncontrado == null)
            {
                MessageBox.Show("Primero guarde el presupuesto con el botón Agregar, después cargue las líneas con Agregar línea y por último use Agregar todo.");
                return;
            }

            foreach (DetallePresupuestoVenta linea in detalle)
            {
                linea.IdPresupuestoVenta = presupuestoEncontrado.IdPresupuestoVenta;
                insertarDetalleLogica.Insertar(linea);
            }

            Limpiar();
            MessageBox.Show("Las líneas se guardaron correctamente.");
        }

        private void Limpiar()
        {
            txtcantidad.Clear();
            txtidproducto.Clear();
            txtidcliente.Clear();
            txtusuario.Clear();
            txtpreciounitario.Clear();
            cmbestado.SelectedIndex = -1;

            txtFecha.Text = DateTime.Now.ToString();
            detalle.Clear();
            dataGridView1.DataSource = null;

            fechaUsada = DateTime.MinValue;
        }
    }
}