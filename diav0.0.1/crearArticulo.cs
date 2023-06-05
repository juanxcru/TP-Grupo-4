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

        private void crearArticulo_Load(object sender, EventArgs e)
        {
            //Cargo Categoria
            ManageArticulo objBLLArticulo = new ManageArticulo();
            cmbCategoria.DataSource = objBLLArticulo.cargarCategoria();
            cmbCategoria.DisplayMember= "detalle";
            //Cargo Marcas
            cmbMarca.DataSource = objBLLArticulo.cargarMarcas();
            cmbMarca.DisplayMember = "nombre_marca";
        }
    }
}
