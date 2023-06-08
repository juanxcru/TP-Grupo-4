//using DAL.Properties;
using BUE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLRepositor
    {
        DAL.DALRepositor objRepositor = new DAL.DALRepositor();

        public void crearArticulo(Articulo objBUEArticulo, Categoria objBUECategoria, Marca objBUEMarca)
        {
            objRepositor.crearArticulo(objBUEArticulo, objBUECategoria, objBUEMarca);
        }

        public DataTable generarAlerta()
        {
           return objRepositor.generarAlerta();
        }
    }
}
