using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManageArticulo
    {
        public BUE.Articulo ValidarArticulo(string idArticulo, int cantidad)
        {

            if (string.IsNullOrWhiteSpace(idArticulo))
            {
                return null;
            }
            
            DAL.ArticuloDAL dalArticulo = new DAL.ArticuloDAL();


            return dalArticulo.ValidarArticulo(idArticulo, cantidad);
        }
    }
}
