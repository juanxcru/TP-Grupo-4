using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Lista a los usuarios que estan en la base
        /// </summary>
        /// <returns></returns>
        public List<BUE.Usuario> Usuarios()
        {
            return null;
        }
    }
}
