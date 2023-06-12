using BUE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManageCliente
    {

        private DAL.Cliente objCliente;

        public ManageCliente()
        {
            objCliente = new DAL.Cliente();
        }
        public List<BUE.Cliente> ListarClientes()
        {
            

            return objCliente.ListarClientes();


        }

        public BUE.Cliente BuscarDni(string dni) {

            if (!string.IsNullOrEmpty(dni) && dni.All(char.IsDigit))
                return objCliente.BuscarClientesDni(dni);              
            else
                return null;


        }

        public bool GuardarClienteNuevo(Cliente nuevoCliente)
        {
            return objCliente.GuardarClienteNuevo(nuevoCliente);
           
        }

        public bool ExisteClienteDni(int dni)
        {
            return objCliente.ExisteDni(dni);
        }
    }
}
