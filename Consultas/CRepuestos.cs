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
        private DataTable dataTable = new DataTable();
        
        public static DataTable getRepuestos()
        {
           
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand("SELECT * FROM REPUESTOS",con))
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
                cmd.Parameters.AddWithValue("@UPC",upc);
                var r = new Repuesto();
                var rs = cmd.ExecuteReader();
                if (rs.HasRows)
                {
                    while (rs.Read())
                    {
                        r.ID = Convert.ToInt32(rs["ID_REPUESTO"].ToString());
                        r.Nombe = rs["NOMBRE"].ToString();
                        r.Descripcion = rs["DESCRIPCION"].ToString();
                        r.PrecioCompra =Convert.ToDouble(rs["PRECIOCOMPRA"].ToString());
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
                using (var cmd = new SqlCommand(null,con))
                {
                    cmd.CommandText = "select * from REPUESTOS where ID_REPUESTO = @ID_REPUESTO";
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID_REPUESTO", id);
                    var rs = cmd.ExecuteReader();

                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            repuesto.ID = Convert.ToInt32(rs["ID_REPUESTO"].ToString());
                            repuesto.Nombe = rs["NOMBRE"].ToString();
                            repuesto.Descripcion = rs["DESCRIPCION"].ToString();
                            repuesto.PrecioCompra = Convert.ToInt32(rs["PRECIOCOMPRA"].ToString());
                            repuesto.PrecioVenta = Convert.ToDouble(rs["PRECIOVENTA"].ToString());
                            repuesto.Descuento = Convert.ToDouble(rs["DESCUENTO"].ToString());
                            repuesto.UPC = rs["UPC"].ToString();
                            repuesto.Cantidad = Convert.ToInt32(rs["cantidad"].ToString());
                        }
                    }
                    return repuesto;
                }
            }
        }
    }
}
