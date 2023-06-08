using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Excepciones
{
    public class ExcepcionesArticulos : Exception
    {
        public static void verificarCamposCargaArtculo(string _descripcion, int _categoria, int _marca, double _precio, double _cantidad)
        {
            //Descripcion
            if (string.IsNullOrEmpty(_descripcion)) {
                throw new Exception("Debe ingresar una descripción.");
            }
            //Categoria
            if (_categoria == 0)
            {
                throw new Exception("Debe ingresar una categoria.");
            }
            //Marca
            if (_marca == 0)
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
