using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Consultas
{
   public class CMetodosTomar
    {
        public static DataTable GetMetodosTomar()
        {
            var dt = new DataTable();
            using (var con = Conexion.GetConnection())
            {
                using (var adt = new SqlDataAdapter("SELECT ID_METODO , METODO FROM METODOSTOMAR", con))
                {
                    adt.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
