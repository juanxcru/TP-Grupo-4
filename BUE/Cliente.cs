using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Cliente
    {
        private int _idCliente;
        private string _nombre;
        private string _apellido;
        private string _email;
        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }


    }
}
