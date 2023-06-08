using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Excepciones
{
    public class ExcepcionesArticulos : Exception
    {
        public static void verificarCamposCargaArtculo(string _descripcion, int _categoria, int _marca, int _precio, int _cantidad)
        //public static void verificarCamposCargaArtculo(string _descripcion, string _categoria, string _marca, int _precio, int _cantidad)
        {
            //Descripcion
            if (string.IsNullOrEmpty(_descripcion)) {
                throw new Exception("Debe ingresar una descripción.");
            }
            //Categoria
            //if (string.IsNullOrEmpty(_categoria))
            if (_categoria == 1)
            {
                throw new Exception("Debe ingresar una categoria.");
            }
            //Marca
            //if (string.IsNullOrEmpty(_marca))
            if (_marca == 1)
            {
                throw new Exception("Debe ingresar una marca.");
            }
            //Precio
            if (_precio <= 0)
            {
                throw new Exception("El precio del producto no es válido.");
            }
            //Cantidad
            if (_cantidad <= 0)
            {
                throw new Exception("La cantidad del producto no es válida");
            }
        }
    }
}
