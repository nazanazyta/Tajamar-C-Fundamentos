namespace Fundamentos
{
    partial class Form26PruebaClases
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
            this.lstdatos = new System.Windows.Forms.ListBox();
            this.btncrearpersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos";
            // 
            // lstdatos
            // 
            this.lstdatos.FormattingEnabled = true;
            this.lstdatos.ItemHeight = 25;
            this.lstdatos.Location = new System.Drawing.Point(27, 51);
            this.lstdatos.Name = "lstdatos";
            this.lstdatos.Size = new System.Drawing.Size(494, 254);
            this.lstdatos.TabIndex = 1;
            // 
            // btncrearpersona
            // 
            this.btncrearpersona.Location = new System.Drawing.Point(527, 51);
            this.btncrearpersona.Name = "btncrearpersona";
            this.btncrearpersona.Size = new System.Drawing.Size(100, 254);
            this.btncrearpersona.TabIndex = 2;
            this.btncrearpersona.Text = "Crear persona";
            this.btncrearpersona.UseVisualStyleBackColor = true;
            this.btncrearpersona.Click += new System.EventHandler(this.btncrearpersona_Click);
            // 
            // Form26PruebaClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 330);
            this.Controls.Add(this.btncrearpersona);
            this.Controls.Add(this.lstdatos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form26PruebaClases";
            this.Text = "Form26PruebaClases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstdatos;
        private System.Windows.Forms.Button btncrearpersona;
    }
}