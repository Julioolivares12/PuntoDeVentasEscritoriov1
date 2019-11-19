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
    public class CEmpleado
    {
        /// <param name="connection">objeto de la clase SqlConnection que devuelve la conexion con la bd</param>
        /// <param name="commandText"></param>
        /// <param name="commandType">hay tres tipos de comando StoreProcedure,Text,TableDirect tableDirect es solo para OLE DB </param>
        /// <param name="parameters">parametros de sql</param>
        /// <returns>retorna la cantidad de filas afectadas</returns>
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
        /// metodo para insertar empleados en la bd
        /// </summary>
        /// <param name="idPerfil"></param>
        /// <param name="idCargo"></param>
        /// <param name="primerNombre"></param>
        /// <param name="segundoNombre"></param>
        /// <param name="primerApellido"></param>
        /// <param name="segundoApellido"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="fechaNac"></param>
        /// <param name="sexo"></param>
        /// <param name="estado"></param>
        /// <param name="email"></param>
        /// <returns>retorna la cantidad de filas afectadas</returns>
        public static Int32 crearEpleadoAsync(Usuario usuario)
        {
            var query = "insert into USUARIOS (ID_CARGO,ID_PERFIL,PRIMERNOMBRE," +
                "PRIMERAPELLIDO,DIRECCION,TELEFONO,FECHANAC,SEXO,ESTADO_CIVIL,EMAIL,PASS)" +
                " VALUES (@ID_CARGO,@ID_PERFIL,@PRIMERNOMBRE,@PRIMERAPELLIDO,@DIRECCION,@TELEFONO,CONVERT(DATETIME,@FECHANAC),@SEXO,@ESTADO_CIVIL,@EMAIL,@PASS)";

            //parametros para la insercion de datos
            //se hacen las letras en minusculas
            var pass = usuario.PrimerNombre.ToLower() + usuario.PrimerApellido.ToLower() + "123";
            var passE = Encriptar.encriptarPassword(pass);
            var ID_USER = Guid.NewGuid().ToString();

            var parameteridCargo = new SqlParameter("@ID_CARGO", usuario.ID_CARGO);
            var parameteridPerfil = new SqlParameter("@ID_PERFIL", usuario.ID_PERFIL);
            var parameterPrimerNombre = new SqlParameter("@PRIMERNOMBRE", usuario.PrimerNombre);
            var parameterPrimerApellido = new SqlParameter("@PRIMERAPELLIDO", usuario.PrimerApellido);
            var parameterDireccion = new SqlParameter("@DIRECCION", usuario.Direccion);
            var parameterTelefono = new SqlParameter("@TELEFONO", usuario.Telefono);
            var parameterFechaNac = new SqlParameter("@FECHANAC", usuario.FechaNac);
            var parameterSexo = new SqlParameter("@SEXO", usuario.Sexo);
            var parameterEstado = new SqlParameter("@ESTADO_CIVIL", usuario.EstadoCivil);
            var parameterEmail = new SqlParameter("@EMAIL", usuario.Email);
            var parameterPass = new SqlParameter("@PASS", passE);


            var con = Conexion.GetConnection();
            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameteridCargo
                    , parameteridPerfil, parameterPrimerNombre, parameterPrimerApellido
                    , parameterDireccion, parameterTelefono, parameterFechaNac, parameterSexo, parameterEstado, parameterEmail, parameterPass);

                return rows;
            }

        }



        public static DataTable getCargos()
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_CARGO,NOMBRE FROM CARGOS", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable getPerfiles()
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_PERFIL,NOMBRE FROM PERFIL", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable getEmpleados()
        {
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand("SELECT * FROM USUARIOS", con))
                {
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public static SqlDataReader getEmpleadoByID(string query, int id)
        {
            using (var con = Conexion.GetConnection())
            {

                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_USUARIO", id);
                    return cmd.ExecuteReader();
                }
            }
        }

        //crear empleado
        public static Int32 ActualizarUsuario(Usuario usuario)
        {

            var sp = "sp_actualizar_usuario";
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(sp, con))
                {


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_CARGO", usuario.ID_CARGO);
                    cmd.Parameters.AddWithValue("@ID_PERFIL", usuario.ID_PERFIL);
                    cmd.Parameters.AddWithValue("@PRIMERNOMBRE", usuario.PrimerNombre);
                    cmd.Parameters.AddWithValue("@PRIMERAPELLIDO", usuario.PrimerApellido);
                    cmd.Parameters.AddWithValue("@DIRECCION", usuario.Direccion);
                    cmd.Parameters.AddWithValue("@TELEFONO", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@FECHANAC", usuario.FechaNac);
                    cmd.Parameters.AddWithValue("@SEXO", usuario.Sexo);
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", usuario.EstadoCivil);
                    cmd.Parameters.AddWithValue("@EMAIL", usuario.Email);
                    //este parametro es para poder utilizar parametros de tipo output
                    cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ID_USUARIO", usuario.ID);
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
        public static Int32 ActualizarEmpleado(Usuario usuario)
        {
            var query = "insert into USUARIOS (ID_USUARIO,ID_CARGO,ID_PERFIL,PRIMERNOMBRE," +
                "SEGUNDONOMBRE,PRIMERAPELLIDO,SEGUNDOAPELLIDO,DIRECCION,TELEFONO,FECHANAC,SEXO,ESTADO_CIVIL,EMAIL,PASS)" +
                " VALUES (@ID_CARGO,@ID_PERFIL,@PRIMERNOMBRE,@PRIMERAPELLIDO,@DIRECCION,@TELEFONO,CONVERT(DATETIME,@FECHANAC),@SEXO,@ESTADO_CIVIL,@EMAIL,@PASS)";

            //parametros para la insercion de datos
            //se hacen las letras en minusculas
            var pass = usuario.PrimerNombre.ToLower() + usuario.PrimerApellido.ToLower() + "123";
            var passE = Encriptar.encriptarPassword(pass);
            var ID_USER = Guid.NewGuid().ToString();
            var parameteridCargo = new SqlParameter("@ID_CARGO", usuario.ID_CARGO);
            var parameteridPerfil = new SqlParameter("@ID_PERFIL", usuario.ID_PERFIL);
            var parameterPrimerNombre = new SqlParameter("@PRIMERNOMBRE", usuario.PrimerNombre);
            var parameterPrimerApellido = new SqlParameter("@PRIMERAPELLIDO", usuario.PrimerApellido);
            var parameterDireccion = new SqlParameter("@DIRECCION", usuario.Direccion);
            var parameterTelefono = new SqlParameter("@TELEFONO", usuario.Telefono);
            var parameterFechaNac = new SqlParameter("@FECHANAC", usuario.FechaNac);
            var parameterSexo = new SqlParameter("@SEXO", usuario.Sexo);
            var parameterEstado = new SqlParameter("@ESTADO_CIVIL", usuario.EstadoCivil);
            var parameterEmail = new SqlParameter("@EMAIL", usuario.Email);
            var parameterPass = new SqlParameter("@PASS", passE);


            var con = Conexion.GetConnection();
            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameteridCargo
                    , parameteridPerfil, parameterPrimerNombre, parameterPrimerApellido
                    , parameterDireccion, parameterTelefono, parameterFechaNac, parameterSexo, parameterEstado, parameterEmail, parameterPass);

                return rows;
            }

        }

        public static Usuario getUsuarioId(int id)
        {
            var usuario = new Usuario();

            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = "select * from USUARIOS WHERE ID_USUARIO = @ID_USUARIO";
                    cmd.Parameters.AddWithValue("@ID_USUARIO", id);
                    cmd.CommandType = CommandType.Text;

                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            usuario.PrimerNombre = rs["PRIMERNOMBRE"].ToString();
                            usuario.PrimerApellido = rs["PRIMERAPELLIDO"].ToString();
                            usuario.Direccion = rs["DIRECCION"].ToString();
                            usuario.Telefono = rs["TELEFONO"].ToString();
                            usuario.FechaNac = rs["FECHANAC"].ToString();
                            usuario.Sexo = Convert.ToChar(rs["SEXO"].ToString());
                            usuario.EstadoCivil = Convert.ToChar(rs["ESTADO_CIVIL"].ToString());
                            usuario.Email = rs["EMAIL"].ToString();

                        }
                    }
                    return usuario;
                }

            }

        }
    }
}
