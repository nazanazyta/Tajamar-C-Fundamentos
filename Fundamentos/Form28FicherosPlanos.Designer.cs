namespace Fundamentos
{
    partial class Form28FicherosPlanos
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
            this.btnleerfichero = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lstnombres = new System.Windows.Forms.ListBox();
            this.txttexto = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca un texto:";
            // 
            // btnleerfichero
            // 
            this.btnleerfichero.Location = new System.Drawing.Point(285, 84);
            this.btnleerfichero.Name = "btnleerfichero";
            this.btnleerfichero.Size = new System.Drawing.Size(129, 68);
            this.btnleerfichero.TabIndex = 2;
            this.btnleerfichero.Text = "Leer fichero";
            this.btnleerfichero.UseVisualStyleBackColor = true;
            this.btnleerfichero.Click += new System.EventHandler(this.btnleerfichero_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(285, 172);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(129, 68);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar fichero";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(419, 42);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(114, 43);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(540, 42);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(167, 31);
            this.txtnombre.TabIndex = 6;
            // 
            // lstnombres
            // 
            this.lstnombres.FormattingEnabled = true;
            this.lstnombres.ItemHeight = 25;
            this.lstnombres.Location = new System.Drawing.Point(540, 84);
            this.lstnombres.Name = "lstnombres";
            this.lstnombres.Size = new System.Drawing.Size(167, 204);
            this.lstnombres.TabIndex = 7;
            // 
            // txttexto
            // 
            this.txttexto.Location = new System.Drawing.Point(18, 41);
            this.txttexto.Name = "txttexto";
            this.txttexto.Size = new System.Drawing.Size(246, 246);
            this.txttexto.TabIndex = 8;
            this.txttexto.Text = "";
            // 
            // Form28FicherosPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 314);
            this.Controls.Add(this.txttexto);
            this.Controls.Add(this.lstnombres);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnleerfichero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form28FicherosPlanos";
            this.Text = "Form28FicherosPlanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnleerfichero;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ListBox lstnombres;
        private System.Windows.Forms.RichTextBox txttexto;
    }
}