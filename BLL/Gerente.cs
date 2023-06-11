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
    public class Gerente : Usuario
    {
        public BUE.Venta VerVentaPorUsuario(int ID)
        {
            DAL.VentasDAL ventas = new DAL.VentasDAL(); 
            DataTable dt = ventas.MostrarVentas();
            BUE.Venta Venta = new BUE.Venta();
            BUE.Venta[] Ventas = new BUE.Venta[dt.Rows.Count];

            int index2 = 0;
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                if (int.Parse(dt.Rows[index]["id_empleado"].ToString()) == ID)
                Venta.IdVenta = int.Parse(dt.Rows[index]["id_venta"].ToString());
                Venta.FechaYHora = DateTime.Parse(dt.Rows[index]["fecha_hora"].ToString());
                Venta.MontoTotal = double.Parse(dt.Rows[index]["monto_total"].ToString());
                Ventas[index2] = Venta;
                index2++;
            }

            return Venta;

        }
    }
}
