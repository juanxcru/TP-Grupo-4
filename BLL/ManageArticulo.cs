using BUE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManageArticulo
    {
        private ArticuloDAL articuloDAL;

        public ManageArticulo()
        {
            articuloDAL = new ArticuloDAL();
        }

        public Articulo ValidarArticulo(string idArticulo, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(idArticulo))
            {
                return null;
            }

            return articuloDAL.ValidarArticulo(idArticulo, cantidad);
        }
    }
}
