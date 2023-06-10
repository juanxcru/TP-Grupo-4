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

            List<(BUE.Empleado, BUE.Usuario, BUE.Perfil)> listaDeUsuarios = gestorUsuario.ObtenerListaUsuarios();
            DataTable dt = ActualizarTablaUsuarios(listaDeUsuarios);

            GridUsuarios.DataSource = dt;

        }

        /// <summary>
        /// Actualiza la tabla de usuarios con la información correspondiente
        /// </summary>
        /// <param name="listaDeUsuarios"></param>
        /// <returns></returns>
        public DataTable ActualizarTablaUsuarios(List<(BUE.Empleado, BUE.Usuario, BUE.Perfil)> listaDeUsuarios)
        {
            DataTable dtUsuarios = new DataTable();
            
            dtUsuarios.Columns.Add("ID Empleado", typeof(int));
            dtUsuarios.Columns.Add("Nombre", typeof(string));
            dtUsuarios.Columns.Add("Apellido", typeof(string));
            dtUsuarios.Columns.Add("DNI", typeof(string));
            dtUsuarios.Columns.Add("Username", typeof(string));
            dtUsuarios.Columns.Add("Rol", typeof(string));

            foreach (var usuarioTuple in listaDeUsuarios)
            {
                DataRow nuevaFila = dtUsuarios.NewRow();

                // saco info de empleado
                nuevaFila["ID Empleado"] = usuarioTuple.Item1.IdEmpleado;
                nuevaFila["Nombre"] = usuarioTuple.Item1.Nombre;
                nuevaFila["Apellido"] = usuarioTuple.Item1.Apellido;
                nuevaFila["DNI"] = usuarioTuple.Item1.Dni;
                
                // saco la info de usuario
                nuevaFila["Username"] = usuarioTuple.Item2.UserName;
                
                // saco la info de perfil
                nuevaFila["Rol"] = usuarioTuple.Item3.Descripcion;

                dtUsuarios.Rows.Add(nuevaFila);
            }

            return dtUsuarios;
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
            // 

            try
            {

            }
            catch (Exception ex)
            {

            }

        }

    }
}
