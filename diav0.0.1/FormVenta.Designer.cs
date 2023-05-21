namespace diav0._0._1
{
    partial class FormVenta
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
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.txtCantidadArticulos = new System.Windows.Forms.TextBox();
            this.lboxArticulos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnIngresarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el codigo del articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(48, 52);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(139, 20);
            this.txtIdArticulo.TabIndex = 2;
            // 
            // txtCantidadArticulos
            // 
            this.txtCantidadArticulos.Location = new System.Drawing.Point(253, 52);
            this.txtCantidadArticulos.Name = "txtCantidadArticulos";
            this.txtCantidadArticulos.Size = new System.Drawing.Size(150, 20);
            this.txtCantidadArticulos.TabIndex = 3;
            // 
            // lboxArticulos
            // 
            this.lboxArticulos.FormattingEnabled = true;
            this.lboxArticulos.Location = new System.Drawing.Point(48, 111);
            this.lboxArticulos.Name = "lboxArticulos";
            this.lboxArticulos.Size = new System.Drawing.Size(355, 199);
            this.lboxArticulos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Articulos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cambio: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total a Pagar: $";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(344, 322);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(22, 13);
            this.lblTotalAPagar.TabIndex = 8;
            this.lblTotalAPagar.Text = "0.0";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(95, 322);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(22, 13);
            this.lblCambio.TabIndex = 9;
            this.lblCambio.Text = "0.0";
            // 
            // btnIngresarArticulo
            // 
            this.btnIngresarArticulo.Location = new System.Drawing.Point(48, 351);
            this.btnIngresarArticulo.Name = "btnIngresarArticulo";
            this.btnIngresarArticulo.Size = new System.Drawing.Size(75, 51);
            this.btnIngresarArticulo.TabIndex = 10;
            this.btnIngresarArticulo.Text = "Ingresar articulos";
            this.btnIngresarArticulo.UseVisualStyleBackColor = true;
            this.btnIngresarArticulo.Click += new System.EventHandler(this.btnIngresarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(144, 351);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(75, 51);
            this.btnEliminarArticulo.TabIndex = 11;
            this.btnEliminarArticulo.Text = "Eliminar articulos";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(236, 351);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(75, 51);
            this.btnCancelarVenta.TabIndex = 12;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Location = new System.Drawing.Point(328, 351);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(75, 51);
            this.btnFinalizarVenta.TabIndex = 13;
            this.btnFinalizarVenta.Text = "Finalizar venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizarVenta);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnIngresarArticulo);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxArticulos);
            this.Controls.Add(this.txtCantidadArticulos);
            this.Controls.Add(this.txtIdArticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.TextBox txtCantidadArticulos;
        private System.Windows.Forms.ListBox lboxArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Button btnIngresarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Button btnFinalizarVenta;
    }
}