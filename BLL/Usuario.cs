using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Usuario 
    {
        /// <summary>
        /// Valida si el usuario y la contraseña son correctas 
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="password"></param>
        /// <returns>Retorna el usuario, en caso valido, sino retorna nulo</returns>
        public BUE.Usuario ValidarUsuario (string nombreUsuario, string password)
        {
            
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                return null;
            }


            DAL.UsuarioDAL dalUsuario = new DAL.UsuarioDAL();


            return dalUsuario.ValidarUsuario(nombreUsuario,password);
        }

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
        /// Lista a los usuarios que estan en la base
        /// </summary>
        /// <returns></returns>
        public List<BUE.Usuario> Usuarios()
        {
            return null;
        }

    }
}
