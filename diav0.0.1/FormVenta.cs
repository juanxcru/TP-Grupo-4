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
        private ManageCliente objCliente;
        public FormVenta()
        {
            InitializeComponent();
            objVenta = new Venta();
            objCliente = new ManageCliente();
            gestorArticulo = new ManageArticulo();
            gestorVenta = new ManageVenta();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            //fillear el comobobox con los clientes ( sin contar el generico)

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
                //ItemVenta itemVenta = new ItemVenta(cantidad, objArticulo);
                gestorVenta.AgregarArticuloAVenta(objArticulo, cantidad, objVenta);
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
            limpiarCampos();

            MessageBox.Show("Venta cancelada");
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {

            if (btnFinalizarVenta.Text.Equals("Finalizar Venta")) {
                

                //guardar venta en bbdd 
                //exportar factura?
                // 

                //MessageBox.Show($"Venta {objVenta.IdVenta} finalizada" );
                MessageBox.Show("Venta finalizada" );
                
                limpiarCampos();
                return;
            
            }


            lblApellidoNombreCliente.Visible = true;
            lblDNI.Visible = true;
            dgvResumen.Visible = true;

            btnEliminarArticulo.Enabled = false;
            btnIngresarArticulo.Enabled = false;
            btnFinalizarVenta.Text = "Finalizar Venta";


            armarTablaResumenVenta();
            //poner los datos del cliente seleccionado (si es el generico, o no se elije, va vacio)
           
        }



        private void armarTablaResumenVenta()
        {
            DataTable resumenVenta = new DataTable();

            resumenVenta.Columns.Add("Articulo");
            resumenVenta.Columns.Add("Precio");
            resumenVenta.Columns.Add("Cantidad");
            resumenVenta.Columns.Add("Total");

            foreach (ItemVenta iv in objVenta.ListaArticulos)
            {

                resumenVenta.Rows.Add($"{iv.Articulo.Descripcion} marca {iv.Articulo.Marca.NombreMarca}", iv.Articulo.Precio.ToString("C"), iv.Cantidad, iv.SubTotal.ToString("C"));
            }
            resumenVenta.Rows.Add("", "", "", "");
            resumenVenta.Rows.Add("TOTAL", "", "", objVenta.MontoTotal.ToString("C"));

            dgvResumen.DataSource = resumenVenta;


        }
        private void limpiarCampos()
        {

            objVenta.ListaArticulos.Clear();
            lboxArticulos.Items.Clear();
            
            lblTotalAPagar.Text = "0";
            txtCantidadArticulos.Text = "";
            txtIdArticulo.Text = "";

            if (dgvResumen.Visible)
            {
                dgvResumen.DataSource = null;
                dgvResumen.Refresh();

                dgvResumen.Visible = false;
                lblApellidoNombreCliente.Visible = false;
                lblDNI.Visible = false;

                btnEliminarArticulo.Enabled = true;
                btnIngresarArticulo.Enabled = true;
                btnFinalizarVenta.Text = "Revisar venta";

                objVenta = new Venta();

            }



        }
    }
}
