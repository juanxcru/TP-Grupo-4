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
    public partial class crearArticulo : Form
    {        
        public crearArticulo()
        {
            InitializeComponent();
        }                
        //Instancio Entidad Articulo
        BUE.Articulo objBUEArticulo = new BUE.Articulo();
        //Instancio Entidad Categoria
        BUE.Categoria objBUECategoria= new BUE.Categoria();
        //Instancio Entidad Marca
        BUE.Marca objBUEMarca = new BUE.Marca();

        //Instancio Logica Articulo
        ManageArticulo objBLLArticulo = new ManageArticulo();
        //Instancio Logica Categoria
        BLLCategoria objBLLCategoria = new BLLCategoria();
        //Instancio Logica Marca
        BLLMarcas objBLLMarcas = new BLL.BLLMarcas();
        //Instancio Logica Repositor
        BLLRepositor objBLLRepositor = new BLLRepositor();

        private void crearArticulo_Load(object sender, EventArgs e)
        {
            //Cargo listado
            dgvArticulos.DataSource = objBLLArticulo.listarArticulos();

            //Cargo Categoria            
            cmbCategoria.DataSource = objBLLCategoria.listarCategoria();
            cmbCategoria.DisplayMember = "detalle";
            cmbCategoria.ValueMember = "id_categoria";
                        
            //Cargo Marcas
            cmbMarca.DataSource = objBLLMarcas.listarMarcas();
            cmbMarca.DisplayMember = "nombre_marca";
            cmbMarca.ValueMember = "id_marca";

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {
            int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            int idMarca = Convert.ToInt32(cmbMarca.SelectedValue);
            //BLL.Excepciones.ExcepcionesArticulos.verificarCamposCargaArtculo(txtDescripcion.Text, cmbCategoria.Text, cmbMarca.Text, int.Parse(nudPrecio.Text), int.Parse(nudCantidad.Text));
            try
            {
                BLL.Excepciones.ExcepcionesArticulos.verificarCamposCargaArtculo(txtDescripcion.Text, idCategoria, idMarca, int.Parse(nudPrecio.Text), int.Parse(nudCantidad.Text));
                //BLL.Excepciones.ExcepcionesArticulos.verificarCamposCargaArtculo(txtDescripcion.Text, (string)cmbCategoria.SelectedValue, (string)cmbMarca.SelectedValue, int.Parse(nudPrecio.Text), int.Parse(nudCantidad.Text));
                //Tengo que instanciar articulo, marca y categoria para pasarle los parametro al metodo CrearArticulo del Repositor
                //Articulo
                //Descripcion
                objBUEArticulo.Descripcion = txtDescripcion.Text;
                //Precio
                objBUEArticulo.Precio = int.Parse(nudPrecio.Text);
                //Cantidad
                objBUEArticulo.Stock = int.Parse(nudCantidad.Text);
                //Categoria
                objBUECategoria.IdCategoria = idCategoria;
                //Marca
                objBUEMarca.IdMarca = idMarca;

                //Ejecuto metodo de creacion de Articulo
                try
                {
                    objBLLRepositor.crearArticulo(objBUEArticulo, objBUECategoria, objBUEMarca);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Limpio campos
                txtDescripcion.Text = "";
                nudPrecio.Text = "";
                nudCantidad.Text = "";
                cmbCategoria.Text = "";
                cmbMarca.Text = "";

                //Vuelvo a cargar Datagrid con los articulos
                dgvArticulos.DataSource = objBLLArticulo.listarArticulos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
