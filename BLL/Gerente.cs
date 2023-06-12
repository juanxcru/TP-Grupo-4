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
        /// <summary>
        /// Genera una tabla de clase Venta recuperando todas las instancias de una venta
        /// con la ID del vendedor pasada por el parametro.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public BUE.Venta[] VerVentaPorUsuario(int ID)
        {
            DAL.VentasDAL data = new DAL.VentasDAL(); 
            DataTable dt = data.MostrarVentas();
            
            BUE.Venta[] ventas = new BUE.Venta[dt.Rows.Count];

            int index2 = 0;
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                BUE.Venta ventaindex = new BUE.Venta();
                if (int.Parse(dt.Rows[index]["id_empleado"].ToString()) == ID)
                {
                    ventaindex.IdVenta = int.Parse(dt.Rows[index]["id_venta"].ToString());
                    ventaindex.FechaYHora = DateTime.Parse(dt.Rows[index]["fecha_hora"].ToString());
                    ventaindex.MontoTotal = double.Parse(dt.Rows[index]["monto_total"].ToString());
                    ventas[index2] = ventaindex;
                    index2++;
                }
                
            }
            return ventas;

        }
        /// <summary>
        /// Genera una tabla de clase Venta con todas las ventas realizadas
        /// desde el principio del mes o los últimos 7 días dependiendo si el parametro es true o false.
        /// </summary>
        /// <param name="menosem"></param>
        /// <returns></returns>
        public BUE.Venta[] Reporte(bool menosem)
        {
            DAL.VentasDAL data = new DAL.VentasDAL();
            DataTable dt = data.MostrarVentas();

            BUE.Venta[] ventas = new BUE.Venta[dt.Rows.Count];

            DateTime fechaRelevante;

            if (menosem)
            {
                fechaRelevante = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            }
            else
            {
                fechaRelevante = DateTime.Now.AddDays(-7);
            }

            int index2 = 0;
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                BUE.Venta ventaindex = new BUE.Venta();
                if (DateTime.Parse(dt.Rows[index]["fecha_hora"].ToString()) > fechaRelevante)
                {
                    ventaindex.IdVenta = int.Parse(dt.Rows[index]["id_venta"].ToString());
                    ventaindex.FechaYHora = DateTime.Parse(dt.Rows[index]["fecha_hora"].ToString());
                    ventaindex.MontoTotal = double.Parse(dt.Rows[index]["monto_total"].ToString());
                    ventas[index2] = ventaindex;
                    index2++;
                }

            }

            return ventas;

        }
    }
}
