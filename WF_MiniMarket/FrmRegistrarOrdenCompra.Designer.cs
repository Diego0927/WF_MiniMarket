namespace WF_MiniMarket
{
    partial class FrmRegistrarOrdenCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSinIVAOrdenCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarOrdenCompraR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFechaEntregaR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTotalOrdenCompraR = new System.Windows.Forms.TextBox();
            this.txtBoxEmpleadoOrdenCompraR = new System.Windows.Forms.TextBox();
            this.txtBoxFechaPedidoR = new System.Windows.Forms.TextBox();
            this.txtBoxIVAOrdenCompraR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCodigoOrdenCompraR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxProveedorOrdenCompraR = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxProveedorOrdenCompraR);
            this.groupBox1.Controls.Add(this.textBoxSinIVAOrdenCompra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGuardarOrdenCompraR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxFechaEntregaR);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTotalOrdenCompraR);
            this.groupBox1.Controls.Add(this.txtBoxEmpleadoOrdenCompraR);
            this.groupBox1.Controls.Add(this.txtBoxFechaPedidoR);
            this.groupBox1.Controls.Add(this.txtBoxIVAOrdenCompraR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxCodigoOrdenCompraR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 444);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro orden de compra";
            // 
            // textBoxSinIVAOrdenCompra
            // 
            this.textBoxSinIVAOrdenCompra.Location = new System.Drawing.Point(616, 163);
            this.textBoxSinIVAOrdenCompra.Name = "textBoxSinIVAOrdenCompra";
            this.textBoxSinIVAOrdenCompra.Size = new System.Drawing.Size(242, 26);
            this.textBoxSinIVAOrdenCompra.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sin IVA:";
            // 
            // btnGuardarOrdenCompraR
            // 
            this.btnGuardarOrdenCompraR.Location = new System.Drawing.Point(373, 340);
            this.btnGuardarOrdenCompraR.Name = "btnGuardarOrdenCompraR";
            this.btnGuardarOrdenCompraR.Size = new System.Drawing.Size(118, 42);
            this.btnGuardarOrdenCompraR.TabIndex = 20;
            this.btnGuardarOrdenCompraR.Text = "Guardar";
            this.btnGuardarOrdenCompraR.UseVisualStyleBackColor = true;
            this.btnGuardarOrdenCompraR.Click += new System.EventHandler(this.btnGuardarOrdenCompraR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Fecha de entrega:";
            // 
            // textBoxFechaEntregaR
            // 
            this.textBoxFechaEntregaR.Location = new System.Drawing.Point(154, 163);
            this.textBoxFechaEntregaR.Name = "textBoxFechaEntregaR";
            this.textBoxFechaEntregaR.Size = new System.Drawing.Size(242, 26);
            this.textBoxFechaEntregaR.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de pedido:";
            // 
            // txtBoxTotalOrdenCompraR
            // 
            this.txtBoxTotalOrdenCompraR.Location = new System.Drawing.Point(154, 107);
            this.txtBoxTotalOrdenCompraR.Name = "txtBoxTotalOrdenCompraR";
            this.txtBoxTotalOrdenCompraR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxTotalOrdenCompraR.TabIndex = 8;
            // 
            // txtBoxEmpleadoOrdenCompraR
            // 
            this.txtBoxEmpleadoOrdenCompraR.Location = new System.Drawing.Point(154, 218);
            this.txtBoxEmpleadoOrdenCompraR.Name = "txtBoxEmpleadoOrdenCompraR";
            this.txtBoxEmpleadoOrdenCompraR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxEmpleadoOrdenCompraR.TabIndex = 6;
            // 
            // txtBoxFechaPedidoR
            // 
            this.txtBoxFechaPedidoR.Location = new System.Drawing.Point(616, 107);
            this.txtBoxFechaPedidoR.Name = "txtBoxFechaPedidoR";
            this.txtBoxFechaPedidoR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxFechaPedidoR.TabIndex = 4;
            // 
            // txtBoxIVAOrdenCompraR
            // 
            this.txtBoxIVAOrdenCompraR.Location = new System.Drawing.Point(616, 51);
            this.txtBoxIVAOrdenCompraR.Name = "txtBoxIVAOrdenCompraR";
            this.txtBoxIVAOrdenCompraR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxIVAOrdenCompraR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "IVA:";
            // 
            // txtBoxCodigoOrdenCompraR
            // 
            this.txtBoxCodigoOrdenCompraR.Location = new System.Drawing.Point(154, 51);
            this.txtBoxCodigoOrdenCompraR.Name = "txtBoxCodigoOrdenCompraR";
            this.txtBoxCodigoOrdenCompraR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxCodigoOrdenCompraR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de orden:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Proveedor:";
            // 
            // textBoxProveedorOrdenCompraR
            // 
            this.textBoxProveedorOrdenCompraR.Location = new System.Drawing.Point(616, 218);
            this.textBoxProveedorOrdenCompraR.Name = "textBoxProveedorOrdenCompraR";
            this.textBoxProveedorOrdenCompraR.Size = new System.Drawing.Size(242, 26);
            this.textBoxProveedorOrdenCompraR.TabIndex = 24;
            // 
            // FrmRegistrarOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 518);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarOrdenCompra";
            this.Text = "FrmRegistrarOrdenCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSinIVAOrdenCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarOrdenCompraR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxFechaEntregaR;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTotalOrdenCompraR;
        private System.Windows.Forms.TextBox txtBoxEmpleadoOrdenCompraR;
        private System.Windows.Forms.TextBox txtBoxFechaPedidoR;
        private System.Windows.Forms.TextBox txtBoxIVAOrdenCompraR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCodigoOrdenCompraR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxProveedorOrdenCompraR;
    }
}