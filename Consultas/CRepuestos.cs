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
   public class CRepuestos
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

        public static Int32 crearRepuestos(Repuesto repuesto)
        {
            var query = "insert into REPUESTOS(ID_PARTEVEH, ID_MARCAVEH, NOMBRE," +
                    "DESCRIPCION,PRECIOCOMPRA,PRECIOVENTA, DESCUENTO,NUM_MOTOR,NUM_CHASIS,NUM_VIN,UPC,cantidad)"
                    + "VALUES(@ID_PARTEVEH, @ID_MARCAVEH, @NOMBRE, @DESCRIPCION, @PRECIOCOMPRA," +
                    "@PRECIOVENTA, @DESCUENTO, @NUM_MOTOR, @NUM_CHASIS, @NUM_VIN, @UPC, @cantidad)";

            var parameteridParteVeh = new SqlParameter("@ID_PARTEVEH", repuesto.ID_PARTEVEH);
            var parameteridPMarcaVeh = new SqlParameter("@ID_MARCAVEH", repuesto.ID_MARCAVEH);
            var parameterNombre = new SqlParameter("@NOMBRE", repuesto.Nombre);
            var parameteriDescrip = new SqlParameter("@DESCRIPCION", repuesto.Descripcion);
            var parameterPrecioComp = new SqlParameter("@PRECIOCOMPRA", repuesto.PrecioCompra);
            var parameterPrecioVent = new SqlParameter("@PRECIOVENTA", repuesto.PrecioVenta);
            var parameteriDescu = new SqlParameter("@DESCUENTO", repuesto.Descuento);
            var parameteriNumMotor = new SqlParameter("@NUM_MOTOR", repuesto.NumMotor);
            var parameterNumChasis = new SqlParameter("@NUM_CHASIS", repuesto.NumChasis);
            var parameterNumVin = new SqlParameter("@NUM_VIN", repuesto.NumVin);
            var parameteriUpc = new SqlParameter("@UPC", repuesto.UPC);
            var parameteriCantidad = new SqlParameter("@cantidad", repuesto.Cantidad);


            var con = Conexion.GetConnection();

            using (con)
            {
                var rows = ExecuteNonQuery(con, query, CommandType.Text, parameteridParteVeh, parameteridPMarcaVeh, parameterNombre
                    , parameteriDescrip, parameterPrecioComp, parameterPrecioVent, parameteriDescu, parameteriNumMotor, parameterNumChasis
                    , parameterNumVin, parameteriUpc, parameteriCantidad);
                return rows;

            }
        }
        public static DataTable getModeloVeh()
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_MODELOVEH,DESCRIPCION FROM MODELOSVEHICULOS", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable getParteVeh()
        {
            using (var con = Conexion.GetConnection())
            {
                using (var adapter = new SqlDataAdapter("SELECT ID_PARTEVEH,DESCRIPCION FROM PARTESVEHICULOS", con))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }


        private DataTable dataTable = new DataTable();

        public static DataTable getRepuestos()
        {

            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand("SELECT * FROM REPUESTOS", con))
                {
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteReader();
                    var dataTable = new DataTable();
                    dataTable.Load(rs);


                    return dataTable;
                }
            }

        }

        public static Repuesto GetRepuestoByUPC(string upc)
        {
            using (var con = Conexion.GetConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM REPUESTOS WHERE UPC = @UPC";
                cmd.Parameters.AddWithValue("@UPC", upc);

                var r = new Repuesto();
                var rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        r.ID = Convert.ToInt32(rs["ID_REPUESTO"].ToString());
                        r.Nombre = rs["NOMBRE"].ToString();
                        r.Descripcion = rs["DESCRIPCION"].ToString();
                        r.PrecioCompra = Convert.ToDouble(rs["PRECIOCOMPRA"].ToString());
                        r.PrecioVenta = Convert.ToDouble(rs["PRECIOVENTA"].ToString());
                        r.UPC = rs["UPC"].ToString();
                        r.Cantidad = Convert.ToInt32(rs["cantidad"].ToString());

                    }

                }
                return r;
            }
        }

        public static Repuesto GetRepuestoByID(int id)
        {
            var repuesto = new Repuesto();
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = "select * from REPUESTOS where ID_REPUESTO = @ID_REPUESTO";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_REPUESTO", id);

                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            repuesto.Nombre = rs["NOMBRE"].ToString();
                            repuesto.Descripcion = rs["DESCRIPCION"].ToString();
                            repuesto.PrecioCompra = Convert.ToDouble(rs["PRECIOCOMPRA"].ToString());
                            repuesto.PrecioVenta = Convert.ToDouble(rs["PRECIOVENTA"].ToString());
                            repuesto.Descuento = Convert.ToDouble(rs["DESCUENTO"].ToString());
                            repuesto.NumMotor = (rs["NUM_MOTOR"].ToString());
                            repuesto.NumChasis = (rs["NUM_CHASIS"].ToString());
                            repuesto.NumVin = (rs["NUM_VIN"].ToString());
                            repuesto.UPC = rs["UPC"].ToString();
                            repuesto.Cantidad = Convert.ToInt32(rs["cantidad"].ToString());
                        }
                    }
                    return repuesto;
                }
            }
        }

        public static Int32 ActualizarRepuestos(Repuesto repuesto)
        {
            var sp = "sp_actualizar_repuestos";
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(sp, con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_PARTEVEH", repuesto.ID_PARTEVEH);
                    cmd.Parameters.AddWithValue("@ID_MARCAVEH", repuesto.ID_MARCAVEH);
                    cmd.Parameters.AddWithValue("@NOMBRE", repuesto.Nombre);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", repuesto.Descripcion);
                    cmd.Parameters.AddWithValue("@PRECIOCOMPRA", repuesto.PrecioCompra);
                    cmd.Parameters.AddWithValue("@PRECIOVENTA", repuesto.PrecioVenta);
                    cmd.Parameters.AddWithValue("@DESCUENTO", repuesto.Descuento);
                    cmd.Parameters.AddWithValue("@NUM_MOTOR", repuesto.NumMotor);
                    cmd.Parameters.AddWithValue("@NUM_CHASIS", repuesto.NumChasis);
                    cmd.Parameters.AddWithValue("@NUM_VIN", repuesto.NumVin);
                    cmd.Parameters.AddWithValue("@UPC", repuesto.UPC);
                    cmd.Parameters.AddWithValue("@cantidad", repuesto.Cantidad);


                    cmd.Parameters.AddWithValue("@numFilasAfectadas", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ID_REPUESTO", repuesto.ID);
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
    }
}
