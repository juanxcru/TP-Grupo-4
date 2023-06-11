using BLL;
using BUE;
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
    public partial class FormGestionarStock : Form
    {
        //Instancio Articulo Entidad
        BUE.Articulo objBUEArticulo = new BUE.Articulo();   
        //Instancio logica Repositor
        BLLRepositor objBLLRepositor = new BLLRepositor();
        public FormGestionarStock()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBUEArticulo.Descripcion = txtDescripcionBuscar.Text;
            dgvGestionarStock.DataSource = objBLLRepositor.buscarArticuloACargar(objBUEArticulo);
            txtDescripcionBuscar.Text = "";
        }

        private void dgvGestionarStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvGestionarStock.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvGestionarStock.CurrentRow.Cells[1].Value.ToString();
            txtCategoria.Text = dgvGestionarStock.CurrentRow.Cells[2].Value.ToString();
            txtMarca.Text = dgvGestionarStock.CurrentRow.Cells[3].Value.ToString();
            txtStock.Text = dgvGestionarStock.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            try
            {
                //Excepciones
                BLL.Excepciones.ExcepcionesArticulos.verificarCamposCargarStock(txtId.Text, int.Parse(nudStockNuevo.Text));
                
                //Busco articulos para cargar Stock
                objBUEArticulo.IdArticulo = int.Parse(txtId.Text);
                objBLLRepositor.cargarStock(objBUEArticulo, int.Parse(nudStockNuevo.Text));
                dgvGestionarStock.DataSource = objBLLRepositor.buscarArticuloACargar(objBUEArticulo);

                //Limpiar campos
                txtDescripcionBuscar.Text = "";
                txtId.Text = "";
                txtDescripcion.Text = "";
                txtCategoria.Text = "";
                txtMarca.Text = "";
                txtStock.Text = "";
                nudStockNuevo.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            //Limpiar campos
            txtDescripcionBuscar.Text = "";
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtCategoria.Text = "";
            txtMarca.Text = "";
            txtStock.Text = "";
            nudStockNuevo.Text = "";
        }
    }
}
