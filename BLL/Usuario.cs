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


    }
}
