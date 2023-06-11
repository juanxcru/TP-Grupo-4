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
        private static int lastItemId = 0;
        public void RealizarVenta(Venta venta)
        {

        }

        public double CalcularTotal(Venta venta)
        {
            double total = 0;
            foreach (ItemVenta itemVenta in venta.ListaArticulos)
            {
                total += itemVenta.Articulo.Precio * itemVenta.Cantidad;
            }
            return total;
        }

        public Venta AgregarArticuloAVenta(Articulo articulo, int cantidad, Venta venta)
        {

            foreach (ItemVenta  iv in venta.ListaArticulos) {

                if (iv.Articulo.IdArticulo.Equals(articulo.IdArticulo))
                {
                    iv.Cantidad += cantidad;
                    iv.SubTotal = iv.Cantidad * articulo.Precio;
                    venta.MontoTotal += iv.SubTotal;
                    return venta;
                }
            }
            
            
            ItemVenta itemVenta = new ItemVenta
            {
                IdItemVenta = GenerateItemId(),
                Cantidad = cantidad,
                SubTotal = cantidad * articulo.Precio,
                Articulo = articulo
            };


            venta.ListaArticulos.Add(itemVenta);


            venta.MontoTotal += itemVenta.SubTotal;

            return venta;
        }

        private static int GenerateItemId()
        {

            lastItemId++;
            return lastItemId;
        }

        public void AgregarItemVenta(ItemVenta itemVenta, Venta venta)
        {
            venta.ListaArticulos.Add(itemVenta);
        }
    }
}
