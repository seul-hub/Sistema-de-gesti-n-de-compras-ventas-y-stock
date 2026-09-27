namespace VISTA
{
    partial class FrmReporteAvisosPorPeriodo
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
            btnbuscar = new Button();
            dtpdesde = new DateTimePicker();
            dtphasta = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(494, 150);
            dataGridView1.TabIndex = 0;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(192, 208);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(134, 56);
            btnbuscar.TabIndex = 1;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // dtpdesde
            // 
            dtpdesde.Location = new Point(12, 12);
            dtpdesde.Name = "dtpdesde";
            dtpdesde.Size = new Size(244, 23);
            dtpdesde.TabIndex = 2;
            // 
            // dtphasta
            // 
            dtphasta.Location = new Point(262, 12);
            dtphasta.Name = "dtphasta";
            dtphasta.Size = new Size(244, 23);
            dtphasta.TabIndex = 3;
            // 
            // FrmReporteAvisosPorPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 268);
            Controls.Add(dtphasta);
            Controls.Add(dtpdesde);
            Controls.Add(btnbuscar);
            Controls.Add(dataGridView1);
            Name = "FrmReporteAvisosPorPeriodo";
            Text = "FrmReporteAvisosPorPeriodo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnbuscar;
        private DateTimePicker dtpdesde;
        private DateTimePicker dtphasta;
    }
}