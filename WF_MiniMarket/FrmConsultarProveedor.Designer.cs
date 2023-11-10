namespace WF_MiniMarket
{
    partial class FrmConsultarProveedor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDepartamentoProveedorR = new System.Windows.Forms.TextBox();
            this.textBoxCiudadProveedorR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNomenclaturaProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxCorreoProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtBoxRazonSocialProveedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNITProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProveedores);
            this.groupBox2.Location = new System.Drawing.Point(13, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 231);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestión de Proveedores";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(19, 19);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(941, 206);
            this.dgvProveedores.TabIndex = 2;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDepartamentoProveedorR);
            this.groupBox1.Controls.Add(this.textBoxCiudadProveedorR);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxNomenclaturaProveedor);
            this.groupBox1.Controls.Add(this.txtBoxCorreoProveedor);
            this.groupBox1.Controls.Add(this.txtBoxTelefonoProveedor);
            this.groupBox1.Controls.Add(this.txtBoxRazonSocialProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxNITProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 226);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar Proveedor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Departamento";
            // 
            // textBoxDepartamentoProveedorR
            // 
            this.textBoxDepartamentoProveedorR.Location = new System.Drawing.Point(158, 168);
            this.textBoxDepartamentoProveedorR.Name = "textBoxDepartamentoProveedorR";
            this.textBoxDepartamentoProveedorR.Size = new System.Drawing.Size(254, 26);
            this.textBoxDepartamentoProveedorR.TabIndex = 18;
            // 
            // textBoxCiudadProveedorR
            // 
            this.textBoxCiudadProveedorR.Location = new System.Drawing.Point(626, 124);
            this.textBoxCiudadProveedorR.Name = "textBoxCiudadProveedorR";
            this.textBoxCiudadProveedorR.Size = new System.Drawing.Size(254, 26);
            this.textBoxCiudadProveedorR.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ciudad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nomenclatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teléfono";
            // 
            // txtBoxNomenclaturaProveedor
            // 
            this.txtBoxNomenclaturaProveedor.Location = new System.Drawing.Point(158, 127);
            this.txtBoxNomenclaturaProveedor.Name = "txtBoxNomenclaturaProveedor";
            this.txtBoxNomenclaturaProveedor.Size = new System.Drawing.Size(254, 26);
            this.txtBoxNomenclaturaProveedor.TabIndex = 8;
            // 
            // txtBoxCorreoProveedor
            // 
            this.txtBoxCorreoProveedor.Location = new System.Drawing.Point(626, 86);
            this.txtBoxCorreoProveedor.Name = "txtBoxCorreoProveedor";
            this.txtBoxCorreoProveedor.Size = new System.Drawing.Size(254, 26);
            this.txtBoxCorreoProveedor.TabIndex = 5;
            // 
            // txtBoxTelefonoProveedor
            // 
            this.txtBoxTelefonoProveedor.Location = new System.Drawing.Point(158, 86);
            this.txtBoxTelefonoProveedor.Name = "txtBoxTelefonoProveedor";
            this.txtBoxTelefonoProveedor.Size = new System.Drawing.Size(254, 26);
            this.txtBoxTelefonoProveedor.TabIndex = 4;
            // 
            // txtBoxRazonSocialProveedor
            // 
            this.txtBoxRazonSocialProveedor.Location = new System.Drawing.Point(626, 46);
            this.txtBoxRazonSocialProveedor.Name = "txtBoxRazonSocialProveedor";
            this.txtBoxRazonSocialProveedor.Size = new System.Drawing.Size(254, 26);
            this.txtBoxRazonSocialProveedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social";
            // 
            // txtBoxNITProveedor
            // 
            this.txtBoxNITProveedor.Location = new System.Drawing.Point(158, 52);
            this.txtBoxNITProveedor.Name = "txtBoxNITProveedor";
            this.txtBoxNITProveedor.Size = new System.Drawing.Size(254, 26);
            this.txtBoxNITProveedor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // FrmConsultarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultarProveedor";
            this.Text = "FrmConsultarProveedores";
            this.Load += new System.EventHandler(this.FrmConsultarProveedores_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDepartamentoProveedorR;
        private System.Windows.Forms.TextBox textBoxCiudadProveedorR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNomenclaturaProveedor;
        private System.Windows.Forms.TextBox txtBoxCorreoProveedor;
        private System.Windows.Forms.TextBox txtBoxTelefonoProveedor;
        private System.Windows.Forms.TextBox txtBoxRazonSocialProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNITProveedor;
        private System.Windows.Forms.Label label1;
    }
}