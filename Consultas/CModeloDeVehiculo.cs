using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace Consultas
{
    public class CModeloDeVehiculo
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

        public static Int32 crearModeloVehiculo(ModeloVehiculo modeloVehiculo)
        {
            var query = "insert into MODELOSVEHICULOS(DESCRIPCION)" + "VALUES(@DESCRIPCION)";

            var parameterDescripcion = new SqlParameter("@DESCRIPCION", modeloVehiculo.DESCRIPCION);

            var con = Conexion.GetConnection();

            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterDescripcion);
                return rows;

            }
        }

        public static Int32 ActualizarModeloVeh(ModeloVehiculo modeloVehiculo)
        {
            var sp = "sp_actualizar_modeloVeh";
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(sp, con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DESCRIPCION", modeloVehiculo.DESCRIPCION);

                    cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ID_MODELOVEH", modeloVehiculo.ID);

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


        public static ModeloVehiculo getModeloId(int id)
        {
            var modeloV = new ModeloVehiculo();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = "select * from MODELOSVEHICULOS WHERE ID_MODELOVEH = @ID_MODELOVEH";
                    cmd.Parameters.AddWithValue("@ID_MODELOVEH", id);
                    cmd.CommandType = CommandType.Text;

                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            modeloV.DESCRIPCION = rs["DESCRIPCION"].ToString();

                        }
                    }
                    return modeloV;
                }


            }
        }

    }
}
