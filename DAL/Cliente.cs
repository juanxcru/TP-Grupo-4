using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Cliente
    {
        public List<BUE.Cliente> ListarClientes() {

            string usuarioStoreProcedure = "sp_listar_clientes";
            Conexion objConexion = new Conexion();
            List<BUE.Cliente> lista = new List<BUE.Cliente>();
            BUE.Cliente clienteBuffer = new BUE.Cliente();
            
            DataTable dt = objConexion.LeerPorStoreProcedure(usuarioStoreProcedure);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clienteBuffer.IdCliente = int.Parse(dt.Rows[i]["id_cliente"].ToString());
                clienteBuffer.Dni = int.Parse(dt.Rows[i]["dni"].ToString());
                clienteBuffer.Nombre = dt.Rows[i]["nombre"].ToString();
                clienteBuffer.Apellido = dt.Rows[i]["apellido"].ToString();

                lista.Add(clienteBuffer);
                
            }

            return lista;

        }

        public bool GuardarClienteNuevo(BUE.Cliente nuevoCliente)
        {
            Conexion objConexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[4];

            parametros[0] = objConexion.crearParametro("@dni", nuevoCliente.Dni);
            parametros[1] = objConexion.crearParametro("@nombre", nuevoCliente.Nombre);
            parametros[2] = objConexion.crearParametro("@apellido", nuevoCliente.Apellido);
            parametros[3] = objConexion.crearParametro("@email", nuevoCliente.Email);


            if (objConexion.EscribirPorStoreProcedure("sp_guardar_cliente", parametros) > 0) 
                return true;
            else 
                return false;
            
        }

        public bool ExisteDni(int dni)
        {
            Conexion objConexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = objConexion.crearParametro("@dni", dni);
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_existe_dni", parametros);

           return bool.Parse(dt.Rows[0][0].ToString());


        }

        public BUE.Cliente BuscarClientesDni(string dni) {

            Conexion objConexion = new Conexion();
            
            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = objConexion.crearParametro("@dni", int.Parse(dni));
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_buscar_clientes_dni", parametros);
            BUE.Cliente clienteBuffer = new BUE.Cliente();

            if (dt == null || dt.Rows.Count == 0)
                return null;

            clienteBuffer.IdCliente = int.Parse(dt.Rows[0]["id_cliente"].ToString());
            clienteBuffer.Dni = int.Parse(dt.Rows[0]["dni"].ToString());
            clienteBuffer.Nombre = dt.Rows[0]["nombre"].ToString();
            clienteBuffer.Apellido = dt.Rows[0]["apellido"].ToString();
            clienteBuffer.Email = dt.Rows[0]["mail"].ToString();





            return clienteBuffer;

        }

    }
}
