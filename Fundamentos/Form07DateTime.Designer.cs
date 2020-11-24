namespace Fundamentos
{
    partial class Form07DateTime
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
            this.txtfechaactual = new System.Windows.Forms.TextBox();
            this.chkformato = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnmostrarfecha = new System.Windows.Forms.Button();
            this.txtincremento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbanios = new System.Windows.Forms.RadioButton();
            this.rdbmeses = new System.Windows.Forms.RadioButton();
            this.rdbdias = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnuevafecha = new System.Windows.Forms.TextBox();
            this.lbldatos = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Actual";
            // 
            // txtfechaactual
            // 
            this.txtfechaactual.Location = new System.Drawing.Point(47, 60);
            this.txtfechaactual.Name = "txtfechaactual";
            this.txtfechaactual.Size = new System.Drawing.Size(516, 35);
            this.txtfechaactual.TabIndex = 1;
            // 
            // chkformato
            // 
            this.chkformato.AutoSize = true;
            this.chkformato.Location = new System.Drawing.Point(47, 117);
            this.chkformato.Name = "chkformato";
            this.chkformato.Size = new System.Drawing.Size(219, 33);
            this.chkformato.TabIndex = 2;
            this.chkformato.Text = "Cambiar Formato";
            this.chkformato.UseVisualStyleBackColor = true;
            this.chkformato.CheckedChanged += new System.EventHandler(this.chkformato_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Controls.Add(this.btnmostrarfecha);
            this.groupBox1.Controls.Add(this.txtincremento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdbanios);
            this.groupBox1.Controls.Add(this.rdbmeses);
            this.groupBox1.Controls.Add(this.rdbdias);
            this.groupBox1.Location = new System.Drawing.Point(47, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 224);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones Fecha";
            // 
            // btnmostrarfecha
            // 
            this.btnmostrarfecha.Location = new System.Drawing.Point(279, 157);
            this.btnmostrarfecha.Name = "btnmostrarfecha";
            this.btnmostrarfecha.Size = new System.Drawing.Size(146, 39);
            this.btnmostrarfecha.TabIndex = 5;
            this.btnmostrarfecha.Text = "Mostrar fecha";
            this.btnmostrarfecha.UseVisualStyleBackColor = true;
            this.btnmostrarfecha.Click += new System.EventHandler(this.btnmostrarfecha_Click);
            // 
            // txtincremento
            // 
            this.txtincremento.Location = new System.Drawing.Point(279, 107);
            this.txtincremento.Name = "txtincremento";
            this.txtincremento.Size = new System.Drawing.Size(110, 35);
            this.txtincremento.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Incremento";
            // 
            // rdbanios
            // 
            this.rdbanios.AutoSize = true;
            this.rdbanios.Location = new System.Drawing.Point(37, 147);
            this.rdbanios.Name = "rdbanios";
            this.rdbanios.Size = new System.Drawing.Size(85, 33);
            this.rdbanios.TabIndex = 2;
            this.rdbanios.TabStop = true;
            this.rdbanios.Text = "Años";
            this.rdbanios.UseVisualStyleBackColor = true;
            // 
            // rdbmeses
            // 
            this.rdbmeses.AutoSize = true;
            this.rdbmeses.Location = new System.Drawing.Point(37, 98);
            this.rdbmeses.Name = "rdbmeses";
            this.rdbmeses.Size = new System.Drawing.Size(103, 33);
            this.rdbmeses.TabIndex = 1;
            this.rdbmeses.TabStop = true;
            this.rdbmeses.Text = "Meses";
            this.rdbmeses.UseVisualStyleBackColor = true;
            // 
            // rdbdias
            // 
            this.rdbdias.AutoSize = true;
            this.rdbdias.Location = new System.Drawing.Point(37, 48);
            this.rdbdias.Name = "rdbdias";
            this.rdbdias.Size = new System.Drawing.Size(79, 33);
            this.rdbdias.TabIndex = 0;
            this.rdbdias.TabStop = true;
            this.rdbdias.Text = "Días";
            this.rdbdias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nueva fecha";
            // 
            // txtnuevafecha
            // 
            this.txtnuevafecha.Location = new System.Drawing.Point(47, 455);
            this.txtnuevafecha.Name = "txtnuevafecha";
            this.txtnuevafecha.Size = new System.Drawing.Size(460, 35);
            this.txtnuevafecha.TabIndex = 5;
            // 
            // lbldatos
            // 
            this.lbldatos.AutoSize = true;
            this.lbldatos.ForeColor = System.Drawing.Color.Crimson;
            this.lbldatos.Location = new System.Drawing.Point(42, 522);
            this.lbldatos.Name = "lbldatos";
            this.lbldatos.Size = new System.Drawing.Size(98, 29);
            this.lbldatos.TabIndex = 6;
            this.lbldatos.Text = "lbldatos";
            // 
            // Form07DateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 603);
            this.Controls.Add(this.lbldatos);
            this.Controls.Add(this.txtnuevafecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkformato);
            this.Controls.Add(this.txtfechaactual);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form07DateTime";
            this.Text = "Form07DateTime";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechaactual;
        private System.Windows.Forms.CheckBox chkformato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmostrarfecha;
        private System.Windows.Forms.TextBox txtincremento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbanios;
        private System.Windows.Forms.RadioButton rdbmeses;
        private System.Windows.Forms.RadioButton rdbdias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnuevafecha;
        private System.Windows.Forms.Label lbldatos;
    }
}