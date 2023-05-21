using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Empleado
    {
        private int _idEmpleado;

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


    }
}
