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
            this.lblApellidoNombreCliente = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dniBusqueda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtApellidoNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el codigo del articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la cantidad";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(64, 64);
            this.txtIdArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(184, 22);
            this.txtIdArticulo.TabIndex = 2;
            // 
            // txtCantidadArticulos
            // 
            this.txtCantidadArticulos.Location = new System.Drawing.Point(337, 64);
            this.txtCantidadArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadArticulos.Name = "txtCantidadArticulos";
            this.txtCantidadArticulos.Size = new System.Drawing.Size(199, 22);
            this.txtCantidadArticulos.TabIndex = 3;
            // 
            // lboxArticulos
            // 
            this.lboxArticulos.FormattingEnabled = true;
            this.lboxArticulos.ItemHeight = 16;
            this.lboxArticulos.Location = new System.Drawing.Point(63, 189);
            this.lboxArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.lboxArticulos.Name = "lboxArticulos";
            this.lboxArticulos.Size = new System.Drawing.Size(472, 244);
            this.lboxArticulos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Articulos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 448);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cambio: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 448);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total a Pagar: $";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Location = new System.Drawing.Point(507, 448);
            this.lblTotalAPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(25, 16);
            this.lblTotalAPagar.TabIndex = 8;
            this.lblTotalAPagar.Text = "0.0";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(126, 448);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(25, 16);
            this.lblCambio.TabIndex = 9;
            this.lblCambio.Text = "0.0";
            // 
            // btnIngresarArticulo
            // 
            this.btnIngresarArticulo.Location = new System.Drawing.Point(63, 484);
            this.btnIngresarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarArticulo.Name = "btnIngresarArticulo";
            this.btnIngresarArticulo.Size = new System.Drawing.Size(100, 63);
            this.btnIngresarArticulo.TabIndex = 6;
            this.btnIngresarArticulo.Text = "Ingresar articulos";
            this.btnIngresarArticulo.UseVisualStyleBackColor = true;
            this.btnIngresarArticulo.Click += new System.EventHandler(this.btnIngresarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(191, 484);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(100, 63);
            this.btnEliminarArticulo.TabIndex = 7;
            this.btnEliminarArticulo.Text = "Eliminar articulos";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarVenta.Location = new System.Drawing.Point(314, 484);
            this.btnCancelarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(100, 63);
            this.btnCancelarVenta.TabIndex = 8;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Location = new System.Drawing.Point(436, 484);
            this.btnFinalizarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(100, 63);
            this.btnFinalizarVenta.TabIndex = 9;
            this.btnFinalizarVenta.Text = "Revisar venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // lblApellidoNombreCliente
            // 
            this.lblApellidoNombreCliente.AutoSize = true;
            this.lblApellidoNombreCliente.Enabled = false;
            this.lblApellidoNombreCliente.Location = new System.Drawing.Point(573, 64);
            this.lblApellidoNombreCliente.Name = "lblApellidoNombreCliente";
            this.lblApellidoNombreCliente.Size = new System.Drawing.Size(120, 16);
            this.lblApellidoNombreCliente.TabIndex = 14;
            this.lblApellidoNombreCliente.Text = "Apellido y Nombre";
            this.lblApellidoNombreCliente.Visible = false;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Enabled = false;
            this.lblDNI.Location = new System.Drawing.Point(573, 138);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 16);
            this.lblDNI.TabIndex = 15;
            this.lblDNI.Text = "DNI";
            this.lblDNI.Visible = false;
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.AllowUserToResizeRows = false;
            this.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Enabled = false;
            this.dgvResumen.Location = new System.Drawing.Point(566, 189);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.RowHeadersVisible = false;
            this.dgvResumen.RowHeadersWidth = 51;
            this.dgvResumen.RowTemplate.Height = 24;
            this.dgvResumen.ShowEditingIcon = false;
            this.dgvResumen.Size = new System.Drawing.Size(460, 244);
            this.dgvResumen.TabIndex = 16;
            this.dgvResumen.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(334, 95);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 16);
            this.lblCliente.TabIndex = 18;
            this.lblCliente.Text = "Cliente";
            // 
            // dniBusqueda
            // 
            this.dniBusqueda.Location = new System.Drawing.Point(65, 123);
            this.dniBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.dniBusqueda.Name = "dniBusqueda";
            this.dniBusqueda.Size = new System.Drawing.Size(184, 22);
            this.dniBusqueda.TabIndex = 4;
            this.dniBusqueda.TextChanged += new System.EventHandler(this.DniBusqueda_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Buscar cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(337, 123);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(199, 22);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Enabled = false;
            this.lblEmail.Location = new System.Drawing.Point(573, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // txtApellidoNombreCliente
            // 
            this.txtApellidoNombreCliente.Enabled = false;
            this.txtApellidoNombreCliente.Location = new System.Drawing.Point(720, 64);
            this.txtApellidoNombreCliente.Name = "txtApellidoNombreCliente";
            this.txtApellidoNombreCliente.Size = new System.Drawing.Size(233, 22);
            this.txtApellidoNombreCliente.TabIndex = 23;
            this.txtApellidoNombreCliente.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(720, 133);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(233, 22);
            this.txtDni.TabIndex = 24;
            this.txtDni.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(720, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 22);
            this.txtEmail.TabIndex = 25;
            this.txtEmail.Visible = false;
            // 
            // FormVenta
            // 
            this.AcceptButton = this.btnIngresarArticulo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelarVenta;
            this.ClientSize = new System.Drawing.Size(1067, 573);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellidoNombreCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dniBusqueda);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellidoNombreCliente);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
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
        private System.Windows.Forms.Label lblApellidoNombreCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox dniBusqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtApellidoNombreCliente;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtEmail;
    }
}