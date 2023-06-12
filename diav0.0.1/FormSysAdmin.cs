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
            string rol = fila.Cells["Rol"].Value.ToString();

            // Construir la información de la fila afectada
            string infoFilaAfectada = $"Nombre: {nombre}\n" +
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

        /// <summary>
        /// Actualiza la tabla de usuarios con la información total
        /// </summary>
        public void ActualizarTabla()
        {
            List<BUE.Usuario> usuarios = gestorUsuario.ObtenerListaUsuarios();

            ActualizarTablaUsuarios(usuarios);
        }

        /// <summary>
        /// Actualiza la tabla de usuarios con la información correspondiente
        /// </summary>
        /// <param name="listaDeUsuarios"></param>
        /// <returns></returns>
        public void ActualizarTablaUsuarios(List<BUE.Usuario> usuarios)
        {
            GridUsuarios.Rows.Clear();
           
            var combobox = (DataGridViewComboBoxColumn)GridUsuarios.Columns["Rol"];
            combobox.DisplayMember = "Descripcion"; // Nombre de la propiedad para mostrar en el DropDownList
            combobox.ValueMember = "ID"; // Nombre de la propiedad para obtener el valor seleccionado
            combobox.DataSource = GetLista(); // Fuente de datos para el DropDownList

            foreach (var user in usuarios)
            {
                // Crear una nueva fila
                DataGridViewRow nuevaFila = new DataGridViewRow();

                // Agregar celdas a la fila del DataGrid
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = user.Empleado.IdEmpleado });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = user.Empleado.Nombre });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = user.Empleado.Apellido });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = user.Empleado.Dni });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = user.UserName });
                int Rol = user.Perfil.ID;

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
            gestionarUsuario(1);
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            gestionarUsuario(2);
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            gestionarUsuario(3);
        }

        /// <summary>
        /// Gestiono el usuario a partir de la opcion solicitada.
        /// 1 para crear, 2 para modificar, 3 para eliminar
        /// </summary>
        /// <param name="accion"></param>
        private void gestionarUsuario(int accion)
        {
            if (GridUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una fila.");
                return;
            }

            DataGridViewRow selectedRow = GridUsuarios.SelectedRows[0];

            // Obtener los valores de la fila seleccionada
            int idEmpleado = Convert.ToInt32(selectedRow.Cells["IDEmpleado"].Value);
            string nombre = selectedRow.Cells["Nombre"].Value?.ToString()?.ToUpper() ?? string.Empty;
            string apellido = selectedRow.Cells["Apellido"].Value?.ToString()?.ToUpper() ?? string.Empty;
            int dni = Convert.ToInt32(selectedRow.Cells["DNI"].Value);
            string username = selectedRow.Cells["Username"].Value?.ToString()?.ToLower() ?? string.Empty;
            int rol = Convert.ToInt32(selectedRow.Cells["Rol"].Value);

            // Validar que no haya campos nulos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(username) || dni == 0 || rol == 0)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.");
                return;
            }

            int resultado = 0;
            string mensaje = "";
            string password = "";

            if (accion == 1)
            {
                // Generar una contraseña aleatoria
                password = GenerarContraseñaAleatoria();

                // Crear el usuario y obtener el resultado
                resultado = gestorUsuario.CrearUsuario(username, password, nombre, apellido, rol, dni);
            }
            else if (accion == 2)
                // Modificar el usuario y obtener el resultado
                resultado = gestorUsuario.EditarUsuario(idEmpleado, username, nombre, apellido, rol, dni);
            else if (accion == 3)
                // Eliminar usuario y obtener su resultado
                resultado = gestorUsuario.BajaUsuario(idEmpleado);

            // Mostrar el mensaje correspondiente según el resultado
            if (resultado == 1)
                mensaje = "Username repetido. Intente nuevamente.";
            else if (resultado == 0)
            {
                if (accion == 1)
                    mensaje = "Usuario creado con éxito. Contraseña generada: " + password;
                if (accion == 2 || accion == 3)
                    mensaje = "Usuario no existente en la base de datos";
            }
            else if (resultado == 4)
            {
                if (accion == 2)
                    mensaje = "Usuario modificado con éxito.";
                if (accion == 3)
                    mensaje = "Usuario eliminado con éxito";
            }
            else
                mensaje = "Hubo un error";

            // Mostrar el cartel con la información de la fila afectada y el mensaje
            MessageFilaAfectada(selectedRow, mensaje);
        }

        /// <summary>
        /// Filtro los usuarios en funcion de la opcion elegida en el cboxBuscador
        /// </summary>
        private void FiltrarUsuarios()
        {
            // Obtener la opción seleccionada del ComboBox
            string opcion = cboxBuscador.SelectedItem?.ToString() ?? string.Empty;

            // Obtener el valor ingresado en el TextBox
            string valor = txtboxBuscador.Text.ToUpper();

            if (string.IsNullOrEmpty(opcion) || string.IsNullOrEmpty(valor))
            {
                ActualizarTabla();
                return;
            }

            // Llama a la función gestorUsuario.ObtenerListaUsuarios() para obtener la lista completa de usuarios
            List<BUE.Usuario> listaUsuarios = gestorUsuario.ObtenerListaUsuarios();

            // Filtrar los usuarios según la opción seleccionada y el valor ingresado
            List<BUE.Usuario> usuariosFiltrados;

            // Aplicar el filtro según la opción seleccionada y el valor ingresado
            switch (opcion)
            {
                case "ID Empleado":
                    usuariosFiltrados = listaUsuarios.Where(u => u.Empleado.IdEmpleado.ToString() == valor).ToList();
                    break;
                case "Nombre":
                    usuariosFiltrados = listaUsuarios.Where(u => u.Empleado.Nombre.Contains(valor)).ToList();
                    break;
                case "Apellido":
                    usuariosFiltrados = listaUsuarios.Where(u => u.Empleado.Apellido.Contains(valor)).ToList();
                    break;
                case "DNI":
                    usuariosFiltrados = listaUsuarios.Where(u => u.Empleado.Dni.ToString() == valor).ToList();
                    break;
                case "Rol":
                    usuariosFiltrados = listaUsuarios.Where(u => u.Perfil.Descripcion.StartsWith(valor, StringComparison.OrdinalIgnoreCase)).ToList();
                    break;
                default:
                    usuariosFiltrados = listaUsuarios;
                    break;
            }

            // Actualizar el DataGridView con los usuarios filtrados
            ActualizarTablaUsuarios(usuariosFiltrados);
        }

        private void txtboxBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                FiltrarUsuarios();
                e.Handled = true; // Para evitar que se agregue un salto de línea en el TextBox
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }
    }

}
