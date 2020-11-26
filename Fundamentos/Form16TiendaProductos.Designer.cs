namespace Fundamentos
{
    partial class Form16TiendaProductos
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
            this.btninsertar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsttienda = new System.Windows.Forms.ListBox();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstalmacen = new System.Windows.Forms.ListBox();
            this.btnsubir = new System.Windows.Forms.Button();
            this.btnbajar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(35, 67);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(164, 31);
            this.txtproducto.TabIndex = 1;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(36, 124);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(163, 36);
            this.btninsertar.TabIndex = 2;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(36, 178);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(163, 36);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(36, 232);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(163, 37);
            this.btnmodificar.TabIndex = 4;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(36, 285);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(163, 41);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar lista";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tienda";
            // 
            // lsttienda
            // 
            this.lsttienda.FormattingEnabled = true;
            this.lsttienda.ItemHeight = 25;
            this.lsttienda.Location = new System.Drawing.Point(232, 67);
            this.lsttienda.Name = "lsttienda";
            this.lsttienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsttienda.Size = new System.Drawing.Size(166, 304);
            this.lsttienda.TabIndex = 7;
            // 
            // btnseleccion
            // 
            this.btnseleccion.Location = new System.Drawing.Point(413, 165);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(123, 34);
            this.btnseleccion.TabIndex = 8;
            this.btnseleccion.Text = "Selección";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // btntodos
            // 
            this.btntodos.Location = new System.Drawing.Point(413, 220);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(123, 33);
            this.btntodos.TabIndex = 9;
            this.btntodos.Text = "Todos";
            this.btntodos.UseVisualStyleBackColor = true;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Almacén";
            // 
            // lstalmacen
            // 
            this.lstalmacen.FormattingEnabled = true;
            this.lstalmacen.ItemHeight = 25;
            this.lstalmacen.Location = new System.Drawing.Point(552, 67);
            this.lstalmacen.Name = "lstalmacen";
            this.lstalmacen.Size = new System.Drawing.Size(169, 304);
            this.lstalmacen.TabIndex = 11;
            // 
            // btnsubir
            // 
            this.btnsubir.Location = new System.Drawing.Point(754, 158);
            this.btnsubir.Name = "btnsubir";
            this.btnsubir.Size = new System.Drawing.Size(127, 56);
            this.btnsubir.TabIndex = 12;
            this.btnsubir.Text = "Subir";
            this.btnsubir.UseVisualStyleBackColor = true;
            this.btnsubir.Click += new System.EventHandler(this.btnsubir_Click);
            // 
            // btnbajar
            // 
            this.btnbajar.Location = new System.Drawing.Point(754, 232);
            this.btnbajar.Name = "btnbajar";
            this.btnbajar.Size = new System.Drawing.Size(127, 54);
            this.btnbajar.TabIndex = 13;
            this.btnbajar.Text = "Bajar";
            this.btnbajar.UseVisualStyleBackColor = true;
            this.btnbajar.Click += new System.EventHandler(this.btnbajar_Click);
            // 
            // Form16TiendaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 419);
            this.Controls.Add(this.btnbajar);
            this.Controls.Add(this.btnsubir);
            this.Controls.Add(this.lstalmacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.lsttienda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form16TiendaProductos";
            this.Text = "Form16TiendaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsttienda;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Button btntodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstalmacen;
        private System.Windows.Forms.Button btnsubir;
        private System.Windows.Forms.Button btnbajar;
    }
}