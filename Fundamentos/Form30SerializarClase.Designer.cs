namespace Fundamentos
{
    partial class Form30SerializarClase
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
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btnleerproducto = new System.Windows.Forms.Button();
            this.btnguardarproducto = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(18, 51);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(208, 31);
            this.txtproducto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(18, 123);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(112, 31);
            this.txtprecio.TabIndex = 3;
            // 
            // btnleerproducto
            // 
            this.btnleerproducto.Location = new System.Drawing.Point(275, 22);
            this.btnleerproducto.Name = "btnleerproducto";
            this.btnleerproducto.Size = new System.Drawing.Size(134, 60);
            this.btnleerproducto.TabIndex = 4;
            this.btnleerproducto.Text = "Leer producto";
            this.btnleerproducto.UseVisualStyleBackColor = true;
            // 
            // btnguardarproducto
            // 
            this.btnguardarproducto.Location = new System.Drawing.Point(275, 94);
            this.btnguardarproducto.Name = "btnguardarproducto";
            this.btnguardarproducto.Size = new System.Drawing.Size(134, 60);
            this.btnguardarproducto.TabIndex = 5;
            this.btnguardarproducto.Text = "Guardar producto";
            this.btnguardarproducto.UseVisualStyleBackColor = true;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.ForeColor = System.Drawing.Color.Blue;
            this.lblinfo.Location = new System.Drawing.Point(18, 161);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(69, 25);
            this.lblinfo.TabIndex = 6;
            this.lblinfo.Text = "lblinfo";
            // 
            // Form30SerializarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 221);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnguardarproducto);
            this.Controls.Add(this.btnleerproducto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form30SerializarClase";
            this.Text = "Form30SerializarClase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btnleerproducto;
        private System.Windows.Forms.Button btnguardarproducto;
        private System.Windows.Forms.Label lblinfo;
    }
}