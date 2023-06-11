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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace diav0._0._1
{
    public partial class FormSysAdmin : Form
    {
        private BUE.Usuario objUsuario;
        private BLL.SysAdmin gestorUsuario;
        // Declarar el BindingSource como miembro de la clase
        private BindingSource bindingSource;

        private static string GenerarContraseñaAleatoria()
        {
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder contraseña = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int indice = random.Next(caracteres.Length);
                contraseña.Append(caracteres[indice]);
            }

            return contraseña.ToString();
        }

        private void MessageFilaAfectada(DataGridViewRow filaNueva, string mensaje)
        {
            string infoFilaAfectada = InfoFila(filaNueva);

            // Mostrar cartel con la información de la fila afectada y el mensaje
            MessageBox.Show($"{infoFilaAfectada}\n\n{mensaje}", "Información de la fila afectada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string InfoFila(DataGridViewRow fila)
        {
            // Obtener los valores de la fila seleccionada
            int idEmpleado = Convert.ToInt32(fila.Cells["IDEmpleado"].Value);
            string nombre = fila.Cells["Nombre"].Value.ToString();
            string apellido = fila.Cells["Apellido"].Value.ToString();
            int dni = Convert.ToInt32(fila.Cells["DNI"].Value);
            string username = fila.Cells["Username"].Value.ToString();
            string rol = fila.Cells["Rol"].Displayed.ToString();

            // Construir la información de la fila afectada
            string infoFilaAfectada = $"Empleado: {idEmpleado}\n" +
                                      $"Nombre: {nombre}\n" +
                                      $"Apellido: {apellido}\n" +
                                      $"DNI: {dni}\n" +
                                      $"Username: {username}\n" +
                                      $"Rol: {rol}";
            return infoFilaAfectada;
        }

        public FormSysAdmin()
        {
            InitializeComponent();

            objUsuario = new BUE.Usuario();
            gestorUsuario = new BLL.SysAdmin();
            
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            List<(BUE.Empleado, BUE.Usuario, BUE.Perfil)> listaDeUsuarios = gestorUsuario.ObtenerListaUsuarios();

            GridUsuarios.DataSource = null;

            var combobox = (DataGridViewComboBoxColumn)GridUsuarios.Columns["Rol"];
            combobox.DisplayMember = "Descripcion"; // Nombre de la propiedad para mostrar en el DropDownList
            combobox.ValueMember = "ID"; // Nombre de la propiedad para obtener el valor seleccionado
            combobox.DataSource = GetLista(); // Fuente de datos para el DropDownList

            ActualizarTablaUsuarios(listaDeUsuarios);
        }

        /// <summary>
        /// Actualiza la tabla de usuarios con la información correspondiente
        /// </summary>
        /// <param name="listaDeUsuarios"></param>
        /// <returns></returns>
        public void ActualizarTablaUsuarios(List<(BUE.Empleado, BUE.Usuario, BUE.Perfil)> listaDeUsuarios)
        {
            foreach (var usuarioTuple in listaDeUsuarios)
            {
                // Crear una nueva fila
                DataGridViewRow nuevaFila = new DataGridViewRow();

                // Agregar celdas a la fila del DataGrid
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = usuarioTuple.Item1.IdEmpleado });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = usuarioTuple.Item1.Nombre });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = usuarioTuple.Item1.Apellido });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = usuarioTuple.Item1.Dni });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = usuarioTuple.Item2.UserName });
                int Rol = usuarioTuple.Item3.ID;

                // Crear una celda de tipo DataGridViewComboBoxCell para la columna "Rol"
                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                comboBoxCell.FlatStyle = FlatStyle.Flat;
                comboBoxCell.DataSource = GetLista(); // Fuente de datos para el DropDownList
                comboBoxCell.DisplayMember = "Descripcion"; // Nombre de la propiedad para mostrar en el DropDownList
                comboBoxCell.ValueMember = "ID"; // Nombre de la propiedad para obtener el valor seleccionado
                comboBoxCell.Value = Rol; // Establecer el valor seleccionado

                // Agregar la celda a la fila
                nuevaFila.Cells.Add(comboBoxCell);

                // Agregar la fila al DataGridView y a la tablaUsuarios
                GridUsuarios.Rows.Add(nuevaFila);
            }
        }
        

        /// <summary>
        /// Obtengo una lista de los perfiles actuales en la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Perfil> GetLista()
        {
            List<Perfil> listaPerfiles = gestorUsuario.getPerfiles(); // Obtener la lista de perfiles

            return listaPerfiles;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = GridUsuarios.SelectedRows[0];

            // Obtener los valores de la fila seleccionada
            int idEmpleado = Convert.ToInt32(selectedRow.Cells["IDEmpleado"].Value);
            string nombre = selectedRow.Cells["Nombre"].Value.ToString();
            string apellido = selectedRow.Cells["Apellido"].Value.ToString();
            int dni = Convert.ToInt32(selectedRow.Cells["DNI"].Value);
            string username = selectedRow.Cells["Username"].Value.ToString();
            int rol = Convert.ToInt32(selectedRow.Cells["Rol"].Value);

            // Generar una contraseña aleatoria
            string password = GenerarContraseñaAleatoria();

            // Crear el usuario y obtener el resultado
            int resultado = gestorUsuario.CrearUsuario(username, password, nombre, apellido, rol, dni);

            // Mostrar el mensaje correspondiente según el resultado
            string mensaje;
            if (resultado == 1)
            {
                mensaje = "Username repetido";
            }
            else if (resultado == 2)
            {
                mensaje = "DNI repetido";
            }
            else
            {
                mensaje = "Usuario creado con éxito. Contraseña generada: " + password;
            }

            // Mostrar el cartel con la información de la fila afectada y el mensaje
            MessageFilaAfectada(selectedRow, mensaje);
            ActualizarTabla();
        }
    }

}
