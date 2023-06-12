using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentasDAL
    {
        public DataTable MostrarVentas()
        {
            string usuarioStoreProcedure = "ver_ventas";
            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorStoreProcedure(usuarioStoreProcedure, null);

            return dt;
        }
    }
}
