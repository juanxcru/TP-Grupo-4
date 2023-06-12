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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }
        
        Gerente Usuario = new Gerente();

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingresa ID del vendedor:", "", "");
            bool tf = int.TryParse(input, out int ID);
            if (tf)
            {
                BUE.Venta[] ventas = Usuario.VerVentaPorUsuario(ID);
                foreach (BUE.Venta venta in ventas)
                {
                    
                    if(venta != null)
                    {
                        dataGridView1.Rows.Add(venta.IdVenta, venta.FechaYHora, venta.MontoTotal);
                    }
                    
                }
            }

            


        }

        private void BotonMensual_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            BUE.Venta[] ventas = Usuario.Reporte(true);
            foreach (BUE.Venta venta in ventas)
            {
                if (venta != null)
                {
                    dataGridView1.Rows.Add(venta.IdVenta, venta.FechaYHora, venta.MontoTotal);
                }
            }
        }

        private void BotonSemanal_Click(object sender, EventArgs e)
        {
            {
                dataGridView1.Rows.Clear();
                BUE.Venta[] ventas = Usuario.Reporte(false);
                foreach (BUE.Venta venta in ventas)
                {
                    if (venta != null)
                    {
                        dataGridView1.Rows.Add(venta.IdVenta, venta.FechaYHora, venta.MontoTotal);
                    }
                }
            }
        }
    }
    
}
