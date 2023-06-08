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
    public partial class FormModificarArticulo : Form
    {
        //Instancia Articulo
        BUE.Articulo objBUEArticulo = new BUE.Articulo();
        //Instancia logica Repositor
        BLLRepositor objBLLRepositor = new BLLRepositor();

        public FormModificarArticulo()
        {
            InitializeComponent();
        }

        private void FormModificarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBUEArticulo.Descripcion = txtBuscarDescripcion.Text;
            dgvArticulos.DataSource = objBLLRepositor.buscarArticulo(objBUEArticulo);
            txtBuscarDescripcion.Text = "";
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvArticulos.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvArticulos.CurrentRow.Cells[1].Value.ToString();
            cmbCategoria.Text = dgvArticulos.CurrentRow.Cells[2].Value.ToString();
            cmbMarca.Text = dgvArticulos.CurrentRow.Cells[3].Value.ToString();
            nudPrecio.Text = dgvArticulos.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
