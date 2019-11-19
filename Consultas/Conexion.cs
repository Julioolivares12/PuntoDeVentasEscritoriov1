using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Consultas
{
    class Conexion
    {
        private static string conexionString = ConfigurationManager.ConnectionStrings["conexionSQL"].ConnectionString;
        public static SqlConnection GetConnection()
        {
            var con = new SqlConnection(conexionString);
            con.Open();
            return con;
        }
    }
}
