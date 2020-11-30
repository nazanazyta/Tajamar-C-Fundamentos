namespace Fundamentos
{
    partial class Form25SorteoPrimitiva
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btniniciar = new System.Windows.Forms.Button();
            this.btnsorteo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstpremiados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 391);
            this.panel1.TabIndex = 0;
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(479, 76);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(148, 60);
            this.btniniciar.TabIndex = 1;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btnsorteo
            // 
            this.btnsorteo.Location = new System.Drawing.Point(479, 177);
            this.btnsorteo.Name = "btnsorteo";
            this.btnsorteo.Size = new System.Drawing.Size(148, 60);
            this.btnsorteo.TabIndex = 2;
            this.btnsorteo.Text = "Sorteo";
            this.btnsorteo.UseVisualStyleBackColor = true;
            this.btnsorteo.Click += new System.EventHandler(this.btnsorteo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Números premiados";
            // 
            // lstpremiados
            // 
            this.lstpremiados.FormattingEnabled = true;
            this.lstpremiados.ItemHeight = 25;
            this.lstpremiados.Location = new System.Drawing.Point(686, 52);
            this.lstpremiados.Name = "lstpremiados";
            this.lstpremiados.Size = new System.Drawing.Size(198, 254);
            this.lstpremiados.TabIndex = 4;
            // 
            // Form25SorteoPrimitiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 437);
            this.Controls.Add(this.lstpremiados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsorteo);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form25SorteoPrimitiva";
            this.Text = "Form25SorteoPrimitiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Button btnsorteo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstpremiados;
    }
}