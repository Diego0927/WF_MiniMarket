namespace WF_MiniMarket
{
    partial class FrmRegistrarCliente
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
            this.comboBoxTipoDocClienteR = new System.Windows.Forms.ComboBox();
            this.btnGuardarClienteR = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxApellidosClienteR = new System.Windows.Forms.TextBox();
            this.txtBoxCelularClienteR = new System.Windows.Forms.TextBox();
            this.txtBoxCorreoClienteR = new System.Windows.Forms.TextBox();
            this.txtBoxNombresClienteR = new System.Windows.Forms.TextBox();
            this.txtBoxIdentificacionClienteR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTipoDocClienteR);
            this.groupBox1.Controls.Add(this.btnGuardarClienteR);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxApellidosClienteR);
            this.groupBox1.Controls.Add(this.txtBoxCelularClienteR);
            this.groupBox1.Controls.Add(this.txtBoxCorreoClienteR);
            this.groupBox1.Controls.Add(this.txtBoxNombresClienteR);
            this.groupBox1.Controls.Add(this.txtBoxIdentificacionClienteR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 402);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Cliente";
            // 
            // comboBoxTipoDocClienteR
            // 
            this.comboBoxTipoDocClienteR.FormattingEnabled = true;
            this.comboBoxTipoDocClienteR.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "PEP",
            "PPT",
            "CE",
            "Otro"});
            this.comboBoxTipoDocClienteR.Location = new System.Drawing.Point(184, 64);
            this.comboBoxTipoDocClienteR.Name = "comboBoxTipoDocClienteR";
            this.comboBoxTipoDocClienteR.Size = new System.Drawing.Size(254, 28);
            this.comboBoxTipoDocClienteR.TabIndex = 20;
            this.comboBoxTipoDocClienteR.Text = "Seleccione";
            // 
            // btnGuardarClienteR
            // 
            this.btnGuardarClienteR.Location = new System.Drawing.Point(411, 296);
            this.btnGuardarClienteR.Name = "btnGuardarClienteR";
            this.btnGuardarClienteR.Size = new System.Drawing.Size(118, 42);
            this.btnGuardarClienteR.TabIndex = 19;
            this.btnGuardarClienteR.Text = "Guardar";
            this.btnGuardarClienteR.UseVisualStyleBackColor = true;
            this.btnGuardarClienteR.Click += new System.EventHandler(this.btnGuardarClienteR_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombres";
            // 
            // txtBoxApellidosClienteR
            // 
            this.txtBoxApellidosClienteR.Location = new System.Drawing.Point(660, 112);
            this.txtBoxApellidosClienteR.Name = "txtBoxApellidosClienteR";
            this.txtBoxApellidosClienteR.Size = new System.Drawing.Size(254, 26);
            this.txtBoxApellidosClienteR.TabIndex = 8;
            // 
            // txtBoxCelularClienteR
            // 
            this.txtBoxCelularClienteR.Location = new System.Drawing.Point(660, 170);
            this.txtBoxCelularClienteR.Name = "txtBoxCelularClienteR";
            this.txtBoxCelularClienteR.Size = new System.Drawing.Size(254, 26);
            this.txtBoxCelularClienteR.TabIndex = 6;
            // 
            // txtBoxCorreoClienteR
            // 
            this.txtBoxCorreoClienteR.Location = new System.Drawing.Point(184, 176);
            this.txtBoxCorreoClienteR.Name = "txtBoxCorreoClienteR";
            this.txtBoxCorreoClienteR.Size = new System.Drawing.Size(254, 26);
            this.txtBoxCorreoClienteR.TabIndex = 5;
            // 
            // txtBoxNombresClienteR
            // 
            this.txtBoxNombresClienteR.Location = new System.Drawing.Point(184, 118);
            this.txtBoxNombresClienteR.Name = "txtBoxNombresClienteR";
            this.txtBoxNombresClienteR.Size = new System.Drawing.Size(254, 26);
            this.txtBoxNombresClienteR.TabIndex = 4;
            // 
            // txtBoxIdentificacionClienteR
            // 
            this.txtBoxIdentificacionClienteR.Location = new System.Drawing.Point(660, 58);
            this.txtBoxIdentificacionClienteR.Name = "txtBoxIdentificacionClienteR";
            this.txtBoxIdentificacionClienteR.Size = new System.Drawing.Size(254, 26);
            this.txtBoxIdentificacionClienteR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo De Documento";
            // 
            // FrmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 471);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarCliente";
            this.Text = "FrmRegistrarCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxApellidosClienteR;
        private System.Windows.Forms.TextBox txtBoxCelularClienteR;
        private System.Windows.Forms.TextBox txtBoxCorreoClienteR;
        private System.Windows.Forms.TextBox txtBoxNombresClienteR;
        private System.Windows.Forms.TextBox txtBoxIdentificacionClienteR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarClienteR;
        private System.Windows.Forms.ComboBox comboBoxTipoDocClienteR;
    }
}