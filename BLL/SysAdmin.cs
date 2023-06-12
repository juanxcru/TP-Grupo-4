using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BUE;

namespace BLL
{
    public class SysAdmin : Usuario
    {


        /// <summary>
        /// Crea al usuario en la base de datos
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="perfil"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public int CrearUsuario(string nombreUsuario, string password, string nombre, string apellido, int perfil, int dni)
        {
            UsuarioDAL userIngresado = new UsuarioDAL();

            int rep = userIngresado.usuarioRepetido(0, nombreUsuario, dni);

            switch (rep)
            {
                case 1: return 1;
                case 2: return 2;
            }

            userIngresado.CrearUsuario(nombreUsuario, password, nombre, apellido, perfil, dni);

            return 0;
        }

        public int EditarUsuario(int IDEmpleado, string nombreUsuario, string nombre, string apellido, int perfil, int dni)
        {
            UsuarioDAL userIngresado = new UsuarioDAL();

            int rep = userIngresado.usuarioRepetido(IDEmpleado, nombreUsuario, dni);

            switch (rep)
            {
                case 1: return 1;
                case 2: return 2;
            }

            userIngresado.EditarUsuario(IDEmpleado, nombreUsuario, nombre, apellido, perfil, dni);

            return 0;
        }

        public int BajaUsuario(int IDEmpleado)
        {
            UsuarioDAL userIngresado = new UsuarioDAL();

            userIngresado.BajaUsuario(IDEmpleado);

            return 0;

        }

        /// <summary>
        /// Lista de usuarios con su información completa
        /// </summary>
        /// <returns></returns>
        public List<BUE.Usuario> ObtenerListaUsuarios()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            DataTable dt = usuarioDAL.ActualizarTabla();

            List <BUE.Usuario> usuarios = new List<BUE.Usuario>();

            foreach (DataRow dr in dt.Rows)
            {
                BUE.Usuario user = new BUE.Usuario();
                user.ID = Convert.ToInt32(dr["id_usuario"]);
                user.UserName = dr["nombre_usuario"].ToString();
                user.Password = dr["password"].ToString();

                BUE.Empleado empleado = new BUE.Empleado();
                empleado.IdEmpleado = Convert.ToInt32(dr["id_empleado"]);
                empleado.Nombre = dr["nombre"].ToString();
                empleado.Apellido = dr["apellido"].ToString();
                empleado.Dni = Convert.ToInt32(dr["dni_empleado"]);

                BUE.Perfil perfil = new BUE.Perfil();
                perfil.ID = Convert.ToInt32(dr["id_perfil"]);
                perfil.Descripcion = dr["descripcion"].ToString();

                user.Empleado = empleado;
                user.Perfil = perfil;
                usuarios.Add(user);
            }

            return usuarios;
        }

        public List<BUE.Perfil> getPerfiles()
        {
            List<BUE.Perfil> perfiles = new List<BUE.Perfil>();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            DataTable dt = usuarioDAL.ObtenerPerfiles();

            foreach (DataRow dr in dt.Rows)
            {
                BUE.Perfil perfil = new BUE.Perfil();
                perfil.ID = Convert.ToInt32(dr["id_perfil"]);
                perfil.Descripcion = dr["descripcion"].ToString();
                perfiles.Add(perfil);
            }

            return perfiles;

        }
    }
}
