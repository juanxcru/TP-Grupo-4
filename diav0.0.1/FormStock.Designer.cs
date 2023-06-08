namespace diav0._0._1
{
    partial class FormStock
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
            this.reports = new System.Windows.Forms.Label();
            this.btnCrearArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnGestionarStock = new System.Windows.Forms.Button();
            this.btnGenerarAlerta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reports
            // 
            this.reports.AutoSize = true;
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.Location = new System.Drawing.Point(250, 89);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(90, 36);
            this.reports.TabIndex = 4;
            this.reports.Text = "Stock";
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // btnCrearArticulo
            // 
            this.btnCrearArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearArticulo.Location = new System.Drawing.Point(147, 171);
            this.btnCrearArticulo.Name = "btnCrearArticulo";
            this.btnCrearArticulo.Size = new System.Drawing.Size(100, 35);
            this.btnCrearArticulo.TabIndex = 5;
            this.btnCrearArticulo.Text = "Crear Artículo";
            this.btnCrearArticulo.UseVisualStyleBackColor = true;
            this.btnCrearArticulo.Click += new System.EventHandler(this.btnCrearArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificarArticulo.Location = new System.Drawing.Point(147, 231);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(100, 35);
            this.btnModificarArticulo.TabIndex = 6;
            this.btnModificarArticulo.Text = "Modificar Artículo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnGestionarStock
            // 
            this.btnGestionarStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarStock.Location = new System.Drawing.Point(338, 171);
            this.btnGestionarStock.Name = "btnGestionarStock";
            this.btnGestionarStock.Size = new System.Drawing.Size(100, 35);
            this.btnGestionarStock.TabIndex = 7;
            this.btnGestionarStock.Text = "Gestionar Stock";
            this.btnGestionarStock.UseVisualStyleBackColor = true;
            // 
            // btnGenerarAlerta
            // 
            this.btnGenerarAlerta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarAlerta.Location = new System.Drawing.Point(338, 231);
            this.btnGenerarAlerta.Name = "btnGenerarAlerta";
            this.btnGenerarAlerta.Size = new System.Drawing.Size(100, 35);
            this.btnGenerarAlerta.TabIndex = 8;
            this.btnGenerarAlerta.Text = "Generar Alerta";
            this.btnGenerarAlerta.UseVisualStyleBackColor = true;
            this.btnGenerarAlerta.Click += new System.EventHandler(this.btnGenerarAlerta_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnGenerarAlerta);
            this.Controls.Add(this.btnGestionarStock);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnCrearArticulo);
            this.Controls.Add(this.reports);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStock";
            this.Text = "Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reports;
        private System.Windows.Forms.Button btnCrearArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnGestionarStock;
        private System.Windows.Forms.Button btnGenerarAlerta;
    }
}