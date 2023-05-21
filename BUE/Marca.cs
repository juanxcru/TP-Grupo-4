using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Marca
    {

        private int _idMarca;

        public int IdMarca
        {
            get { return _idMarca; }
            set { _idMarca = value; }
        }
        private string _nombreMarca;

        public string NombreMarca
        {
            get { return _nombreMarca; }
            set { _nombreMarca = value; }
        }


    }
}
