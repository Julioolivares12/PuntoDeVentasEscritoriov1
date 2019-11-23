using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace Consultas
{
    public class CParteVehiculo
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

        public static Int32 crearParteVehiculo(ParteDeVehiculo parteDeVehiculo)
        {
            var query = "insert into PARTESVEHICULOS (DESCRIPCION)" + "VALUES(@DESCRIPCION)";

            var parameterDescripcion = new SqlParameter("@DESCRIPCION", parteDeVehiculo.DESCRIPCION);

            var con = Conexion.GetConnection();

            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterDescripcion);
                return rows;

            }
        }
        public static DataTable getParteDeVehiculo()
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter("select * from PARTESVEHICULOS ", con))
                {
                    var dt = new DataTable();

                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        public static Int32 ActualizarParte(ParteDeVehiculo parteDeVehiculo)
        {
            var sp = "sp_actualizar_parte";
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(sp, con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DESCRIPCION", parteDeVehiculo.DESCRIPCION);

                    cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ID_PARTEVEH", parteDeVehiculo.ID);

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



        public static ParteDeVehiculo getParteId(int id)
        {
            var parte = new ParteDeVehiculo();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = "select * from PARTESVEHICULOS WHERE ID_PARTEVEH = @ID_PARTEVEH";
                    cmd.Parameters.AddWithValue("@ID_PARTEVEH", id);
                    cmd.CommandType = CommandType.Text;

                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            parte.DESCRIPCION = rs["DESCRIPCION"].ToString();

                        }
                    }
                    return parte;
                }


            }
        }

    }
}
