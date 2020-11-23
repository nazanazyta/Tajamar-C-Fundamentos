namespace Fundamentos
{
    partial class Form04CambiarForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtposicionx = new System.Windows.Forms.TextBox();
            this.txtposiciony = new System.Windows.Forms.TextBox();
            this.btnposicion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncolor = new System.Windows.Forms.Button();
            this.txtrojo = new System.Windows.Forms.TextBox();
            this.txtverde = new System.Windows.Forms.TextBox();
            this.txtazul = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posición X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posición Y:";
            // 
            // txtposicionx
            // 
            this.txtposicionx.Location = new System.Drawing.Point(197, 70);
            this.txtposicionx.Name = "txtposicionx";
            this.txtposicionx.Size = new System.Drawing.Size(100, 26);
            this.txtposicionx.TabIndex = 2;
            // 
            // txtposiciony
            // 
            this.txtposiciony.Location = new System.Drawing.Point(197, 127);
            this.txtposiciony.Name = "txtposiciony";
            this.txtposiciony.Size = new System.Drawing.Size(100, 26);
            this.txtposiciony.TabIndex = 3;
            // 
            // btnposicion
            // 
            this.btnposicion.Location = new System.Drawing.Point(151, 220);
            this.btnposicion.Name = "btnposicion";
            this.btnposicion.Size = new System.Drawing.Size(109, 39);
            this.btnposicion.TabIndex = 4;
            this.btnposicion.Text = "Posición";
            this.btnposicion.UseVisualStyleBackColor = true;
            this.btnposicion.Click += new System.EventHandler(this.btnposicion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rojo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Verde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Azul";
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(387, 220);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(109, 39);
            this.btncolor.TabIndex = 8;
            this.btncolor.Text = "Color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // txtrojo
            // 
            this.txtrojo.Location = new System.Drawing.Point(424, 70);
            this.txtrojo.Name = "txtrojo";
            this.txtrojo.Size = new System.Drawing.Size(100, 26);
            this.txtrojo.TabIndex = 9;
            // 
            // txtverde
            // 
            this.txtverde.Location = new System.Drawing.Point(424, 112);
            this.txtverde.Name = "txtverde";
            this.txtverde.Size = new System.Drawing.Size(100, 26);
            this.txtverde.TabIndex = 10;
            // 
            // txtazul
            // 
            this.txtazul.Location = new System.Drawing.Point(424, 154);
            this.txtazul.Name = "txtazul";
            this.txtazul.Size = new System.Drawing.Size(100, 26);
            this.txtazul.TabIndex = 11;
            // 
            // Form04CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 382);
            this.Controls.Add(this.txtazul);
            this.Controls.Add(this.txtverde);
            this.Controls.Add(this.txtrojo);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnposicion);
            this.Controls.Add(this.txtposiciony);
            this.Controls.Add(this.txtposicionx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form04CambiarForm";
            this.Text = "Form04CambiarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtposicionx;
        private System.Windows.Forms.TextBox txtposiciony;
        private System.Windows.Forms.Button btnposicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.TextBox txtrojo;
        private System.Windows.Forms.TextBox txtverde;
        private System.Windows.Forms.TextBox txtazul;
    }
}