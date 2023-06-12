using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Venta
    {
        public bool GrabarVenta(BUE.Venta nuevaVenta)
        {
             
            Conexion objConexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = objConexion.crearParametro("@id_cli ", nuevaVenta.IdCliente);
            parametros[1] = objConexion.crearParametro("@id_emp", nuevaVenta.IdEmpleado);
            parametros[2] = objConexion.crearParametro("@fechahora", nuevaVenta.FechaYHora);
            parametros[3] = objConexion.crearParametro("@monto", nuevaVenta.MontoTotal);

           int filasAfectadas = objConexion.EscribirPorStoreProcedure("sp_guardar_venta", parametros);



            if (filasAfectadas > 0)
            {
              

                parametros = new SqlParameter[2];

                foreach (BUE.ItemVenta iv in nuevaVenta.ListaArticulos)
                {
         

                    parametros[0] = objConexion.crearParametro("@id_venta", nuevaVenta.IdVenta);

                    parametros[1] = objConexion.crearParametro("@cant", iv.Cantidad);
                    parametros[2] = objConexion.crearParametro("@subtot", iv.SubTotal);

                    objConexion.EscribirPorStoreProcedure("sp_guardar_items_venta", parametros);

                }


                return true;
            }
            else
                return false;

        }
    }
}
