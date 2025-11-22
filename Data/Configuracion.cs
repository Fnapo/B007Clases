using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B007Clases.Data
{
    public static class Configuracion
    {
        private static readonly string cadenaConexion = "";
        //Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=B007Crud";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
