using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLMarcas
    {        
        DAL.DALMarcas objDALMArcas = new DAL.DALMarcas();
        public DataTable listarMarcas()
        {
            return objDALMArcas.listarMarcas();
        }

    }
}
