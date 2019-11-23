using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Modelos;
using Models;


namespace Consultas
{
   public  class CCargo
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


        public static Int32 crearCargo(Cargo cargo)
        {

            var query = "insert into CARGOS (NOMBRE,DESCRIPCION)" + "VALUES(@NOMBRE,@DESCRIPCION)";

            var parameterNombre = new SqlParameter("@NOMBRE", cargo.Nombre);
            var parameterDescripcion = new SqlParameter("@DESCRIPCION", cargo.Descripcion);

            var con = Conexion.GetConnection();

            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterNombre, parameterDescripcion);
                return rows;
            }
        }

        public static Int32 ActualizarCargo(Cargo cargo)
        {
            var sp = "sp_actualizar_cargo";
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(sp, con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NOMBRE", cargo.Nombre);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", cargo.Descripcion);

                    cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ID_CARGO", cargo.ID);

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

        public static Int32 ActualizarCargos(Cargo cargo)
        {
            var query = "insert into CARGOS(NOMBRE,DESCRIPCION)" +
                  "VALUES (@NOMBRE,@DESCRIPCION)";

            var parameterNombre = new SqlParameter("@NOMBRE", cargo.Nombre);
            var parameterDescripcion = new SqlParameter("@DESCRIPCION", cargo.Descripcion);

            var con = Conexion.GetConnection();
            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterNombre
                    , parameterDescripcion);

                return rows;
            }

        }

        public static Cargo getCargoId(int id)
        {
            var cargo = new Cargo();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = "select * from CARGOS WHERE ID_CARGO = @ID_CARGO";
                    cmd.Parameters.AddWithValue("@ID_CARGO", id);
                    cmd.CommandType = CommandType.Text;

                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            cargo.Nombre = rs["NOMBRE"].ToString();
                            cargo.Descripcion = rs["DESCRIPCION"].ToString();

                        }
                    }
                    return cargo;
                }


            }
        }

    }
}
