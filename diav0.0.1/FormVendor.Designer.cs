namespace diav0._0._1
{
    partial class FormVendor
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
            this.btnComenzarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnComenzarVenta
            // 
            this.btnComenzarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComenzarVenta.Location = new System.Drawing.Point(123, 137);
            this.btnComenzarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzarVenta.Name = "btnComenzarVenta";
            this.btnComenzarVenta.Size = new System.Drawing.Size(131, 44);
            this.btnComenzarVenta.TabIndex = 0;
            this.btnComenzarVenta.Text = "Comenzar Venta";
            this.btnComenzarVenta.UseVisualStyleBackColor = true;
            this.btnComenzarVenta.Click += new System.EventHandler(this.btnComenzarVenta_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearCliente.Location = new System.Drawing.Point(307, 137);
            this.btnCrearCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(131, 44);
            this.btnCrearCliente.TabIndex = 3;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 318);
            this.Controls.Add(this.btnCrearCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzarVenta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVendor";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComenzarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearCliente;
    }
}