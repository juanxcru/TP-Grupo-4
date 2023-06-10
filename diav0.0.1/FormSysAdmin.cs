using BLL;
using BUE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diav0._0._1
{
    public partial class FormSysAdmin : Form
    {
        private BUE.Usuario objUsuario;
        private BLL.SysAdmin gestorUsuario;

        public FormSysAdmin()
        {
            InitializeComponent();
            objUsuario = new BUE.Usuario();
            gestorUsuario = new BLL.SysAdmin();

            

        }
        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            // completar nombre
            // completar apellido
            // completar dni
            // completar perfil
            
            // completar username
            // corroborar que no exista este username
            // si existe -> pedir de nuevo
            // si no existe -> completar password

            // dal.crearusuario            

        }


        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
