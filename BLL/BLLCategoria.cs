using BUE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCategoria
    {
        DAL.DALCategoria objDALCategoria = new DAL.DALCategoria();
        public DataTable listarCategoria()
        {
            return objDALCategoria.listarCategorias();
        }
    }
}
