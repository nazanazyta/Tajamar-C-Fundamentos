namespace Fundamentos
{
    partial class Form12StringBuilder
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
            this.txttexto = new System.Windows.Forms.RichTextBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.btnreversestring = new System.Windows.Forms.Button();
            this.btnreversestringbuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(17, 53);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(450, 329);
            this.txttexto.TabIndex = 1;
            this.txttexto.Text = "";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltiempo.Location = new System.Drawing.Point(12, 406);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(98, 25);
            this.lbltiempo.TabIndex = 2;
            this.lbltiempo.Text = "lbltiempo";
            // 
            // btnreversestring
            // 
            this.btnreversestring.Location = new System.Drawing.Point(487, 53);
            this.btnreversestring.Name = "btnreversestring";
            this.btnreversestring.Size = new System.Drawing.Size(172, 63);
            this.btnreversestring.TabIndex = 3;
            this.btnreversestring.Text = "Reverse String";
            this.btnreversestring.UseVisualStyleBackColor = true;
            this.btnreversestring.Click += new System.EventHandler(this.btnreversestring_Click);
            // 
            // btnreversestringbuilder
            // 
            this.btnreversestringbuilder.Location = new System.Drawing.Point(487, 144);
            this.btnreversestringbuilder.Name = "btnreversestringbuilder";
            this.btnreversestringbuilder.Size = new System.Drawing.Size(172, 61);
            this.btnreversestringbuilder.TabIndex = 4;
            this.btnreversestringbuilder.Text = "Reverse String Builder";
            this.btnreversestringbuilder.UseVisualStyleBackColor = true;
            this.btnreversestringbuilder.Click += new System.EventHandler(this.btnreversestringbuilder_Click);
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 496);
            this.Controls.Add(this.btnreversestringbuilder);
            this.Controls.Add(this.btnreversestring);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txttexto;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btnreversestring;
        private System.Windows.Forms.Button btnreversestringbuilder;
    }
}