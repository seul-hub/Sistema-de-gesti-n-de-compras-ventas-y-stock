namespace VISTA
{
    partial class FrmAltaPresupuestoVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPresupuesto = new TextBox();
            txtFecha = new TextBox();
            txtidcliente = new TextBox();
            txtusuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAgregar = new Button();
            btncancelar = new Button();
            cmbestado = new ComboBox();
            txtcantidad = new TextBox();
            txtidproducto = new TextBox();
            txtpreciounitario = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            btnagregarlinea = new Button();
            btnagregartodo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPresupuesto
            // 
            txtPresupuesto.Location = new Point(129, 38);
            txtPresupuesto.Name = "txtPresupuesto";
            txtPresupuesto.Size = new Size(100, 23);
            txtPresupuesto.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(129, 67);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(124, 23);
            txtFecha.TabIndex = 2;
            // 
            // txtidcliente
            // 
            txtidcliente.Location = new Point(129, 125);
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(100, 23);
            txtidcliente.TabIndex = 4;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(129, 154);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 6;
            label1.Text = "IdPresupuestoVenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 7;
            label2.Text = "FechaEmision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "IdCliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "IdUsuario";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(83, 183);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(164, 183);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 12;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // cmbestado
            // 
            cmbestado.FormattingEnabled = true;
            cmbestado.Location = new Point(129, 96);
            cmbestado.Name = "cmbestado";
            cmbestado.Size = new Size(100, 23);
            cmbestado.TabIndex = 13;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(344, 39);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 14;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(344, 96);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(100, 23);
            txtidproducto.TabIndex = 15;
            // 
            // txtpreciounitario
            // 
            txtpreciounitario.Location = new Point(344, 67);
            txtpreciounitario.Name = "txtpreciounitario";
            txtpreciounitario.Size = new Size(100, 23);
            txtpreciounitario.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 42);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 17;
            label6.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 67);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 18;
            label7.Text = "PrecioUnitario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(272, 96);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 19;
            label8.Text = "IdProducto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(270, 150);
            dataGridView1.TabIndex = 20;
            // 
            // btnagregarlinea
            // 
            btnagregarlinea.Location = new Point(450, 38);
            btnagregarlinea.Name = "btnagregarlinea";
            btnagregarlinea.Size = new Size(80, 38);
            btnagregarlinea.TabIndex = 21;
            btnagregarlinea.Text = "Agregar Linea";
            btnagregarlinea.UseVisualStyleBackColor = true;
            btnagregarlinea.Click += btnagregarlinea_Click;
            // 
            // btnagregartodo
            // 
            btnagregartodo.Location = new Point(450, 81);
            btnagregartodo.Name = "btnagregartodo";
            btnagregartodo.Size = new Size(80, 38);
            btnagregartodo.TabIndex = 22;
            btnagregartodo.Text = "Agregar Todo";
            btnagregartodo.UseVisualStyleBackColor = true;
            btnagregartodo.Click += btnagregartodo_Click;
            // 
            // FrmAltaPresupuestoVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 299);
            Controls.Add(btnagregartodo);
            Controls.Add(btnagregarlinea);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtpreciounitario);
            Controls.Add(txtidproducto);
            Controls.Add(txtcantidad);
            Controls.Add(cmbestado);
            Controls.Add(btncancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtusuario);
            Controls.Add(txtidcliente);
            Controls.Add(txtFecha);
            Controls.Add(txtPresupuesto);
            Name = "FrmAltaPresupuestoVenta";
            Text = "FrmAltaPresupuestoVenta";
            Load += FrmAltaPresupuestoVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPresupuesto;
        private TextBox txtFecha;
        private TextBox txtidcliente;
        private TextBox txtusuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAgregar;
        private Button btncancelar;
        private ComboBox cmbestado;
        private TextBox txtcantidad;
        private TextBox txtidproducto;
        private TextBox txtpreciounitario;
        private Label label6;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnagregarlinea;
        private Button btnagregartodo;
    }
}