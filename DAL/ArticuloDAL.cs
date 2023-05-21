using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ArticuloDAL
    {
        public BUE.Articulo ValidarArticulo(string idArticulo, int cantidad)
        {
            string usuarioStoreProcedure = "sp_validar_articulo";
            SqlParameter[] parametros = new SqlParameter[2];
            Conexion objConexion = new Conexion();
            parametros[0] = objConexion.crearParametro("@id", idArticulo);
            parametros[1] = objConexion.crearParametro("@cantidad", cantidad);

            DataTable dt = objConexion.LeerPorStoreProcedure(usuarioStoreProcedure, parametros);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            BUE.Articulo articuloDeRetorno = new BUE.Articulo();
            articuloDeRetorno.IdArticulo = int.Parse(dt.Rows[0][0].ToString());
            articuloDeRetorno.Descripcion = dt.Rows[0]["descripcion"].ToString();
            articuloDeRetorno.Iva = double.Parse(dt.Rows[0]["iva"].ToString());
            articuloDeRetorno.Precio = double.Parse(dt.Rows[0]["precio"].ToString());
            articuloDeRetorno.Stock = int.Parse(dt.Rows[0]["stock"].ToString());
       


            return articuloDeRetorno;
        }
    }
}
