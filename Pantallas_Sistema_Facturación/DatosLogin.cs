using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace Pantallas_Sistema_Facturación
{
    
    internal class DatosLogin
    {
        Conexion cn = new Conexion();
        public NpgsqlDataReader ValidarUsuario(string usuario, string clave)
        {
            NpgsqlConnection conexion = cn.conectar();

            string query = @"SELECT e.nombre, e.cargo
                             FROM usuarios u
                             INNER JOIN empleados e
                             ON u.id_empleado = e.id_empleado
                             WHERE u.usuario = @usuario 
                             AND u.clave = @clave";

            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@clave", clave);

            return cmd.ExecuteReader();
        }

    }
}
