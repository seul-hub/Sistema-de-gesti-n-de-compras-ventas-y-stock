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
            comboBox1.Items.Add("Pendiente");
            comboBox1.Items.Add("Aprobado");
            comboBox1.Items.Add("Rechazado");
            txtFecha.Text = DateTime.Now.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            error.Clear();
            bool valido = true;
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                error.SetError(comboBox1, "este campo es obligatorio");
                valido = false;
            }
            if (!valido) return;
            try
            {
                PresupuestoVenta presupuestoventa = new PresupuestoVenta();
                presupuestoventa.Estado = Convert.ToString(comboBox1.Text);
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
            ListarPresupuestoVentaLogica listar = new ListarPresupuestoVentaLogica();
            List<PresupuestoVenta> lista = listar.Listar(null);
            PresupuestoVenta presupuestoEncontrado = lista.FirstOrDefault(detalle => detalle.FechaEmision == fechaUsada);

            foreach(DetallePresupuestoVenta id in detalle)
            {
                id.IdPresupuestoVenta = presupuestoEncontrado.IdPresupuestoVenta;
                insertarDetalleLogica.Insertar(id);
                MessageBox.Show("datos guardados");
            }
        }
    }
}