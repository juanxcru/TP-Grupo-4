using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Usuario
    {
        private int _id;
        public int ID {
            get { return _id; }
            set { _id = value; }
        }

        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private Perfil _perfil;
        public Perfil Perfil

        {
            get { return _perfil; }
            set { _perfil = value; }
        }

        private Empleado _empleado;

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

    }
}
