namespace Fundamentos
{
    partial class Form23TemperaturasAnuales
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
            this.btngenerarmeses = new System.Windows.Forms.Button();
            this.btnmostrardatos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaxima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtminima = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmedia = new System.Windows.Forms.TextBox();
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
            this.lstmeses.Location = new System.Drawing.Point(18, 42);
            this.lstmeses.Name = "lstmeses";
            this.lstmeses.Size = new System.Drawing.Size(232, 329);
            this.lstmeses.TabIndex = 1;
            // 
            // btngenerarmeses
            // 
            this.btngenerarmeses.Location = new System.Drawing.Point(279, 42);
            this.btngenerarmeses.Name = "btngenerarmeses";
            this.btngenerarmeses.Size = new System.Drawing.Size(194, 49);
            this.btngenerarmeses.TabIndex = 2;
            this.btngenerarmeses.Text = "Generar meses";
            this.btngenerarmeses.UseVisualStyleBackColor = true;
            this.btngenerarmeses.Click += new System.EventHandler(this.btngenerarmeses_Click);
            // 
            // btnmostrardatos
            // 
            this.btnmostrardatos.Location = new System.Drawing.Point(278, 97);
            this.btnmostrardatos.Name = "btnmostrardatos";
            this.btnmostrardatos.Size = new System.Drawing.Size(194, 49);
            this.btnmostrardatos.TabIndex = 3;
            this.btnmostrardatos.Text = "Mostrar datos";
            this.btnmostrardatos.UseVisualStyleBackColor = true;
            this.btnmostrardatos.Click += new System.EventHandler(this.btnmostrardatos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperatura máxima";
            // 
            // txtmaxima
            // 
            this.txtmaxima.Location = new System.Drawing.Point(279, 190);
            this.txtmaxima.Name = "txtmaxima";
            this.txtmaxima.Size = new System.Drawing.Size(194, 31);
            this.txtmaxima.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Temperatura mínima";
            // 
            // txtminima
            // 
            this.txtminima.Location = new System.Drawing.Point(279, 263);
            this.txtminima.Name = "txtminima";
            this.txtminima.Size = new System.Drawing.Size(194, 31);
            this.txtminima.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperatura media";
            // 
            // txtmedia
            // 
            this.txtmedia.Location = new System.Drawing.Point(279, 337);
            this.txtmedia.Name = "txtmedia";
            this.txtmedia.Size = new System.Drawing.Size(193, 31);
            this.txtmedia.TabIndex = 9;
            // 
            // Form23TemperaturasAnuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 401);
            this.Controls.Add(this.txtmedia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtminima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmaxima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmostrardatos);
            this.Controls.Add(this.btngenerarmeses);
            this.Controls.Add(this.lstmeses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form23TemperaturasAnuales";
            this.Text = "Form23TemperaturasAnuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstmeses;
        private System.Windows.Forms.Button btngenerarmeses;
        private System.Windows.Forms.Button btnmostrardatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaxima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtminima;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmedia;
    }
}