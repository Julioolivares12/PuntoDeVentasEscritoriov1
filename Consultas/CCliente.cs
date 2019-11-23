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

        public static Int32 crearCliente(Cliente cliente)
        {
            var query = "insert into CLIENTES(PRIMERNOMBRE, PRIMERAPELLIDO, FECHANAC,SEXO,ESTADO_CIVIL, LUGARTRABAJO, DUI," +
                "NIT, TELEF_CASA, CELULAR, DIREC_CASA, TELE_TRABAJO)"
                + "VALUES(@PRIMERNOMBRE,@PRIMERAPELLIDO,CONVERT(DATETIME,@FECHANAC),@SEXO,@ESTADO_CIVIL,@LUGARTRABAJO,@DUI, @NIT," +
                "@TELEF_CASA, @CELULAR, @DIREC_CASA,@TELE_TRABAJO)";

            var parameterPrimerNombre = new SqlParameter("@PRIMERNOMBRE", cliente.PrimerNombre);
            var parameterPrimerApellido = new SqlParameter("@PRIMERAPELLIDO", cliente.PrimerApellido);
            var parameterFechaNac = new SqlParameter("@FECHANAC", cliente.FechaNac);
            var parameterSexo = new SqlParameter("@SEXO", cliente.Sexo);
            var parameterEstado = new SqlParameter("@ESTADO_CIVIL", cliente.EstadoCivil);
            var parameterLugarTrabajo = new SqlParameter("@LUGARTRABAJO", cliente.LUGARTRABAJO);
            var parameterdui = new SqlParameter("@DUI", cliente.DUI);
            var parameteNit = new SqlParameter("@NIT", cliente.NIT);
            var parameteTeCasa = new SqlParameter("@TELEF_CASA", cliente.TEL_CASA);
            var parameteCelu = new SqlParameter("@CELULAR", cliente.CELULAR);
            var parameteTDirecasa = new SqlParameter("@DIREC_CASA", cliente.DIRECCIONCASA);
            var parameteTelTraba = new SqlParameter("@TELE_TRABAJO", cliente.TEL_TRABAJO);


            var con = Conexion.GetConnection();
            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameterPrimerNombre, parameterPrimerApellido,
                   parameterFechaNac, parameterSexo, parameterEstado, parameterLugarTrabajo, parameterdui,
                 parameteNit, parameteTeCasa, parameteCelu, parameteTDirecasa, parameteTelTraba);

                return rows;
            }

        }


        public static Cliente GetClienteByID(string id)
        {
            Cliente cliente = new Cliente();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = "SELECT ID_CLIENTE, PRIMERNOMBRE,SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO , SEXO,ESTADO_CIVIL FROM CLIENTES WHERE ID_CLIENTE = @ID_CLIENTE";
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", id);
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {

                            cliente.PrimerNombre = rs["PRIMERNOMBRE"].ToString();
                            cliente.PrimerApellido = rs["PRIMERAPELLIDO"].ToString();
                            cliente.Sexo = Convert.ToChar(rs["SEXO"].ToString());
                            cliente.EstadoCivil = Convert.ToChar(rs["ESTADO_CIVIL"].ToString());
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
                using (var adapter = new SqlDataAdapter("SELECT ID_CLIENTE as id , PRIMERNOMBRE +' '+PRIMERAPELLIDO as cliente FROM CLIENTES", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static Int32 ActualizarCliente(Cliente cliente)
        {
            var sp = "sp_actualizar_cliente";
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(sp, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PRIMERNOMBRE", cliente.PrimerNombre);
                    cmd.Parameters.AddWithValue("@PRIMERAPELLIDO", cliente.PrimerApellido);
                    cmd.Parameters.AddWithValue("@FECHANAC", cliente.FechaNac);
                    cmd.Parameters.AddWithValue("@SEXO", cliente.Sexo);
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", cliente.EstadoCivil);
                    cmd.Parameters.AddWithValue("@LUGARTRABAJO", cliente.LUGARTRABAJO);
                    cmd.Parameters.AddWithValue("@DUI", cliente.DUI);
                    cmd.Parameters.AddWithValue("@NIT", cliente.NIT);
                    cmd.Parameters.AddWithValue("@TELEF_CASA", cliente.TEL_CASA);
                    cmd.Parameters.AddWithValue("@CELULAR", cliente.CELULAR);
                    cmd.Parameters.AddWithValue("@DIREC_CASA", cliente.DIRECCIONCASA);
                    cmd.Parameters.AddWithValue("@TELE_TRABAJO", cliente.TEL_TRABAJO);


                    //este parametro es para poder utilizar parametros de tipo output
                    cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", cliente.ID);
                    //var rs = Convert.ToInt32(cmd.Parameters["@numFilasAfectadas"].Value);//aqui le asigno el resultado del store procedure
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

        public static Cliente getClienteId(int id)
        {
            var cliente = new Cliente();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = "select * from CLIENTES WHERE ID_CLIENTE = @ID_CLIENTE";
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", id);
                    cmd.CommandType = CommandType.Text;

                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            cliente.PrimerNombre = rs["PRIMERNOMBRE"].ToString();
                            cliente.PrimerApellido = rs["PRIMERAPELLIDO"].ToString();
                            cliente.FechaNac = rs["FECHANAC"].ToString();
                            cliente.Sexo = Convert.ToChar(rs["SEXO"].ToString());
                            cliente.EstadoCivil = Convert.ToChar(rs["ESTADO_CIVIL"].ToString());
                            cliente.LUGARTRABAJO = (rs["LUGARTRABAJO"].ToString());
                            cliente.DUI = (rs["DUI"].ToString());
                            cliente.NIT = rs["NIT"].ToString();
                            cliente.TEL_CASA = rs["TELEF_CASA"].ToString();
                            cliente.CELULAR = rs["CELULAR"].ToString();
                            cliente.DIRECCIONCASA = rs["DIREC_CASA"].ToString();
                            cliente.TEL_TRABAJO = rs["TELE_TRABAJO"].ToString();
                        }
                    }

                    return cliente;

                }
            }
        }

    }
}
