namespace Fundamentos
{
    partial class Form15ColeccionNumerosListBox
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
            this.lstnumeros = new System.Windows.Forms.ListBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btndatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.txtpares = new System.Windows.Forms.TextBox();
            this.txtimpares = new System.Windows.Forms.TextBox();
            this.btnseleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números";
            // 
            // lstnumeros
            // 
            this.lstnumeros.FormattingEnabled = true;
            this.lstnumeros.ItemHeight = 25;
            this.lstnumeros.Location = new System.Drawing.Point(29, 58);
            this.lstnumeros.Name = "lstnumeros";
            this.lstnumeros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstnumeros.Size = new System.Drawing.Size(221, 304);
            this.lstnumeros.TabIndex = 1;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(291, 30);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(228, 44);
            this.btngenerar.TabIndex = 2;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btndatos
            // 
            this.btndatos.Location = new System.Drawing.Point(291, 80);
            this.btndatos.Name = "btndatos";
            this.btndatos.Size = new System.Drawing.Size(228, 46);
            this.btndatos.TabIndex = 3;
            this.btndatos.Text = "Mostrar datos";
            this.btndatos.UseVisualStyleBackColor = true;
            this.btndatos.Click += new System.EventHandler(this.btndatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Impares";
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(393, 200);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.Size = new System.Drawing.Size(126, 31);
            this.txtsuma.TabIndex = 7;
            // 
            // txtpares
            // 
            this.txtpares.Location = new System.Drawing.Point(393, 252);
            this.txtpares.Name = "txtpares";
            this.txtpares.Size = new System.Drawing.Size(126, 31);
            this.txtpares.TabIndex = 8;
            // 
            // txtimpares
            // 
            this.txtimpares.Location = new System.Drawing.Point(393, 307);
            this.txtimpares.Name = "txtimpares";
            this.txtimpares.Size = new System.Drawing.Size(126, 31);
            this.txtimpares.TabIndex = 9;
            // 
            // btnseleccionados
            // 
            this.btnseleccionados.Location = new System.Drawing.Point(291, 132);
            this.btnseleccionados.Name = "btnseleccionados";
            this.btnseleccionados.Size = new System.Drawing.Size(228, 48);
            this.btnseleccionados.TabIndex = 10;
            this.btnseleccionados.Text = "Sumar seleccionados";
            this.btnseleccionados.UseVisualStyleBackColor = true;
            this.btnseleccionados.Click += new System.EventHandler(this.btnseleccionados_Click);
            // 
            // Form15ColeccionNumerosListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 385);
            this.Controls.Add(this.btnseleccionados);
            this.Controls.Add(this.txtimpares);
            this.Controls.Add(this.txtpares);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndatos);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.lstnumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form15ColeccionNumerosListBox";
            this.Text = "Form15ColeccionNumerosListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstnumeros;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btndatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsuma;
        private System.Windows.Forms.TextBox txtpares;
        private System.Windows.Forms.TextBox txtimpares;
        private System.Windows.Forms.Button btnseleccionados;
    }
}