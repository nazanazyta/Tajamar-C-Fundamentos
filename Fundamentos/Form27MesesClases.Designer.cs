namespace Fundamentos
{
    partial class Form27MesesClases
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
            this.lstmeses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaxima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtminima = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meses";
            // 
            // lstmeses
            // 
            this.lstmeses.FormattingEnabled = true;
            this.lstmeses.ItemHeight = 25;
            this.lstmeses.Location = new System.Drawing.Point(18, 50);
            this.lstmeses.Name = "lstmeses";
            this.lstmeses.Size = new System.Drawing.Size(237, 429);
            this.lstmeses.TabIndex = 1;
            this.lstmeses.SelectedIndexChanged += new System.EventHandler(this.lstmeses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(293, 78);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(152, 31);
            this.txtnombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Máxima";
            // 
            // txtmaxima
            // 
            this.txtmaxima.Location = new System.Drawing.Point(293, 164);
            this.txtmaxima.Name = "txtmaxima";
            this.txtmaxima.Size = new System.Drawing.Size(152, 31);
            this.txtmaxima.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mínima";
            // 
            // txtminima
            // 
            this.txtminima.Location = new System.Drawing.Point(293, 253);
            this.txtminima.Name = "txtminima";
            this.txtminima.Size = new System.Drawing.Size(152, 31);
            this.txtminima.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Media";
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(293, 338);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(152, 31);
            this.txtmedia.TabIndex = 9;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(293, 413);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(152, 48);
            this.btngenerar.TabIndex = 10;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // Form27MesesClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 509);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtminima);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmaxima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstmeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form27MesesClases";
            this.Text = "Form27MesesClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstmeses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaxima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtminima;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmedia;
        private System.Windows.Forms.Button btngenerar;
    }
}