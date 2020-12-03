namespace Fundamentos
{
    partial class Form29FicheroProductos
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.btninsertarproducto = new System.Windows.Forms.Button();
            this.btnleerproductos = new System.Windows.Forms.Button();
            this.btnguardarproductos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstproductos = new System.Windows.Forms.ListBox();
            this.btnprimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnultimo = new System.Windows.Forms.Button();
            this.lbldatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(18, 42);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(155, 31);
            this.txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(18, 123);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(102, 31);
            this.txtprecio.TabIndex = 3;
            // 
            // btninsertarproducto
            // 
            this.btninsertarproducto.Location = new System.Drawing.Point(223, 32);
            this.btninsertarproducto.Name = "btninsertarproducto";
            this.btninsertarproducto.Size = new System.Drawing.Size(174, 88);
            this.btninsertarproducto.TabIndex = 4;
            this.btninsertarproducto.Text = "Insertar producto";
            this.btninsertarproducto.UseVisualStyleBackColor = true;
            this.btninsertarproducto.Click += new System.EventHandler(this.btninsertarproducto_Click);
            // 
            // btnleerproductos
            // 
            this.btnleerproductos.Location = new System.Drawing.Point(223, 126);
            this.btnleerproductos.Name = "btnleerproductos";
            this.btnleerproductos.Size = new System.Drawing.Size(174, 88);
            this.btnleerproductos.TabIndex = 5;
            this.btnleerproductos.Text = "Leer productos";
            this.btnleerproductos.UseVisualStyleBackColor = true;
            this.btnleerproductos.Click += new System.EventHandler(this.btnleerproductos_Click);
            // 
            // btnguardarproductos
            // 
            this.btnguardarproductos.Location = new System.Drawing.Point(223, 220);
            this.btnguardarproductos.Name = "btnguardarproductos";
            this.btnguardarproductos.Size = new System.Drawing.Size(174, 88);
            this.btnguardarproductos.TabIndex = 6;
            this.btnguardarproductos.Text = "Guardar productos";
            this.btnguardarproductos.UseVisualStyleBackColor = true;
            this.btnguardarproductos.Click += new System.EventHandler(this.btnguardarproductos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Productos";
            // 
            // lstproductos
            // 
            this.lstproductos.FormattingEnabled = true;
            this.lstproductos.ItemHeight = 25;
            this.lstproductos.Location = new System.Drawing.Point(432, 52);
            this.lstproductos.Name = "lstproductos";
            this.lstproductos.Size = new System.Drawing.Size(253, 254);
            this.lstproductos.TabIndex = 8;
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(23, 334);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(150, 45);
            this.btnprimero.TabIndex = 9;
            this.btnprimero.Text = "Primero";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(195, 334);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(151, 45);
            this.btnanterior.TabIndex = 10;
            this.btnanterior.Text = "Anterior";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(369, 334);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(147, 45);
            this.btnsiguiente.TabIndex = 11;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(538, 334);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(147, 45);
            this.btnultimo.TabIndex = 12;
            this.btnultimo.Text = "Último";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.ForeColor = System.Drawing.Color.Red;
            this.lbldatos.Location = new System.Drawing.Point(13, 405);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(164, 25);
            this.lbldatos.TabIndex = 13;
            this.lbldatos.Text = "Producto 1 de 5";
            // 
            // Form29FicheroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 439);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.lstproductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnguardarproductos);
            this.Controls.Add(this.btnleerproductos);
            this.Controls.Add(this.btninsertarproducto);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form29FicheroProductos";
            this.Text = "Form29FicheroProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btninsertarproducto;
        private System.Windows.Forms.Button btnleerproductos;
        private System.Windows.Forms.Button btnguardarproductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstproductos;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Label lbldatos;
    }
}