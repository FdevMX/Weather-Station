using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    internal class DatosConsulta
    {
        private ConexionMySQL conexionMySQL;

        public DatosConsulta()
        {
            conexionMySQL = new ConexionMySQL();
        }
    }
}
