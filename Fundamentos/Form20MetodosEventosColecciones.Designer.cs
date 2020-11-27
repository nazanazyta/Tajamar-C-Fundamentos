namespace Fundamentos
{
    partial class Form20MetodosEventosColecciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkasociarmetodos = new System.Windows.Forms.CheckBox();
            this.lblnumeroeventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chkasociarmetodos
            // 
            this.chkasociarmetodos.AutoSize = true;
            this.chkasociarmetodos.Location = new System.Drawing.Point(28, 36);
            this.chkasociarmetodos.Name = "chkasociarmetodos";
            this.chkasociarmetodos.Size = new System.Drawing.Size(235, 35);
            this.chkasociarmetodos.TabIndex = 3;
            this.chkasociarmetodos.Text = "Asociar Métodos";
            this.chkasociarmetodos.UseVisualStyleBackColor = true;
            this.chkasociarmetodos.CheckedChanged += new System.EventHandler(this.chkasociarmetodos_CheckedChanged);
            // 
            // lblnumeroeventos
            // 
            this.lblnumeroeventos.AutoSize = true;
            this.lblnumeroeventos.ForeColor = System.Drawing.Color.Blue;
            this.lblnumeroeventos.Location = new System.Drawing.Point(231, 145);
            this.lblnumeroeventos.Name = "lblnumeroeventos";
            this.lblnumeroeventos.Size = new System.Drawing.Size(228, 31);
            this.lblnumeroeventos.TabIndex = 4;
            this.lblnumeroeventos.Text = "lblnumeroeventos";
            // 
            // Form20MetodosEventosColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 377);
            this.Controls.Add(this.lblnumeroeventos);
            this.Controls.Add(this.chkasociarmetodos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form20MetodosEventosColecciones";
            this.Text = "Form20MetodosEventosColecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkasociarmetodos;
        private System.Windows.Forms.Label lblnumeroeventos;
    }
}