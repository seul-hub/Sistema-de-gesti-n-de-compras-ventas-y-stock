using ENTIDADES;
using LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VISTA
{
    public partial class FrmAltaAvisoMercaderiaPreparada : Form
    {
        public FrmAltaAvisoMercaderiaPreparada()
        {
            InitializeComponent();
        }
        InsertarAvisoMercaderiaPreparadaLogica insertar = new InsertarAvisoMercaderiaPreparadaLogica();
        ErrorProvider error = new ErrorProvider();
        private void btnagregar_Click(object sender, EventArgs e)
        {

            try
            {
                AvisoMercaderiaPreparada aviso = new AvisoMercaderiaPreparada();
                aviso.IdNotaPedido = Convert.ToInt32(txtidnota.Text);
                aviso.IdUsuario = Convert.ToInt32(txtidusuario.Text);
                aviso.FechaEmision = Convert.ToDateTime(txtfecha.Text);

                insertar.Insertar(aviso);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //MessageBox.Show("ya se ingresaron los datos");
        }


        private void FrmAltaAvisoMercaderiaPreparada_Load(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
