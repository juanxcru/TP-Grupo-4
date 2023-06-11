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
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }
        
        Gerente Usuario = new Gerente();

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Ingresa ID del vendedor:", "", "");
            bool tf = int.TryParse(input, out int ID);
            if (tf)
            {
                Usuario.VerVentaPorUsuario(ID);
            }

            


        }
    }
}
