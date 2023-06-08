using BUE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCategoria
    {
        public DataTable listarCategorias()
        {
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_cargarCategorias");
           
            return dt;
        }
    }
}
