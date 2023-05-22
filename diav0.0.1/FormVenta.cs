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
    public partial class FormVenta : Form
    {
        private Venta objVenta;
        private ManageArticulo gestorArticulo;
        private ManageVenta gestorVenta;

        public FormVenta()
        {
            InitializeComponent();
            objVenta = new Venta();
            gestorArticulo = new ManageArticulo();
            gestorVenta = new ManageVenta();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarArticulo_Click(object sender, EventArgs e)
        {
            string idArticulo = txtIdArticulo.Text;
            int cantidad = int.Parse(txtCantidadArticulos.Text);

            Articulo objArticulo = gestorArticulo.ValidarArticulo(idArticulo, cantidad);

            if (objArticulo == null)
            {
                MessageBox.Show("El artículo no existe.");
            }
            else
            {
                ItemVenta itemVenta = new ItemVenta(cantidad, objArticulo);
                gestorVenta.AgregarItemVenta(itemVenta, objVenta);
                ActualizarListBoxArticulos();
            }
        }

        private void ActualizarListBoxArticulos()
        {
            lboxArticulos.Items.Clear();

            foreach (ItemVenta itemVenta in objVenta.ListaArticulos)
            {
                int id = itemVenta.Articulo.IdArticulo;
                string descripcion = itemVenta.Articulo.Descripcion;
                double cantidad = itemVenta.Cantidad;
                double precioUnitario = itemVenta.Articulo.Precio;
                string marca = itemVenta.Articulo.Marca.NombreMarca;
                lboxArticulos.Items.Add($"Cod: {id} - {descripcion} {marca} - Cantidad: {cantidad} - PU: ${precioUnitario} - PT: ${precioUnitario * cantidad} ");

                ActualizarTotalAPagar();
            }
        }

        private void ActualizarTotalAPagar()
        {
            double totalAPagar = gestorVenta.CalcularTotal(objVenta);
            lblTotalAPagar.Text = totalAPagar.ToString();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            
            if (lboxArticulos.SelectedItem != null)
            {

                int indiceSeleccionado = lboxArticulos.SelectedIndex;

                objVenta.ListaArticulos.RemoveAt(indiceSeleccionado);

                ActualizarListBoxArticulos();
                ActualizarTotalAPagar();
            }
            else
            {
                MessageBox.Show("No selecciono ningun producto de la lista");
            }
            
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            objVenta.ListaArticulos.Clear();


            lboxArticulos.Items.Clear();


            lblTotalAPagar.Text = "0";


            txtCantidadArticulos.Text = "";
            txtIdArticulo.Text = "";


            MessageBox.Show("Venta cancelada");
        }
    }
}
