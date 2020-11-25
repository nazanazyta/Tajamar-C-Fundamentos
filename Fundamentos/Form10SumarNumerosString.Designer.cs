namespace Fundamentos
{
    partial class Form10SumarNumerosString
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
            this.txtcajanumeros = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.lblsuma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Números: ";
            // 
            // txtcajanumeros
            // 
            this.txtcajanumeros.Location = new System.Drawing.Point(153, 27);
            this.txtcajanumeros.Name = "txtcajanumeros";
            this.txtcajanumeros.Size = new System.Drawing.Size(200, 35);
            this.txtcajanumeros.TabIndex = 1;
            // 
            // btnsumar
            // 
            this.btnsumar.Location = new System.Drawing.Point(62, 78);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(265, 48);
            this.btnsumar.TabIndex = 2;
            this.btnsumar.Text = "Sumar números";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblsuma.Location = new System.Drawing.Point(134, 155);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(97, 29);
            this.lblsuma.TabIndex = 3;
            this.lblsuma.Text = "lblsuma";
            // 
            // Form10SumarNumerosString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 243);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txtcajanumeros);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form10SumarNumerosString";
            this.Text = "Form10SumarNumeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcajanumeros;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Label lblsuma;
    }
}