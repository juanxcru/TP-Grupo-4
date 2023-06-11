﻿using System;
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

        public List<BUE.Cliente> BuscarClientesDni(string dni) {

            Conexion objConexion = new Conexion();
            List<BUE.Cliente> lista = new List<BUE.Cliente>();
            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = objConexion.crearParametro("@dni", dni);
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_buscar_cliente_dni", parametros);
            BUE.Cliente clienteBuffer = new BUE.Cliente();

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

    }
}
