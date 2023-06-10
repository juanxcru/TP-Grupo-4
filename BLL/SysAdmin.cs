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
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool CrearUsuario(BUE.Usuario usuario)
        {
           
            
           return true;
        }
        /// <summary>
        /// Lista de usuarios con su información completa
        /// </summary>
        /// <returns></returns>
        public List<(BUE.Empleado, BUE.Usuario, BUE.Perfil)> ObtenerListaUsuarios()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            DataTable dt = usuarioDAL.ActualizarTabla();

            List<(BUE.Empleado, BUE.Usuario, BUE.Perfil)> listaUsuarios = new List<(BUE.Empleado, BUE.Usuario, BUE.Perfil)>();

            foreach (DataRow dr in dt.Rows)
            {
                BUE.Empleado empleado = new BUE.Empleado();
                empleado.IdEmpleado = Convert.ToInt32(dr["id_empleado"]);
                empleado.Nombre = dr["nombre"].ToString();
                empleado.Apellido = dr["apellido"].ToString();
                empleado.Dni = Convert.ToInt32(dr["dni_empleado"]);

                BUE.Usuario usuario = new BUE.Usuario();
                usuario.ID = Convert.ToInt32(dr["id_usuario"]);
                usuario.UserName = dr["nombre_usuario"].ToString();
                usuario.Password = dr["contraseña"].ToString();

                BUE.Perfil perfil = new BUE.Perfil();
                perfil.ID = Convert.ToInt32(dr["id_perfil"]);
                perfil.Descripcion = dr["descripcion"].ToString();

                listaUsuarios.Add((empleado, usuario, perfil));
            }

            return listaUsuarios;
        }
    }
}
