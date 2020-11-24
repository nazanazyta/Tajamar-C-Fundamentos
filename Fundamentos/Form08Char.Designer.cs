namespace Fundamentos
{
    partial class Form08Char
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
            this.txtletras = new System.Windows.Forms.TextBox();
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsimbolos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpuntuacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrecorrerascii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Letras";
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(32, 56);
            this.txtletras.Multiline = true;
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(347, 183);
            this.txtletras.TabIndex = 1;
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(32, 302);
            this.txtnumeros.Multiline = true;
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(347, 183);
            this.txtnumeros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Números";
            // 
            // txtsimbolos
            // 
            this.txtsimbolos.Location = new System.Drawing.Point(418, 56);
            this.txtsimbolos.Multiline = true;
            this.txtsimbolos.Name = "txtsimbolos";
            this.txtsimbolos.Size = new System.Drawing.Size(347, 183);
            this.txtsimbolos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Símbolos";
            // 
            // txtpuntuacion
            // 
            this.txtpuntuacion.Location = new System.Drawing.Point(418, 302);
            this.txtpuntuacion.Multiline = true;
            this.txtpuntuacion.Name = "txtpuntuacion";
            this.txtpuntuacion.Size = new System.Drawing.Size(347, 183);
            this.txtpuntuacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Puntuación";
            // 
            // btnrecorrerascii
            // 
            this.btnrecorrerascii.Location = new System.Drawing.Point(177, 510);
            this.btnrecorrerascii.Name = "btnrecorrerascii";
            this.btnrecorrerascii.Size = new System.Drawing.Size(424, 61);
            this.btnrecorrerascii.TabIndex = 8;
            this.btnrecorrerascii.Text = "Recorrer ASCII";
            this.btnrecorrerascii.UseVisualStyleBackColor = true;
            this.btnrecorrerascii.Click += new System.EventHandler(this.btnrecorrerascii_Click);
            // 
            // Form08Char
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 583);
            this.Controls.Add(this.btnrecorrerascii);
            this.Controls.Add(this.txtpuntuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsimbolos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form08Char";
            this.Text = "Form08Char";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsimbolos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpuntuacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrecorrerascii;
    }
}