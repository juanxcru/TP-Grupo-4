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
        /// <param name="contraseña"></param>
        /// <returns>Si el Datatable es null o la cantidad de filas es 0, retornamos nulo, sino retornamos el objeto de negocio</returns>
        public BUE.Usuario ValidarUsuario(string nombreUsuario, string contraseña)
        {
            string usuarioStoreProcedure = "sp_validar_usuario";
            SqlParameter[] parametros = new SqlParameter[2];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@username", nombreUsuario);
            parametros[1] = objConexion.crearParametro("@password", contraseña);

            DataTable dt = objConexion.LeerPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            BUE.Usuario usuarioDeRetorno = new BUE.Usuario();
            usuarioDeRetorno.ID = int.Parse(dt.Rows[0][0].ToString());
            usuarioDeRetorno.UserName = dt.Rows[0]["nombre_usuario"].ToString();
            usuarioDeRetorno.Password = contraseña;
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
        /// <param name="contraseña"></param>
        /// <param name="perfil"></param>
        /// <returns></returns>
        public BUE.Usuario CrearUsuario(string nombre, string apellido, int dni, string nombreUsuario, string contraseña, int perfil)
        {
            string usuarioStoreProcedure = "sp_alta_usuario";
            SqlParameter[] parametros = new SqlParameter[6];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@username", nombreUsuario);
            parametros[1] = objConexion.crearParametro("@password", contraseña);
            parametros[2] = objConexion.crearParametro("@nombre", nombre);
            parametros[3] = objConexion.crearParametro("@apellido", apellido);
            parametros[4] = objConexion.crearParametro("@id_perfil", perfil);
            parametros[5] = objConexion.crearParametro("@dni_empleado", dni);

            // Ejecutar el procedimiento almacenado para crear el usuario
            int filasAfectadas = objConexion.EscribirPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (filasAfectadas > 0)
            {
                // Si se creó el usuario correctamente, retornar el objeto Usuario creado
                BUE.Usuario usuarioCreado = new BUE.Usuario();
                usuarioCreado.UserName = nombreUsuario;
                usuarioCreado.Password = contraseña;
                usuarioCreado.Perfil = new BUE.Perfil();
                usuarioCreado.Perfil.ID = perfil;

                return usuarioCreado;
            }
            else
            {
                // Si no se creó el usuario correctamente, retornar null o lanzar una excepción
                return null;
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

            DataTable dt = objConexion.LeerPorStoreProcedure("sp_merge_usuarios");

            return dt;
        }

    }
}
