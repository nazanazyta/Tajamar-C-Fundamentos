﻿namespace Fundamentos
{
    partial class Form17MetodoReferencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnllamada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(153, 32);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 31);
            this.txtnumero.TabIndex = 1;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(45, 203);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(123, 25);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "lblresultado";
            // 
            // btnllamada
            // 
            this.btnllamada.Location = new System.Drawing.Point(50, 103);
            this.btnllamada.Name = "btnllamada";
            this.btnllamada.Size = new System.Drawing.Size(203, 50);
            this.btnllamada.TabIndex = 3;
            this.btnllamada.Text = "Llamada";
            this.btnllamada.UseVisualStyleBackColor = true;
            this.btnllamada.Click += new System.EventHandler(this.btnllamada_Click);
            // 
            // Form17MetodoReferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 307);
            this.Controls.Add(this.btnllamada);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form17MetodoReferencia";
            this.Text = "Form17MetodoReferencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnllamada;
    }
}