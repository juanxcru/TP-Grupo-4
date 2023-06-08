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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void reports_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            crearArticulo objCrearArticulo = new crearArticulo();
            objCrearArticulo.ShowDialog();
        }

        private void btnGenerarAlerta_Click(object sender, EventArgs e)
        {
            frmGenerarAlerta objGenerarAlerta = new frmGenerarAlerta(); 
            objGenerarAlerta.ShowDialog();
        }
    }
}
