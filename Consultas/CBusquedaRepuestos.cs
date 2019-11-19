using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Consultas
{
    public class CBusquedaRepuestos
    {
        public static DataTable GetRepuestosByMarca(int idMarca)
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adaptar = new SqlDataAdapter($"select * from REPUESTOS where ID_MARCAVEH = {idMarca}", con))
                {
                    var dt = new DataTable();

                    adaptar.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable GetRepuestosByParte(int idParte)
        {
            using (var con= Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter($"select * from REPUESTOS where ID_PARTEVEH = {idParte}", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    return dt;
                }
            }
        }

        public static DataTable GetRepuestosByNombre(string nombre)
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter($"select * from REPUESTOS where NOMBRE ='{nombre}'", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
