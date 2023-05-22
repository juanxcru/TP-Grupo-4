using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Articulo
    {
        private int _idArticulo;

        public int IdArticulo
        {
            get { return _idArticulo; }
            set { _idArticulo = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private double _precio;

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private double _iva;

        public double Iva
        {
            get { return _iva; }
            set { _iva = value; }
        }

        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        private Marca _marca;

        public Marca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
    }
}