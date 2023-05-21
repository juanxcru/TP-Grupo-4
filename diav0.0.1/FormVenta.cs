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
        public FormVenta()
        {
            InitializeComponent();
        }
        Venta objVenta = new Venta();
        BLL.ManageArticulo gestorArticulo = new BLL.ManageArticulo();
        BLL.ManageVenta gestorVenta = new BLL.ManageVenta();

        private void FormVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresarArticulo_Click(object sender, EventArgs e)
        {

            BUE.Articulo objArticulo = new BUE.Articulo();
            
            BUE.ItemVenta itemVenta = new BUE.ItemVenta();

            objArticulo = gestorArticulo.ValidarArticulo(txtIdArticulo.Text, int.Parse(txtCantidadArticulos.Text));


            if (objArticulo == null)
            {
                MessageBox.Show("El articulo no existe");
            }
            else
            {
                gestorVenta.AgregarArticuloAVenta(objArticulo, int.Parse(txtCantidadArticulos.Text), objVenta);
            }

            ActualizarListBoxArticulos();

        }
        private void ActualizarListBoxArticulos()
        {
            lboxArticulos.Items.Clear();

            // Recorrer los items de la venta en curso y mostrarlos en el ListBox
            foreach (var item in objVenta.ListaArticulos)
            {
                lboxArticulos.Items.Add($"{item.Descripcion} - Cantidad: {txtCantidadArticulos.Text} - Precio Unitario:$ {item.Precio}");
            }
        }
    }
}
