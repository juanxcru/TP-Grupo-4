﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUE
{
    public class Usuario : IEntidad
    {
        private int _id;
        private string _nombreUsuario;
        private string _password;
        private int _idEmpleado;
        private Perfil _perfil;
        private Empleado _empleado;

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }


        public int ID {
            get { return _id; }
            set { _id = value; }
        }


        public string UserName
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }


        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public Perfil Perfil

        {
            get { return _perfil; }
            set { _perfil = value; }
        }




    }
}
