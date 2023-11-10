namespace WF_MiniMarket
{
    partial class FrmRegistrarProducto
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
            this.comboBoxUndMedidaRegistroProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarProductoR = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDescripcionProductoR = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStockProductoR = new System.Windows.Forms.TextBox();
            this.txtBoxCategoriaProductoR = new System.Windows.Forms.TextBox();
            this.txtBoxPVPProductoR = new System.Windows.Forms.TextBox();
            this.txtBoxMarcaProductoR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNombreProductoR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxUndMedidaRegistroProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGuardarProductoR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxDescripcionProductoR);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxStockProductoR);
            this.groupBox1.Controls.Add(this.txtBoxCategoriaProductoR);
            this.groupBox1.Controls.Add(this.txtBoxPVPProductoR);
            this.groupBox1.Controls.Add(this.txtBoxMarcaProductoR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxNombreProductoR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 444);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Producto";
            // 
            // comboBoxUndMedidaRegistroProducto
            // 
            this.comboBoxUndMedidaRegistroProducto.FormattingEnabled = true;
            this.comboBoxUndMedidaRegistroProducto.Items.AddRange(new object[] {
            "UND",
            "gr"});
            this.comboBoxUndMedidaRegistroProducto.Location = new System.Drawing.Point(616, 166);
            this.comboBoxUndMedidaRegistroProducto.Name = "comboBoxUndMedidaRegistroProducto";
            this.comboBoxUndMedidaRegistroProducto.Size = new System.Drawing.Size(242, 28);
            this.comboBoxUndMedidaRegistroProducto.TabIndex = 23;
            this.comboBoxUndMedidaRegistroProducto.Text = "Seleccione";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Unidad De Medida:";
            // 
            // btnGuardarProductoR
            // 
            this.btnGuardarProductoR.Location = new System.Drawing.Point(373, 340);
            this.btnGuardarProductoR.Name = "btnGuardarProductoR";
            this.btnGuardarProductoR.Size = new System.Drawing.Size(118, 42);
            this.btnGuardarProductoR.TabIndex = 20;
            this.btnGuardarProductoR.Text = "Guardar";
            this.btnGuardarProductoR.UseVisualStyleBackColor = true;
            this.btnGuardarProductoR.Click += new System.EventHandler(this.btnGuardarProductoR_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Descripción:";
            // 
            // textBoxDescripcionProductoR
            // 
            this.textBoxDescripcionProductoR.Location = new System.Drawing.Point(150, 166);
            this.textBoxDescripcionProductoR.Name = "textBoxDescripcionProductoR";
            this.textBoxDescripcionProductoR.Size = new System.Drawing.Size(242, 26);
            this.textBoxDescripcionProductoR.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "PVP:";
            // 
            // txtBoxStockProductoR
            // 
            this.txtBoxStockProductoR.Location = new System.Drawing.Point(150, 110);
            this.txtBoxStockProductoR.Name = "txtBoxStockProductoR";
            this.txtBoxStockProductoR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxStockProductoR.TabIndex = 8;
            // 
            // txtBoxCategoriaProductoR
            // 
            this.txtBoxCategoriaProductoR.Location = new System.Drawing.Point(150, 221);
            this.txtBoxCategoriaProductoR.Name = "txtBoxCategoriaProductoR";
            this.txtBoxCategoriaProductoR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxCategoriaProductoR.TabIndex = 6;
            // 
            // txtBoxPVPProductoR
            // 
            this.txtBoxPVPProductoR.Location = new System.Drawing.Point(616, 110);
            this.txtBoxPVPProductoR.Name = "txtBoxPVPProductoR";
            this.txtBoxPVPProductoR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxPVPProductoR.TabIndex = 4;
            // 
            // txtBoxMarcaProductoR
            // 
            this.txtBoxMarcaProductoR.Location = new System.Drawing.Point(616, 51);
            this.txtBoxMarcaProductoR.Name = "txtBoxMarcaProductoR";
            this.txtBoxMarcaProductoR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxMarcaProductoR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // txtBoxNombreProductoR
            // 
            this.txtBoxNombreProductoR.Location = new System.Drawing.Point(150, 54);
            this.txtBoxNombreProductoR.Name = "txtBoxNombreProductoR";
            this.txtBoxNombreProductoR.Size = new System.Drawing.Size(242, 26);
            this.txtBoxNombreProductoR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 489);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxStockProductoR;
        private System.Windows.Forms.TextBox txtBoxCategoriaProductoR;
        private System.Windows.Forms.TextBox txtBoxPVPProductoR;
        private System.Windows.Forms.TextBox txtBoxMarcaProductoR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNombreProductoR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDescripcionProductoR;
        private System.Windows.Forms.Button btnGuardarProductoR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUndMedidaRegistroProducto;
    }
}