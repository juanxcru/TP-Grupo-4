using BUE;
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
        public DataTable zcargarCategoria()
        {
            Conexion objConexion = new Conexion();
            string sp_cargarCategorias = "sp_cargarCategorias";
            DataTable categorias = objConexion.LeerPorStoreProcedure(sp_cargarCategorias);
            return categorias;
        }

        public DataTable cargarMarcas()
        {
            Conexion objConexion = new Conexion();
            string sp_cargarMarca = "sp_cargarMarca";
            DataTable marcas = objConexion.LeerPorStoreProcedure(sp_cargarMarca);
            return marcas;
        }

        public void crearArticulo(Articulo objBUEArticulo)
        {
            //Conexion objConexion = new Conexion();
            //SqlParameter[] parametros = new SqlParameter[5];

            /*parametros[0] = objConexion.crearParametro("@pCategoria", objBUEArticulo.Categoria);
            parametros[1] = objConexion.crearParametro("@pMarca", objBUEArticulo.Marca);*/
            //parametros[0] = objConexion.crearParametro("@pCategoria", 2);
            //parametros[1] = objConexion.crearParametro("@pMarca", 2);
            //parametros[2] = objConexion.crearParametro("@pDescripcion", objBUEArticulo.Descripcion);
            //parametros[3] = objConexion.crearParametro("@pPrecio", objBUEArticulo.Precio);
            //parametros[4] = objConexion.crearParametro("@pStock", objBUEArticulo.Stock);
            //Al devolver filar afectadas, se puede usar para la excepcion
            //objConexion.LeerPorStoreProcedure("sp_CrearArticulo", parametros);
        }

        public DataTable listarArticulos()
        {
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_listarArticulos");

            return dt;
        }

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
            string nombreMarca = dt.Rows[0]["nombre_marca"].ToString();
            BUE.Marca marca = new BUE.Marca();
            marca.NombreMarca = nombreMarca;
            articuloDeRetorno.Marca = marca;

            return articuloDeRetorno;
        }
        public List<Articulo> listarCategorias()
        {
           /* Conexion objConexion = new Conexion();
            string sp_cargarCategorias = "sp_cargarCategorias";
            List<Articulo> categorias = new List<Articulo>();
            DataTable categorias = objConexion.LeerPorStoreProcedure(sp_cargarCategorias);
            categorias = objConexion.LeerPorStoreProcedure(sp_cargarCategorias).ToString();*/
            return null;
        }
    }
}
