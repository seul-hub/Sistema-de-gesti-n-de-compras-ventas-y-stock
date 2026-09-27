namespace VISTA
{
    partial class FrmAltaNotaPedido
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
            cmbestado = new ComboBox();
            txtfecha = new TextBox();
            txtidcliente = new TextBox();
            txtisusuario = new TextBox();
            btnagregar = new Button();
            btncancelar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtpresupuestoventa = new TextBox();
            txtprecio = new TextBox();
            txtcantidad = new TextBox();
            txtidproducto = new TextBox();
            btnagregarlinea = new Button();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            btnagregartodo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbestado
            // 
            cmbestado.FormattingEnabled = true;
            cmbestado.Location = new Point(129, 89);
            cmbestado.Name = "cmbestado";
            cmbestado.Size = new Size(121, 23);
            cmbestado.TabIndex = 0;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(129, 60);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(121, 23);
            txtfecha.TabIndex = 1;
            // 
            // txtidcliente
            // 
            txtidcliente.Location = new Point(129, 118);
            txtidcliente.Name = "txtidcliente";
            txtidcliente.Size = new Size(100, 23);
            txtidcliente.TabIndex = 3;
            // 
            // txtisusuario
            // 
            txtisusuario.Location = new Point(129, 147);
            txtisusuario.Name = "txtisusuario";
            txtisusuario.Size = new Size(100, 23);
            txtisusuario.TabIndex = 4;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(77, 229);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 23);
            btnagregar.TabIndex = 5;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(169, 229);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 60);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 8;
            label2.Text = "FechaEmision ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 89);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 9;
            label3.Text = "Estado ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 118);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 10;
            label4.Text = "IdCliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 147);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 11;
            label5.Text = "IdUsuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 186);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 12;
            label6.Text = "IdPresupuestoVenta";
            // 
            // txtpresupuestoventa
            // 
            txtpresupuestoventa.Location = new Point(129, 186);
            txtpresupuestoventa.Name = "txtpresupuestoventa";
            txtpresupuestoventa.Size = new Size(100, 23);
            txtpresupuestoventa.TabIndex = 13;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(344, 86);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(121, 23);
            txtprecio.TabIndex = 14;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(317, 57);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(121, 23);
            txtcantidad.TabIndex = 15;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(344, 117);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(121, 23);
            txtidproducto.TabIndex = 16;
            // 
            // btnagregarlinea
            // 
            btnagregarlinea.Location = new Point(256, 143);
            btnagregarlinea.Name = "btnagregarlinea";
            btnagregarlinea.Size = new Size(95, 23);
            btnagregarlinea.TabIndex = 17;
            btnagregarlinea.Text = "AgregarLinea";
            btnagregarlinea.UseVisualStyleBackColor = true;
            btnagregarlinea.Click += btnagregarlinea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 60);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 18;
            label1.Text = "Cantidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 89);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 19;
            label7.Text = "PrecioUnitario";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 121);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 20;
            label8.Text = "IdProducto";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(256, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(238, 113);
            dataGridView1.TabIndex = 21;
            // 
            // btnagregartodo
            // 
            btnagregartodo.Location = new Point(357, 143);
            btnagregartodo.Name = "btnagregartodo";
            btnagregartodo.Size = new Size(95, 23);
            btnagregartodo.TabIndex = 22;
            btnagregartodo.Text = "AgregarTodo";
            btnagregartodo.UseVisualStyleBackColor = true;
            btnagregartodo.Click += btnagregartodo_Click;
            // 
            // FrmAltaNotaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 305);
            Controls.Add(btnagregartodo);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(btnagregarlinea);
            Controls.Add(txtidproducto);
            Controls.Add(txtcantidad);
            Controls.Add(txtprecio);
            Controls.Add(txtpresupuestoventa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncancelar);
            Controls.Add(btnagregar);
            Controls.Add(txtisusuario);
            Controls.Add(txtidcliente);
            Controls.Add(txtfecha);
            Controls.Add(cmbestado);
            Name = "FrmAltaNotaPedido";
            Text = "FrmAltaNotaPedido";
            Load += FrmAltaNotaPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbestado;
        private TextBox txtfecha;
        private TextBox txtidcliente;
        private TextBox txtisusuario;
        private Button btnagregar;
        private Button btncancelar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtpresupuestoventa;
        private TextBox txtprecio;
        private TextBox txtcantidad;
        private TextBox txtidproducto;
        private Button btnagregarlinea;
        private Label label1;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
        private Button btnagregartodo;
    }
}