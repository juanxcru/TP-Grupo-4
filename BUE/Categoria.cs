using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Categoria
    {
        private int _idCategoria;

        public int IdCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        private string _detalle;

        public string Detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
        }


    }
}
