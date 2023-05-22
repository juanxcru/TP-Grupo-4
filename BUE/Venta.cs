using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Venta
    {
        private int _idVenta;

        public int IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }
        private DateTime _fechaYHora;

        public DateTime FechaYHora
        {
            get { return _fechaYHora; }
            set { _fechaYHora = value; }
        }
        private double _montoTotal;

        public double MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }

        private List<ItemVenta> _listaArticulos = new List<ItemVenta>();

        public List<ItemVenta> ListaArticulos
        {
            get { return _listaArticulos; }
            set { _listaArticulos = value; }
        }

        public Venta()
        {
            ListaArticulos = new List<ItemVenta>();
        }
    }
}
