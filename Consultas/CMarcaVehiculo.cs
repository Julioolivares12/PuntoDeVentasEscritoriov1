using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Consultas
{
    public class CMarcaVehiculo
    {
        public static DataTable GetMarcas()
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter("select * from MARCASVEHICULOS",con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
