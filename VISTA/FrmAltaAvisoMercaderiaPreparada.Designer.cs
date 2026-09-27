namespace VISTA
{
    partial class FrmAltaAvisoMercaderiaPreparada
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
            txtidavisos = new TextBox();
            btnagregar = new Button();
            label1 = new Label();
            txtidnota = new TextBox();
            txtidusuario = new TextBox();
            txtfecha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btncancelar = new Button();
            SuspendLayout();
            // 
            // txtidavisos
            // 
            txtidavisos.Location = new Point(181, 91);
            txtidavisos.Name = "txtidavisos";
            txtidavisos.Size = new Size(100, 23);
            txtidavisos.TabIndex = 0;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(92, 221);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(83, 34);
            btnagregar.TabIndex = 1;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 91);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 2;
            label1.Text = "IdAvisosMercaderiaPreparada";
            // 
            // txtidnota
            // 
            txtidnota.Location = new Point(126, 117);
            txtidnota.Name = "txtidnota";
            txtidnota.Size = new Size(100, 23);
            txtidnota.TabIndex = 3;
            // 
            // txtidusuario
            // 
            txtidusuario.Location = new Point(126, 146);
            txtidusuario.Name = "txtidusuario";
            txtidusuario.Size = new Size(100, 23);
            txtidusuario.TabIndex = 4;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(126, 175);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(118, 23);
            txtfecha.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 120);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 6;
            label2.Text = "IdNotaPedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 149);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "IdUsuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 178);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "FechaEmision";
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(181, 221);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(83, 34);
            btncancelar.TabIndex = 9;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += btncancelar_Click;
            // 
            // FrmAltaAvisoMercaderiaPreparada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 307);
            Controls.Add(btncancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtfecha);
            Controls.Add(txtidusuario);
            Controls.Add(txtidnota);
            Controls.Add(label1);
            Controls.Add(btnagregar);
            Controls.Add(txtidavisos);
            Name = "FrmAltaAvisoMercaderiaPreparada";
            Text = "FrmAltaAvisoMercaderiaPreparada";
            Load += FrmAltaAvisoMercaderiaPreparada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtidavisos;
        private Button btnagregar;
        private Label label1;
        private TextBox txtidnota;
        private TextBox txtidusuario;
        private TextBox txtfecha;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btncancelar;
    }
}