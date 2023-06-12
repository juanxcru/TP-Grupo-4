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
    public partial class FormModificarArticulo : Form
    {
        //Instancia Articulo
        BUE.Articulo objBUEArticulo = new BUE.Articulo();
        //Instancio Entidad Categoria
        BUE.Categoria objBUECategoria = new BUE.Categoria();
        //Instancio Entidad Marca
        BUE.Marca objBUEMarca = new BUE.Marca();    
        //Instancia logica Repositor
        BLLRepositor objBLLRepositor = new BLLRepositor();
        //Instancio Logica Categoria
        BLLCategoria objBLLCategoria = new BLLCategoria();
        //Instancio Logica Marca
        BLLMarcas objBLLMarcas = new BLL.BLLMarcas();
        //Instancio Logica Articulo
        ManageArticulo objBLLArticulo = new ManageArticulo();
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
            txtCategoria.Text = dgvArticulos.CurrentRow.Cells[2].Value.ToString();
            txtMarca.Text = dgvArticulos.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dgvArticulos.CurrentRow.Cells[4].Value.ToString();

            if (txtId.Text !="") {
                txtDescripcion.Enabled = true;
                cmbNuevaCategoria.Enabled = true;
                cmbNuevaMarca.Enabled=true;
                nudNuevoPrecio.Enabled = true;

                //Cargo Categoria            
                cmbNuevaCategoria.DataSource = objBLLCategoria.listarCategoria();
                cmbNuevaCategoria.DisplayMember = "detalle";
                cmbNuevaCategoria.ValueMember = "id_categoria";

                //Cargo Marcas                        
                cmbNuevaMarca.DataSource = objBLLMarcas.listarMarcas();
                cmbNuevaMarca.DisplayMember = "nombre_marca";
                cmbNuevaMarca.ValueMember = "id_marca";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(cmbNuevaCategoria.SelectedValue);
            int idMarca = Convert.ToInt32(cmbNuevaMarca.SelectedValue);

            try
            {
                //Excepciones
                BLL.Excepciones.ExcepcionesArticulos.verificarCamposModificarArticulo(txtDescripcion.Text, cmbNuevaCategoria.Text, cmbNuevaMarca.Text, double.Parse(nudNuevoPrecio.Text));
                //Defino ID
                objBUEArticulo.IdArticulo = int.Parse(txtId.Text);
                //Descripcion
                objBUEArticulo.Descripcion = txtDescripcion.Text;
                //Precio
                objBUEArticulo.Precio = int.Parse(nudNuevoPrecio.Text);
                //Categoria
                objBUECategoria.IdCategoria = idCategoria;
                //Marca
                objBUEMarca.IdMarca = idMarca;

                //Ejecuto metodo de creacion de Articulo                
                objBLLRepositor.modificarArticulo(objBUEArticulo, objBUECategoria, objBUEMarca);
                
                //Limpio campos
                txtDescripcion.Text = "";
                nudNuevoPrecio.Text = "";                
                txtCategoria.Text = "";
                txtMarca.Text = "";
                txtPrecio.Text = "";

                cmbNuevaCategoria.Enabled = false;
                cmbNuevaMarca.Enabled = false;
                nudNuevoPrecio.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void cmbNuevaMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            //Limpio campos
            txtDescripcion.Text = "";
            nudNuevoPrecio.Text = "";
            txtCategoria.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            
            cmbNuevaCategoria.Enabled = false;
            cmbNuevaMarca.Enabled = false;
            nudNuevoPrecio.Enabled = false;
        }
    }
}
