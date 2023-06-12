using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUE;

namespace BLL
{
    public class ManageVenta
    {
        private static int lastItemId = 0;
        private DAL.Venta objVenta;
        private ManageArticulo objArticulo;
        public ManageVenta()
        {
            objVenta = new DAL.Venta();
            objArticulo = new ManageArticulo();
        }
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

        public bool AgregarArticuloAVenta(Articulo articulo, int cantidad, Venta venta)
        {

            foreach (ItemVenta  iv in venta.ListaArticulos) {

                if (iv.Articulo.IdArticulo.Equals(articulo.IdArticulo)) 
                {
                    if(iv.Articulo.Stock >= (iv.Cantidad + cantidad))
                    {
                        iv.Cantidad += cantidad;
                        iv.SubTotal = iv.Cantidad * articulo.Precio;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

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

            return true;
        }

        private static int GenerateItemId()
        {

            lastItemId++;
            return lastItemId;
        }


        public void RestarStock(Venta venta)
        {

            BLLRepositor repositor = new BLLRepositor();

            foreach (ItemVenta iv in venta.ListaArticulos)
            {
                
                repositor.cargarStock(iv.Articulo, (int)Math.Round(iv.Cantidad)*-1 );
            }


        }
     

        public bool GrabarVenta(Venta nuevaVenta)
        {

            try
            {
                objVenta.GrabarVenta(nuevaVenta);
            }
            catch (Exception)
            {
                
                return false;
            }

                
            
            return true;
        }
    }
}
