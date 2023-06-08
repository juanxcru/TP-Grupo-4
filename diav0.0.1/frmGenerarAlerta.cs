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
    public partial class frmGenerarAlerta : Form
    {
        public frmGenerarAlerta()
        {
            InitializeComponent();
        }

        private void btnGenerarAlerta_Click(object sender, EventArgs e)
        {
            BLLRepositor objRepositor = new BLLRepositor();
            dgvGenerarAlerta.DataSource= objRepositor.generarAlerta();
        }
    }
}
