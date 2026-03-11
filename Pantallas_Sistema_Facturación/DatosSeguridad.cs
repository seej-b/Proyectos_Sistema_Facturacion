using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantallas_Sistema_Facturación
{
    internal class DatosSeguridad
    {
        Conexion con = new Conexion();

        public DataTable ListarEmpleados()
        {
            NpgsqlConnection cn = con.conectar();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(
                "SELECT id_empleado, nombre FROM empleados", cn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cn.Close();

            return dt;
        }

        public void InsertarUsuario(int idEmpleado, string usuario, string clave)
        {
            using (var cn = con.conectar())
            using (var cmd = new NpgsqlCommand(
                "INSERT INTO usuarios(id_empleado,usuario,clave) VALUES(@emp,@user,@pass)", cn))
            {
                cmd.Parameters.AddWithValue("@emp", idEmpleado);
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", clave);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
