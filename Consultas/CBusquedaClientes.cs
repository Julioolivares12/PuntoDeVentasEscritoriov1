using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Consultas
{
    public class CBusquedaClientes
    {
        public static DataTable GetClienteByName(string nombre)
        {
            
            var dt = new DataTable();
            using (var con = Conexion.GetConnection())
            {
                using (var adapter= new SqlDataAdapter("select * from CLIENTES where PRIMERNOMBRE = "+$"'{nombre}'", con))
                {
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
