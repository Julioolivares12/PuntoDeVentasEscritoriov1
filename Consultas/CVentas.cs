using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Consultas
{
   public class CVentas
    {
        public static int  InsertarVenta(Venta venta)
        {
            using (var con = Conexion.GetConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO VENTAS"+
                                   "(ID_USUARIO"+
                                   ",ID_CLIENTE"+
                                   ",NRODOC"+
                                   ",ID_TIPODOC"+
                                   ",NRO_CF"+
                                   ",FECHAVENTA"+
                                   ",SUBTOTAL"+
                                   ",DESCUENTO"+
                                   ",IVA"+
                                   ",MONTOTOTAL)"+ "values"+
                                   "(@ID_USUARIO,"+
                                   "@ID_CLIENTE,"+
                                   
                                   "@NRODOC,"+
                                   "@ID_TIPODOC,"+
                                   "@NRO_CF,"+
                                   "@FECHAVENTA,"+
                                   "@SUBTOTAL,"+
                                   "@DESCUENTO,"+
                                   "@IVA,"+
                                   "@MONTOTOTAL) ; SELECT SCOPE_IDENTITY() AS id";

                                SqlParameter[] parameters = {
                                    new SqlParameter("@ID_USUARIO",venta.ID_USUARIO),
                                    new SqlParameter("@ID_CLIENTE",venta.ID_CLIENTE),
                                    
                                    new SqlParameter("@NRODOC",venta.NRODOC),
                                    new SqlParameter("@ID_TIPODOC",venta.ID_TIPODOC),
                                    new SqlParameter("@NRO_CF",venta.NRO_CF),
                                    new SqlParameter("@FECHAVENTA",venta.FECHAVENTA),
                                    new SqlParameter("@SUBTOTAL",venta.SUBTOTAL),
                                    new SqlParameter("@DESCUENTO",venta.DESCUENTO),
                                    new SqlParameter("@IVA",venta.IVA),
                                    new SqlParameter("@MONTOTOTAL",venta.MONTOTOTAL)
                                };


                cmd.Parameters.AddRange(parameters);
                cmd.CommandType = CommandType.Text;

                var id = Convert.ToInt32(cmd.ExecuteNonQuery());
                return id;
            }
        }
    }
}
