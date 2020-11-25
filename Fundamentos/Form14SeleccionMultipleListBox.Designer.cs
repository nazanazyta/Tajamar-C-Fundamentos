namespace Fundamentos
{
    partial class Form14SeleccionMultipleListBox
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
            this.lblseleccionados = new System.Windows.Forms.Label();
            this.lblindices = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstelementos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnseleccionados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblseleccionados
            // 
            this.lblseleccionados.AutoSize = true;
            this.lblseleccionados.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblseleccionados.Location = new System.Drawing.Point(19, 389);
            this.lblseleccionados.Name = "lblseleccionados";
            this.lblseleccionados.Size = new System.Drawing.Size(172, 25);
            this.lblseleccionados.TabIndex = 19;
            this.lblseleccionados.Text = "lblseleccionados";
            // 
            // lblindices
            // 
            this.lblindices.AutoSize = true;
            this.lblindices.ForeColor = System.Drawing.Color.Blue;
            this.lblindices.Location = new System.Drawing.Point(19, 342);
            this.lblindices.Name = "lblindices";
            this.lblindices.Size = new System.Drawing.Size(102, 25);
            this.lblindices.TabIndex = 18;
            this.lblindices.Text = "lblindices";
            // 
            // btneliminar
            // 
            this.btneliminar.ForeColor = System.Drawing.Color.Red;
            this.btneliminar.Location = new System.Drawing.Point(282, 235);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(173, 46);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(282, 99);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(173, 50);
            this.btninsertar.TabIndex = 14;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(282, 52);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(253, 31);
            this.txtelemento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Elemento";
            // 
            // lstelementos
            // 
            this.lstelementos.FormattingEnabled = true;
            this.lstelementos.ItemHeight = 25;
            this.lstelementos.Location = new System.Drawing.Point(24, 52);
            this.lstelementos.Name = "lstelementos";
            this.lstelementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstelementos.Size = new System.Drawing.Size(207, 254);
            this.lstelementos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Elementos";
            // 
            // btnseleccionados
            // 
            this.btnseleccionados.Location = new System.Drawing.Point(282, 164);
            this.btnseleccionados.Name = "btnseleccionados";
            this.btnseleccionados.Size = new System.Drawing.Size(173, 55);
            this.btnseleccionados.TabIndex = 20;
            this.btnseleccionados.Text = "Seleccionados";
            this.btnseleccionados.UseVisualStyleBackColor = true;
            this.btnseleccionados.Click += new System.EventHandler(this.btnseleccionados_Click);
            // 
            // Form14SeleccionMultipleListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 437);
            this.Controls.Add(this.btnseleccionados);
            this.Controls.Add(this.lblseleccionados);
            this.Controls.Add(this.lblindices);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstelementos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form14SeleccionMultipleListBox";
            this.Text = "Form14SeleccionMultipleListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblseleccionados;
        private System.Windows.Forms.Label lblindices;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstelementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnseleccionados;
    }
}