using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALMarcas
    {
        public DataTable listarMarcas()
        {
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_cargarMarca");

            return dt;
        }
    }
}
