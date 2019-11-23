using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
using Consultas;

namespace Consultas
{
    public class CClaseDeVehiculo
    {

        public static async Task<Int32> ExecuteNonQueryAsync(SqlConnection connection, string commandText
           , CommandType commandType, params SqlParameter[] parameters)
        {
            using (connection)
            {
                using (SqlCommand sqlCommand = new SqlCommand(commandText, connection))
                {
                    sqlCommand.CommandType = commandType;
                    sqlCommand.Parameters.AddRange(parameters);
                    connection.Open();

                    return await sqlCommand.ExecuteNonQueryAsync();
                }
            }
        }
        public static Int32 ExecuteNonQuery(SqlConnection connection, string commandText
            , CommandType commandType, params SqlParameter[] parameters)
        {
            using (connection)
            {
                using (var cmd = new SqlCommand(commandText, connection))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    //  connection.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }


        public static SqlDataReader ExecuteReader(string commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(commandText, con))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    //con.Open();
                    return cmd.ExecuteReader();
                }
            }
        }

        public static Int32 crearClaseVehiculo(ClaseDeVehiculo claseDeVehiculo)
        {
            var query = "insert into CLASESVEHICULOS(DESCRIPCION)" + "VALUES(@DESCRIPCION)";

            var parameterDescripcion = new SqlParameter("@DESCRIPCION", claseDeVehiculo.Descripcion);

            var con = Conexion.GetConnection();

            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterDescripcion);
                return rows;

            }
        }

        public static ClaseDeVehiculo GetClaseDeVehiculo(int id)
        {
            var p = new ClaseDeVehiculo();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {

                    cmd.CommandText = "select * from CLASESVEHICULOS WHERE ID_CLASESVEH = @ID_CLASESVEH";
                    cmd.Parameters.AddWithValue("@ID_CLASESVEH", id);
                    cmd.CommandType = CommandType.Text;

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            p.Descripcion = reader["DESCRIPCION"].ToString();
                        }

                    }
                }
            }
            return p;
        }

        public static Int32 ActualizarClaseVehiculo(ClaseDeVehiculo claseDeVehiculo)
        {
            var sp = "sp_actualizar_claseDeVeh";
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(sp, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DESCRIPCION", claseDeVehiculo.Descripcion);

                    cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ID_CLASESVEH", claseDeVehiculo.ID);

                    var rs = Convert.ToInt32(cmd.ExecuteNonQuery());

                    if (rs > 0)
                    {
                        return rs;
                    }
                    else
                    {
                        return rs;
                    }
                }
            }
        }


    }
}
