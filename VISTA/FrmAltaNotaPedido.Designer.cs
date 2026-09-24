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
            txtnotapedido = new TextBox();
            txtidcliente = new TextBox();
            txtisusuario = new TextBox();
            btnagregar = new Button();
            btncancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtpresupuestoventa = new TextBox();
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
            // txtnotapedido
            // 
            txtnotapedido.Location = new Point(129, 31);
            txtnotapedido.Name = "txtnotapedido";
            txtnotapedido.Size = new Size(100, 23);
            txtnotapedido.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 7;
            label1.Text = "IdNotasPedido";
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
            // FrmAltaNotaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 309);
            Controls.Add(txtpresupuestoventa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncancelar);
            Controls.Add(btnagregar);
            Controls.Add(txtisusuario);
            Controls.Add(txtidcliente);
            Controls.Add(txtnotapedido);
            Controls.Add(txtfecha);
            Controls.Add(cmbestado);
            Name = "FrmAltaNotaPedido";
            Text = "FrmAltaNotaPedido";
            Load += FrmAltaNotaPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbestado;
        private TextBox txtfecha;
        private TextBox txtnotapedido;
        private TextBox txtidcliente;
        private TextBox txtisusuario;
        private Button btnagregar;
        private Button btncancelar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtpresupuestoventa;
    }
}