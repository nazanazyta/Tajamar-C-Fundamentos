namespace Fundamentos
{
    partial class Form11ValidarIsbn
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
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.btncomprobarisbn = new System.Windows.Forms.Button();
            this.lbldatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISNB: ";
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(113, 22);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(156, 35);
            this.txtisbn.TabIndex = 1;
            // 
            // btncomprobarisbn
            // 
            this.btncomprobarisbn.Location = new System.Drawing.Point(31, 82);
            this.btncomprobarisbn.Name = "btncomprobarisbn";
            this.btncomprobarisbn.Size = new System.Drawing.Size(238, 41);
            this.btncomprobarisbn.TabIndex = 2;
            this.btncomprobarisbn.Text = "Validar ISBN";
            this.btncomprobarisbn.UseVisualStyleBackColor = true;
            this.btncomprobarisbn.Click += new System.EventHandler(this.btncomprobarisbn_Click);
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbldatos.Location = new System.Drawing.Point(31, 169);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(98, 29);
            this.lbldatos.TabIndex = 3;
            this.lbldatos.Text = "lbldatos";
            // 
            // Form11ValidarIsbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 244);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.btncomprobarisbn);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form11ValidarIsbn";
            this.Text = "Form11ValidarIsbn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Button btncomprobarisbn;
        private System.Windows.Forms.Label lbldatos;
    }
}