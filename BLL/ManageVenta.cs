using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUE;

namespace BLL
{
    public class ManageVenta
    {
        public void RealizarVenta(Venta venta)
        {
            
        }

        public double CalcularTotal(Venta venta)
        {
            double total = 0;
            foreach (Articulo articulo in venta.ListaArticulos)
            {
                total += articulo.Precio * articulo.Stock;
            }
            return total;
        }

        public void AgregarArticuloAVenta(Articulo articulo, int cantidad, Venta venta)
        {
            ItemVenta nuevoItem = new ItemVenta
            {
                Cantidad = cantidad,
                SubTotal = cantidad * articulo.Precio
            };

            venta.ListaArticulos.Add(articulo);
        }

    }
}
