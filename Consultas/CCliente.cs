using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultas
{
    public class CCliente
    {
        public static Cliente GetClienteByID(string id)
        {
            Cliente cliente = new Cliente();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null,con))
                {
                    cmd.CommandText = "SELECT ID_CLIENTE, PRIMERNOMBRE,SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO , SEXO,ESTADO_CIVIL FROM CLIENTES WHERE ID_CLIENTE = @ID_CLIENTE";
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", id);
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            cliente.ID = rs["ID_CLIENTE"].ToString();
                            cliente.PRIMERNOMBRE = rs["PRIMERNOMBRE"].ToString();
                            cliente.SEGUNDONOMBRE = rs["SEGUNDONOMBRE"].ToString();
                            cliente.PRIMERAPELLIDO = rs["PRIMERAPELLIDO"].ToString();
                            cliente.SEGUNDOAPELLIDO = rs["SEGUNDOAPELLIDO"].ToString();
                            cliente.SEXO = rs["SEXO"].ToString();
                            cliente.ESTADO_CIVIL = rs["ESTADO_CIVIL"].ToString(); 
                        }
                    }
                }
            }
            return cliente;

        }

        public static DataTable GetClientesComboBox()
        {
            
            
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_CLIENTE as id , PRIMERNOMBRE +' '+PRIMERAPELLIDO as cliente FROM CLIENTES",con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
