namespace diav0._0._1
{
    partial class FormGenerarAlerta
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
            this.dgvGenerarAlerta = new System.Windows.Forms.DataGridView();
            this.btnGenerarAlerta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerarAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGenerarAlerta
            // 
            this.dgvGenerarAlerta.AllowUserToAddRows = false;
            this.dgvGenerarAlerta.AllowUserToDeleteRows = false;
            this.dgvGenerarAlerta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenerarAlerta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenerarAlerta.Location = new System.Drawing.Point(12, 89);
            this.dgvGenerarAlerta.Name = "dgvGenerarAlerta";
            this.dgvGenerarAlerta.ReadOnly = true;
            this.dgvGenerarAlerta.Size = new System.Drawing.Size(764, 349);
            this.dgvGenerarAlerta.TabIndex = 0;
            // 
            // btnGenerarAlerta
            // 
            this.btnGenerarAlerta.Location = new System.Drawing.Point(610, 33);
            this.btnGenerarAlerta.Name = "btnGenerarAlerta";
            this.btnGenerarAlerta.Size = new System.Drawing.Size(75, 50);
            this.btnGenerarAlerta.TabIndex = 1;
            this.btnGenerarAlerta.Text = "Generar Alerta";
            this.btnGenerarAlerta.UseVisualStyleBackColor = true;
            this.btnGenerarAlerta.Click += new System.EventHandler(this.btnGenerarAlerta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(701, 33);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 50);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormGenerarAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarAlerta);
            this.Controls.Add(this.dgvGenerarAlerta);
            this.Name = "FormGenerarAlerta";
            this.Text = "Generar Alerta";
            this.Load += new System.EventHandler(this.FrmGenerarAlerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerarAlerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGenerarAlerta;
        private System.Windows.Forms.Button btnGenerarAlerta;
        private System.Windows.Forms.Button btnSalir;
    }
}