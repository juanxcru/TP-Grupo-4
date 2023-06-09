﻿using BUE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManageArticulo
    {      
        public ManageArticulo()
        {
            
        }
        ArticuloDAL articuloDAL = new ArticuloDAL();

        public Articulo ValidarArticulo(string idArticulo, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(idArticulo))
            {
                return null;
            }

            return articuloDAL.ValidarArticulo(idArticulo, cantidad);
        }

        public DataTable listarArticulos()
        {
            return articuloDAL.listarArticulos();
        }
    }
}
