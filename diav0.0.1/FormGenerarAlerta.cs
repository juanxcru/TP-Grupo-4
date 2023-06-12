using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diav0._0._1
{
    public partial class FormGenerarAlerta : Form
    {
        public FormGenerarAlerta()
        {
            InitializeComponent();
        }

        private void btnGenerarAlerta_Click(object sender, EventArgs e)
        {
            int cantidad=0;
            BLLRepositor objRepositor = new BLLRepositor();
            dgvGenerarAlerta.DataSource= objRepositor.generarAlerta();
            foreach (DataGridViewRow item in dgvGenerarAlerta.Rows) {                
                cantidad = cantidad + 1;
            }
            if (cantidad==0) {
                MessageBox.Show("No existen productos en estado de Alerta con una cantidad menor a 50 unidades", "Sin resultados");
            }
        }

        private void FrmGenerarAlerta_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
