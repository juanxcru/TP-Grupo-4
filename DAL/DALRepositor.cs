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
    public class DALRepositor
    {
        public DataTable buscarArticulos(Articulo _descripcionArticulo)
        {

            Conexion objConexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = objConexion.crearParametro("@pDescripcion", _descripcionArticulo.Descripcion);

            DataTable dt = objConexion.LeerPorStoreProcedure("sp_listarArticulosAManipular",parametros);

            return dt;
        }

        public DataTable buscarArticulosACargar(Articulo descripcionArticulo)
        {
            Conexion objConexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = objConexion.crearParametro("@pDescripcion", descripcionArticulo.Descripcion);

            DataTable dt = objConexion.LeerPorStoreProcedure("sp_BuscarArticuloACargar", parametros);

            return dt;
        }

        public void cargaStock(Articulo objBUEArticulo, int nudStockNuevo)
        {
            Conexion objConexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = objConexion.crearParametro("@pIdProducto", objBUEArticulo.IdArticulo);
            parametros[1] = objConexion.crearParametro("@pCantidad", nudStockNuevo);
            
            //Al devolver filar afectadas, se puede usar para la excepcion
            objConexion.LeerPorStoreProcedure("sp_cargarStock", parametros);
        }

        public void crearArticulo(Articulo objBUEArticulo, Categoria objBUECategoria, Marca objBUEMarca)
        {
            Conexion objConexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[5];

            parametros[0] = objConexion.crearParametro("@pCategoria", objBUECategoria.IdCategoria);
            parametros[1] = objConexion.crearParametro("@pMarca", objBUEMarca.IdMarca);
            parametros[2] = objConexion.crearParametro("@pDescripcion", objBUEArticulo.Descripcion);
            parametros[3] = objConexion.crearParametro("@pPrecio", objBUEArticulo.Precio);
            parametros[4] = objConexion.crearParametro("@pStock", objBUEArticulo.Stock);
            //Al devolver filar afectadas, se puede usar para la excepcion
            objConexion.LeerPorStoreProcedure("sp_CrearArticulo", parametros);
        }

        public DataTable generarAlerta()
        {
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorStoreProcedure("sp_ProductosAlerta");

            return dt;
        }
    }
}
