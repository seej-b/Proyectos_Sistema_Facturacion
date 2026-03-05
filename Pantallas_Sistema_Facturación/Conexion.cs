using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_Facturación
{
    internal class Conexion
    {
        string cadena = "Host=localhost;Port=5432;Database=SisFat;Username=postgres;Password=1234";

        public NpgsqlConnection conectar()
        {
            NpgsqlConnection cn = new NpgsqlConnection(cadena);
            cn.Open();
            return cn;
        }
    }
}
