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
        private double _precio;
        private string _descripcion;
        private double _iva;
        private int _stock;
        private Marca _marca;

        public int IdArticulo
        {
            get { return _idArticulo; }
            set { _idArticulo = value; }
        }


        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }


        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }


        public Marca Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        private Categoria _categoria;

        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }


    }
}