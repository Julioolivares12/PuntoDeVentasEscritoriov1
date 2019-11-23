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
    public class CPerfiles
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


            public static Int32 crearPerfil(Perfiles perfiles)
            {

                var query = "insert into PERFIL (NOMBRE,DESCRIPCION)" + "VALUES(@NOMBRE,@DESCRIPCION)";

                var parameterNombre = new SqlParameter("@NOMBRE", perfiles.Nombre);
                var parameterDescripcion = new SqlParameter("@DESCRIPCION", perfiles.Descripcion);

                var con = Conexion.GetConnection();

                using (con)
                {
                    var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterNombre, parameterDescripcion);
                    return rows;
                }
            }

            public static Int32 ActualizarPerfil(Perfiles perfiles)
            {
                var sp = "sp_actualizar_perfil";
                using (var con = Conexion.GetConnection())
                {
                    using (var cmd = new SqlCommand(sp, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NOMBRE", perfiles.Nombre);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", perfiles.Descripcion);
                        cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.AddWithValue("@ID_PERFIL", perfiles.ID);

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

            public static Int32 ActualizarPerfiles(Perfiles perfil)
            {
                var query = "insert into PERFIL(NOMBRE,DESCRIPCION)" +
                    "VALUES (@NOMBRE,@DESCRIPCION)";

                var parameterNombre = new SqlParameter("@NOMBRE", perfil.Nombre);
                var parameterDescripcion = new SqlParameter("@DESCRIPCION", perfil.Descripcion);

                var con = Conexion.GetConnection();
                using (con)
                {
                    var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterNombre
                        , parameterDescripcion);

                    return rows;
                }
            }

            public static Perfiles getPerfilId(int id)
            {
                var perfil = new Perfiles();
                using (var con = Conexion.GetConnection())
                {
                    using (var cmd = new SqlCommand(null, con))
                    {
                        cmd.CommandText = "select * from PERFIL WHERE ID_PERFIL = @ID_PERFIL";
                        cmd.Parameters.AddWithValue("@ID_PERFIL", id);
                        cmd.CommandType = CommandType.Text;

                        var rs = cmd.ExecuteReader();
                        if (rs.HasRows)
                        {
                            while (rs.Read())
                            {
                                perfil.Nombre = rs["NOMBRE"].ToString();
                                perfil.Descripcion = rs["DESCRIPCION"].ToString();

                            }
                        }
                        return perfil;
                    }
                }
            }
    }
    
}
