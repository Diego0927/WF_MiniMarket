namespace WF_MiniMarket
{
    partial class FrmRegistrarEmpleado
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
            this.btnGuardarEmpleadoR = new System.Windows.Forms.Button();
            this.comboBoxTipoDocEmpleadoR = new System.Windows.Forms.ComboBox();
            this.txtBoxMinimarketEmpleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtBoxNumDocumentoEmpleado = new System.Windows.Forms.TextBox();
            this.txtBoxClaveEmpleado = new System.Windows.Forms.TextBox();
            this.txtBoxCorreoEmpleado = new System.Windows.Forms.TextBox();
            this.txtBoxApellidosEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNombresEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarEmpleadoR);
            this.groupBox1.Controls.Add(this.comboBoxTipoDocEmpleadoR);
            this.groupBox1.Controls.Add(this.txtBoxMinimarketEmpleado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxTelefonoEmpleado);
            this.groupBox1.Controls.Add(this.txtBoxNumDocumentoEmpleado);
            this.groupBox1.Controls.Add(this.txtBoxClaveEmpleado);
            this.groupBox1.Controls.Add(this.txtBoxCorreoEmpleado);
            this.groupBox1.Controls.Add(this.txtBoxApellidosEmpleado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxNombresEmpleado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 402);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Empleado";
            // 
            // btnGuardarEmpleadoR
            // 
            this.btnGuardarEmpleadoR.Location = new System.Drawing.Point(378, 317);
            this.btnGuardarEmpleadoR.Name = "btnGuardarEmpleadoR";
            this.btnGuardarEmpleadoR.Size = new System.Drawing.Size(118, 42);
            this.btnGuardarEmpleadoR.TabIndex = 22;
            this.btnGuardarEmpleadoR.Text = "Guardar";
            this.btnGuardarEmpleadoR.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleadoR.Click += new System.EventHandler(this.btnGuardarEmpleadoR_Click);
            // 
            // comboBoxTipoDocEmpleadoR
            // 
            this.comboBoxTipoDocEmpleadoR.FormattingEnabled = true;
            this.comboBoxTipoDocEmpleadoR.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "PEP",
            "PPT",
            "CE",
            "Otro"});
            this.comboBoxTipoDocEmpleadoR.Location = new System.Drawing.Point(169, 56);
            this.comboBoxTipoDocEmpleadoR.Name = "comboBoxTipoDocEmpleadoR";
            this.comboBoxTipoDocEmpleadoR.Size = new System.Drawing.Size(254, 28);
            this.comboBoxTipoDocEmpleadoR.TabIndex = 21;
            this.comboBoxTipoDocEmpleadoR.Text = "Seleccione";
            // 
            // txtBoxMinimarketEmpleado
            // 
            this.txtBoxMinimarketEmpleado.Location = new System.Drawing.Point(660, 245);
            this.txtBoxMinimarketEmpleado.Name = "txtBoxMinimarketEmpleado";
            this.txtBoxMinimarketEmpleado.Size = new System.Drawing.Size(254, 26);
            this.txtBoxMinimarketEmpleado.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "MiniMarket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Número documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo";
            // 
            // txtBoxTelefonoEmpleado
            // 
            this.txtBoxTelefonoEmpleado.Location = new System.Drawing.Point(660, 179);
            this.txtBoxTelefonoEmpleado.Name = "txtBoxTelefonoEmpleado";
            this.txtBoxTelefonoEmpleado.Size = new System.Drawing.Size(254, 26);
            this.txtBoxTelefonoEmpleado.TabIndex = 8;
            // 
            // txtBoxNumDocumentoEmpleado
            // 
            this.txtBoxNumDocumentoEmpleado.Location = new System.Drawing.Point(660, 56);
            this.txtBoxNumDocumentoEmpleado.Name = "txtBoxNumDocumentoEmpleado";
            this.txtBoxNumDocumentoEmpleado.Size = new System.Drawing.Size(254, 26);
            this.txtBoxNumDocumentoEmpleado.TabIndex = 6;
            // 
            // txtBoxClaveEmpleado
            // 
            this.txtBoxClaveEmpleado.Location = new System.Drawing.Point(169, 245);
            this.txtBoxClaveEmpleado.Name = "txtBoxClaveEmpleado";
            this.txtBoxClaveEmpleado.Size = new System.Drawing.Size(254, 26);
            this.txtBoxClaveEmpleado.TabIndex = 5;
            // 
            // txtBoxCorreoEmpleado
            // 
            this.txtBoxCorreoEmpleado.Location = new System.Drawing.Point(169, 179);
            this.txtBoxCorreoEmpleado.Name = "txtBoxCorreoEmpleado";
            this.txtBoxCorreoEmpleado.Size = new System.Drawing.Size(254, 26);
            this.txtBoxCorreoEmpleado.TabIndex = 4;
            // 
            // txtBoxApellidosEmpleado
            // 
            this.txtBoxApellidosEmpleado.Location = new System.Drawing.Point(660, 119);
            this.txtBoxApellidosEmpleado.Name = "txtBoxApellidosEmpleado";
            this.txtBoxApellidosEmpleado.Size = new System.Drawing.Size(254, 26);
            this.txtBoxApellidosEmpleado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos";
            // 
            // txtBoxNombresEmpleado
            // 
            this.txtBoxNombresEmpleado.Location = new System.Drawing.Point(169, 119);
            this.txtBoxNombresEmpleado.Name = "txtBoxNombresEmpleado";
            this.txtBoxNombresEmpleado.Size = new System.Drawing.Size(254, 26);
            this.txtBoxNombresEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // FrmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 475);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarEmpleado";
            this.Text = "FrmRegistrarEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxMinimarketEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtBoxNumDocumentoEmpleado;
        private System.Windows.Forms.TextBox txtBoxClaveEmpleado;
        private System.Windows.Forms.TextBox txtBoxCorreoEmpleado;
        private System.Windows.Forms.TextBox txtBoxApellidosEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNombresEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoDocEmpleadoR;
        private System.Windows.Forms.Button btnGuardarEmpleadoR;
    }
}