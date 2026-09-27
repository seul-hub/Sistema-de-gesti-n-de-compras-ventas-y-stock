namespace VISTA
{
    partial class FrmPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            btnaviso = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 101);
            button1.Name = "button1";
            button1.Size = new Size(150, 53);
            button1.TabIndex = 3;
            button1.Text = "AgregarAvisoMercaderiaPreparada";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(22, 160);
            button2.Name = "button2";
            button2.Size = new Size(150, 53);
            button2.TabIndex = 4;
            button2.Text = "AgregarNotaPedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(22, 219);
            button3.Name = "button3";
            button3.Size = new Size(148, 50);
            button3.TabIndex = 5;
            button3.Text = "AgregarPresupuestoVenta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(24, 275);
            button4.Name = "button4";
            button4.Size = new Size(148, 50);
            button4.TabIndex = 6;
            button4.Text = "ListarNotaPedido";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(22, 331);
            button5.Name = "button5";
            button5.Size = new Size(150, 53);
            button5.TabIndex = 7;
            button5.Text = "ListarPresupuestoVenta";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 8;
            label1.Text = "Seleccione que tarea desee hacer";
            // 
            // btnaviso
            // 
            btnaviso.Location = new Point(22, 390);
            btnaviso.Name = "btnaviso";
            btnaviso.Size = new Size(148, 50);
            btnaviso.TabIndex = 9;
            btnaviso.Text = "ReporteAvisoPorPeriodo";
            btnaviso.UseVisualStyleBackColor = true;
            btnaviso.Click += btnaviso_Click;
            // 
            // button6
            // 
            button6.Location = new Point(24, 446);
            button6.Name = "button6";
            button6.Size = new Size(148, 52);
            button6.TabIndex = 10;
            button6.Text = "FrmReporteTiempoPromedio";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(202, 510);
            Controls.Add(button6);
            Controls.Add(btnaviso);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Button btnaviso;
        private Button button6;
    }
}