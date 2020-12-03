namespace Fundamentos
{
    partial class Form32SerializarImagen
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
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btninsertarcoche = new System.Windows.Forms.Button();
            this.btnguardardatos = new System.Windows.Forms.Button();
            this.btnleerdatos = new System.Windows.Forms.Button();
            this.lstcoches = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(18, 42);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(180, 31);
            this.txtmarca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(18, 109);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(180, 31);
            this.txtmodelo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coches";
            // 
            // btninsertarcoche
            // 
            this.btninsertarcoche.Location = new System.Drawing.Point(239, 14);
            this.btninsertarcoche.Name = "btninsertarcoche";
            this.btninsertarcoche.Size = new System.Drawing.Size(124, 60);
            this.btninsertarcoche.TabIndex = 6;
            this.btninsertarcoche.Text = "Insertar coche";
            this.btninsertarcoche.UseVisualStyleBackColor = true;
            this.btninsertarcoche.Click += new System.EventHandler(this.btninsertarcoche_Click);
            // 
            // btnguardardatos
            // 
            this.btnguardardatos.Location = new System.Drawing.Point(239, 81);
            this.btnguardardatos.Name = "btnguardardatos";
            this.btnguardardatos.Size = new System.Drawing.Size(124, 60);
            this.btnguardardatos.TabIndex = 7;
            this.btnguardardatos.Text = "Guardar datos";
            this.btnguardardatos.UseVisualStyleBackColor = true;
            this.btnguardardatos.Click += new System.EventHandler(this.btnguardardatos_Click);
            // 
            // btnleerdatos
            // 
            this.btnleerdatos.Location = new System.Drawing.Point(239, 147);
            this.btnleerdatos.Name = "btnleerdatos";
            this.btnleerdatos.Size = new System.Drawing.Size(124, 60);
            this.btnleerdatos.TabIndex = 8;
            this.btnleerdatos.Text = "Leer datos";
            this.btnleerdatos.UseVisualStyleBackColor = true;
            this.btnleerdatos.Click += new System.EventHandler(this.btnleerdatos_Click);
            // 
            // lstcoches
            // 
            this.lstcoches.FormattingEnabled = true;
            this.lstcoches.ItemHeight = 25;
            this.lstcoches.Location = new System.Drawing.Point(391, 41);
            this.lstcoches.Name = "lstcoches";
            this.lstcoches.Size = new System.Drawing.Size(204, 279);
            this.lstcoches.TabIndex = 9;
            this.lstcoches.SelectedIndexChanged += new System.EventHandler(this.lstcoches_SelectedIndexChanged);
            // 
            // Form32SerializarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 382);
            this.Controls.Add(this.lstcoches);
            this.Controls.Add(this.btnleerdatos);
            this.Controls.Add(this.btnguardardatos);
            this.Controls.Add(this.btninsertarcoche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form32SerializarImagen";
            this.Text = "Form32SerializarImagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btninsertarcoche;
        private System.Windows.Forms.Button btnguardardatos;
        private System.Windows.Forms.Button btnleerdatos;
        private System.Windows.Forms.ListBox lstcoches;
    }
}