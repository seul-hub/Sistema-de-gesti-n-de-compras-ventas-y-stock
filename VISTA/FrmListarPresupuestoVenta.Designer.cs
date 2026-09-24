namespace VISTA
{
    partial class FrmListarPresupuestoVenta
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
            dataGridView1 = new DataGridView();
            btnactualizar = new Button();
            btncancelar = new Button();
            cmbfiltroestado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(362, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(12, 12);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(89, 41);
            btnactualizar.TabIndex = 1;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(107, 12);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(89, 41);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // cmbfiltroestado
            // 
            cmbfiltroestado.FormattingEnabled = true;
            cmbfiltroestado.Location = new Point(202, 30);
            cmbfiltroestado.Name = "cmbfiltroestado";
            cmbfiltroestado.Size = new Size(121, 23);
            cmbfiltroestado.TabIndex = 4;
            // 
            // FrmListarPresupuestoVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 256);
            Controls.Add(cmbfiltroestado);
            Controls.Add(btncancelar);
            Controls.Add(btnactualizar);
            Controls.Add(dataGridView1);
            Name = "FrmListarPresupuestoVenta";
            Text = "FrmListarPresupuestoVenta";
            Load += FrmListarPresupuestoVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnactualizar;
        private Button btncancelar;
        private ComboBox cmbfiltroestado;
    }
}