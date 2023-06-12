using BUE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class UsuarioDAL
    {
        /// <summary>
        /// Invocamos al store procedure que devuelve un DataTable, instanciamos un objeto de negocio y lo poblamos
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>
        /// <returns>Si el Datatable es null o la cantidad de filas es 0, retornamos nulo, sino retornamos el objeto de negocio</returns>
        public BUE.Usuario ValidarUsuario(string nombreUsuario, string password)
        {
            string usuarioStoreProcedure = "sp_validar_usuario";
            SqlParameter[] parametros = new SqlParameter[2];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@username", nombreUsuario);
            parametros[1] = objConexion.crearParametro("@password", password);

            DataTable dt = objConexion.LeerPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            BUE.Usuario usuarioDeRetorno = new BUE.Usuario();
            usuarioDeRetorno.ID = int.Parse(dt.Rows[0][0].ToString());
            usuarioDeRetorno.UserName = dt.Rows[0]["nombre_usuario"].ToString();
            usuarioDeRetorno.Password = password;
            usuarioDeRetorno.Perfil = new BUE.Perfil();
            usuarioDeRetorno.Perfil.ID = int.Parse(dt.Rows[0]["id_perfil"].ToString());
            usuarioDeRetorno.Perfil.Descripcion = dt.Rows[0]["descripcion"].ToString();


            return usuarioDeRetorno;
        }

        /// <summary>
        /// Damos de alta un usuario en el programa y devuelve el usuario creado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>
        /// <param name="perfil"></param>
        /// <returns></returns>
        public bool CrearUsuario(string nombreUsuario, string password, string nombre, string apellido, int perfil, int dni)
        {
            string usuarioStoreProcedure = "sp_insertar_usuario";
            SqlParameter[] parametros = new SqlParameter[6];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@nombreUsuario", nombreUsuario);
            parametros[1] = objConexion.crearParametro("@password", password);
            parametros[2] = objConexion.crearParametro("@nombre", nombre);
            parametros[3] = objConexion.crearParametro("@apellido", apellido);
            parametros[4] = objConexion.crearParametro("@idPerfil", perfil);
            parametros[5] = objConexion.crearParametro("@dni", dni);

            // Ejecutar el procedimiento almacenado para crear el usuario
            int filasAfectadas = objConexion.EscribirPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (filasAfectadas > 0)
            {
                // Si se creó el usuario correctamente, retornar true
                return true;
            }
            else
            {
                // Si no se creó el usuario correctamente, retornar false o lanzar una excepción
                return false;
            }

        }


        public bool EditarUsuario(int IDEmpleado, string nombreUsuario, string nombre, string apellido, int perfil, int dni)
        {
            string usuarioStoreProcedure = "sp_modificar_usuario";
            SqlParameter[] parametros = new SqlParameter[6];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@nombreUsuario", nombreUsuario);
            parametros[1] = objConexion.crearParametro("@idEmpleado", IDEmpleado);
            parametros[2] = objConexion.crearParametro("@nombre", nombre);
            parametros[3] = objConexion.crearParametro("@apellido", apellido);
            parametros[4] = objConexion.crearParametro("@idPerfil", perfil);
            parametros[5] = objConexion.crearParametro("@dni", dni);

            // Ejecutar el procedimiento almacenado para crear el usuario
            int filasAfectadas = objConexion.EscribirPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (filasAfectadas > 0)
            {
                // Si se modificó el usuario correctamente, retornar true
                return true;
            }
            else
            {
                // Si no se creó el usuario correctamente, retornar false o lanzar una excepción
                return false;
            }

        }

        public bool BajaUsuario(int IDEmpleado)
        {
            string usuarioStoreProcedure = "sp_eliminar_usuario";
            SqlParameter[] parametros = new SqlParameter[1];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@idEmpleado", IDEmpleado);

            // Ejecutar el procedimiento almacenado para crear el usuario
            int filasAfectadas = objConexion.EscribirPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (filasAfectadas > 0)
            {
                // Si se eliminó el usuario correctamente, retornar true
                return true;
            }
            else
            {
                // Si no se creó el usuario correctamente, retornar false o lanzar una excepción
                return false;
            }

        }

        /// <summary>
        /// Corrobora que el usuario no esté duplicado
        /// </summary>
        /// <param name="username"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public int usuarioRepetido(int IDEmpleado, string username, int dni)
        {
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_ver_usuarios");
            bool bandera = false;

            foreach (DataRow dr in dt.Rows)
            {
                BUE.Empleado empleado = new BUE.Empleado();

                if (Convert.ToInt32(dr["id_empleado"]) != IDEmpleado)
                {
                    if (dr["nombre_usuario"].ToString() == username)
                        return 1;

                    if (Convert.ToInt32(dr["dni_empleado"]) == dni)
                        return 2;
                }
                else
                    bandera = true;
            }

            if (bandera == false)
            {
                return 0;
            }
            else
            {
                return 4;
            }
            
        }

        /// <summary>
        /// Devuelve un DataTable con la información cruzada entre las tablas:
        /// EMPLEADO + USUARIO + PERFIL
        /// </summary>
        /// <returns></returns>
        public DataTable ActualizarTabla()
        {
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorStoreProcedure("sp_ver_usuarios");

            return dt;
        }

        /// <summary>
        /// Obtengo los perfiles creados en la BBDD
        /// </summary>
        /// <returns></returns>
        public DataTable ObtenerPerfiles()
        {
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorStoreProcedure("sp_select_perfil");

            return dt;
        }
    }
}
