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

        public DataTable buscarArticulo(Articulo _descripcionArticulo)
        {            
            return objRepositor.buscarArticulos(_descripcionArticulo); ;
        }

        public DataTable buscarArticuloACargar(Articulo _descripcionArticulo)
        {
            return objRepositor.buscarArticulosACargar(_descripcionArticulo); ;
        }

        public void cargarStock(Articulo objBUEArticulo, int nudStockNuevo)
        {
            objRepositor.cargaStock(objBUEArticulo,nudStockNuevo);
        }

        public void crearArticulo(Articulo objBUEArticulo, Categoria objBUECategoria, Marca objBUEMarca)
        {
            objRepositor.crearArticulo(objBUEArticulo, objBUECategoria, objBUEMarca);
        }

        public DataTable generarAlerta()
        {
           return objRepositor.generarAlerta();
        }

        public void modificarArticulo(Articulo objBUEArticulo, Categoria objBUECategoria, Marca objBUEMarca)
        {
            objRepositor.modificarArticulo(objBUEArticulo, objBUECategoria, objBUEMarca);
        }
    }
}
