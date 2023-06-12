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
        private int _idCliente;
        private int _idEmpleado;
        private double _montoTotal;
        private DateTime _fechaYHora;
        private List<ItemVenta> _listaArticulos = new List<ItemVenta>();

        public Venta()
        {
            ListaArticulos = new List<ItemVenta>();
        }
        public Venta(int idVendedor)
        {
            ListaArticulos = new List<ItemVenta>();
            _idEmpleado = idVendedor;
        }
        public int IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }


        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }


        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }



        public DateTime FechaYHora
        {
            get { return _fechaYHora; }
            set { _fechaYHora = value; }
        }

        public double MontoTotal
        {
            get { return _montoTotal; }
            set { _montoTotal = value; }
        }


        public List<ItemVenta> ListaArticulos
        {
            get { return _listaArticulos; }
            set { _listaArticulos = value; }
        }

    }
}
