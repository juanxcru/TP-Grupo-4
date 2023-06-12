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

            SqlParameter[] parametros = new SqlParameter[5];
            DataTable dt = new DataTable();

            dt.Columns.Add("id_articulo", typeof(int));
            dt.Columns.Add("cantidad", typeof(double));
            dt.Columns.Add("subtotal", typeof(double));

            foreach (BUE.ItemVenta item in nuevaVenta.ListaArticulos)
            {
                dt.Rows.Add(item.Articulo.IdArticulo , item.Cantidad , item.SubTotal);
            }


            parametros[0] = objConexion.crearParametro("@id_cli ", nuevaVenta.IdCliente);
            parametros[1] = objConexion.crearParametro("@id_emp", nuevaVenta.IdEmpleado);
            parametros[2] = objConexion.crearParametro("@fechahora", nuevaVenta.FechaYHora);
            parametros[3] = objConexion.crearParametro("@monto", nuevaVenta.MontoTotal);
            parametros[4] = objConexion.crearParametro("@items", dt);
            
            objConexion.EscribirPorStoreProcedure("sp_guardar_venta_e_items", parametros);

            return true;


        }
    }
}
