﻿namespace WF_MiniMarket
{
    partial class FrmRegistrarCategoria
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
            this.btnGuardarCategoriaR = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxDescripcionCategoriaR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNombreCategoriaR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarCategoriaR);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBoxDescripcionCategoriaR);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxNombreCategoriaR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Categoria";
            // 
            // btnGuardarCategoriaR
            // 
            this.btnGuardarCategoriaR.Location = new System.Drawing.Point(209, 201);
            this.btnGuardarCategoriaR.Name = "btnGuardarCategoriaR";
            this.btnGuardarCategoriaR.Size = new System.Drawing.Size(118, 42);
            this.btnGuardarCategoriaR.TabIndex = 18;
            this.btnGuardarCategoriaR.Text = "Guardar";
            this.btnGuardarCategoriaR.UseVisualStyleBackColor = true;
            this.btnGuardarCategoriaR.Click += new System.EventHandler(this.btnGuardarCategoriaR_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(648, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 14;
            // 
            // txtBoxDescripcionCategoriaR
            // 
            this.txtBoxDescripcionCategoriaR.Location = new System.Drawing.Point(146, 117);
            this.txtBoxDescripcionCategoriaR.Name = "txtBoxDescripcionCategoriaR";
            this.txtBoxDescripcionCategoriaR.Size = new System.Drawing.Size(254, 26);
            this.txtBoxDescripcionCategoriaR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // txtBoxNombreCategoriaR
            // 
            this.txtBoxNombreCategoriaR.Location = new System.Drawing.Point(146, 58);
            this.txtBoxNombreCategoriaR.Name = "txtBoxNombreCategoriaR";
            this.txtBoxNombreCategoriaR.Size = new System.Drawing.Size(254, 26);
            this.txtBoxNombreCategoriaR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // FrmRegistrarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 440);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistrarCategoria";
            this.Text = "RegistrarCategoria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarCategoriaR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxDescripcionCategoriaR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNombreCategoriaR;
        private System.Windows.Forms.Label label1;
    }
}