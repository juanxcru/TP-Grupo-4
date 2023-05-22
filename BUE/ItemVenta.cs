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

        public int IdItemVenta
        {
            get { return _idItemVenta; }
            set { _idItemVenta = value; }
        }
        private double _cantidad;

        public double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        private double _subTotal;

        public double SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

        private Articulo _articulo;

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
