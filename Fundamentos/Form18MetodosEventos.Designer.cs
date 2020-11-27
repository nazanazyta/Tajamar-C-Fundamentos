namespace Fundamentos
{
    partial class Form18MetodosEventos
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
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.txtletras = new System.Windows.Forms.TextBox();
            this.lblraton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solo números: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solo letras: ";
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(185, 19);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(184, 31);
            this.txtnumeros.TabIndex = 2;
            this.txtnumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeros_KeyPress);
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(185, 72);
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(184, 31);
            this.txtletras.TabIndex = 3;
            this.txtletras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtletras_KeyPress);
            // 
            // lblraton
            // 
            this.lblraton.BackColor = System.Drawing.SystemColors.Info;
            this.lblraton.Location = new System.Drawing.Point(28, 148);
            this.lblraton.Name = "lblraton";
            this.lblraton.Size = new System.Drawing.Size(424, 236);
            this.lblraton.TabIndex = 4;
            this.lblraton.Text = "lblraton";
            this.lblraton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblraton.MouseHover += new System.EventHandler(this.lblraton_MouseHover);
            this.lblraton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblraton_MouseMove);
            // 
            // Form18MetodosEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 404);
            this.Controls.Add(this.lblraton);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form18MetodosEventos";
            this.Text = "Form18MetodosEventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.Label lblraton;
    }
}