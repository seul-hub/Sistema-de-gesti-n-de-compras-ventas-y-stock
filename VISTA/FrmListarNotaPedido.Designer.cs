namespace VISTA
{
    partial class FrmListarNotaPedido
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
            btnactualizar = new Button();
            dataGridView1 = new DataGridView();
            cmbfiltro = new ComboBox();
            btncancelar = new Button();
            cmbfiltro2 = new ComboBox();
            btnestado = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(12, 82);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(107, 37);
            btnactualizar.TabIndex = 0;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(414, 159);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cmbfiltro
            // 
            cmbfiltro.FormattingEnabled = true;
            cmbfiltro.Location = new Point(12, 26);
            cmbfiltro.Name = "cmbfiltro";
            cmbfiltro.Size = new Size(121, 23);
            cmbfiltro.TabIndex = 2;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(125, 82);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(107, 37);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // cmbfiltro2
            // 
            cmbfiltro2.FormattingEnabled = true;
            cmbfiltro2.Location = new Point(139, 26);
            cmbfiltro2.Name = "cmbfiltro2";
            cmbfiltro2.Size = new Size(121, 23);
            cmbfiltro2.TabIndex = 4;
            // 
            // btnestado
            // 
            btnestado.Location = new Point(238, 82);
            btnestado.Name = "btnestado";
            btnestado.Size = new Size(107, 37);
            btnestado.TabIndex = 5;
            btnestado.Text = "Cambiar Estado";
            btnestado.UseVisualStyleBackColor = true;
            btnestado.Click += btnestado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 8);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 7;
            label2.Text = "Siguiente_Estado";
            // 
            // FrmListarNotaPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 306);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnestado);
            Controls.Add(cmbfiltro2);
            Controls.Add(btncancelar);
            Controls.Add(cmbfiltro);
            Controls.Add(dataGridView1);
            Controls.Add(btnactualizar);
            Name = "FrmListarNotaPedido";
            Text = "FrmListarNotaPedido";
            Load += FrmListarNotaPedido_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnactualizar;
        private DataGridView dataGridView1;
        private ComboBox cmbfiltro;
        private Button btncancelar;
        private ComboBox cmbfiltro2;
        private Button btnestado;
        private Label label1;
        private Label label2;
    }
}