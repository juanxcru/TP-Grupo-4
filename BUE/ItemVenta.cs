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



    }
}
