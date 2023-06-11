using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class ItemVenta
    {


        private int _idItemVenta;
        private double _cantidad;
        private double _subTotal;
        private Articulo _articulo;

        public int IdItemVenta
        {
            get { return _idItemVenta; }
            set { _idItemVenta = value; }
        }

        public double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public double SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }


        public Articulo Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }

        public ItemVenta()
        {

        }

        public ItemVenta(double cantidad, Articulo articulo)
        {
            Cantidad = cantidad;
            Articulo = articulo;
        }
    }
}
