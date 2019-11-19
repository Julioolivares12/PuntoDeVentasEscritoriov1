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
   public class CLogin
    {
        public static LoginModel login(string c , string p)
        {
            LoginModel login = new LoginModel();
            var pass = Encriptar.encriptarPassword(p);
            using (var con = Conexion.GetConnection())
            {
                using (var cmd = new SqlCommand(null, con))
                {
                    cmd.CommandText = $"Select u.ID_USUARIO,u.EMAIL, u.PRIMERNOMBRE,u.PRIMERAPELLIDO , p.NOMBRE as PERFIL from USUARIOS as u inner join PERFIL as p on u.ID_PERFIL=p.ID_PERFIL where u.EMAIL='{c}' and u.PASS='{pass}' ";
                    cmd.CommandType = CommandType.Text;
                    var rs = cmd.ExecuteReader();
                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            login.ID_USUARIO = rs["ID_USUARIO"].ToString();
                            login.Email = rs["EMAIL"].ToString();
                            login.PrimerApellido = rs["PRIMERAPELLIDO"].ToString();
                            login.PrimerNombre = rs["PRIMERNOMBRE"].ToString();
                            login.Perfil = rs["PERFIL"].ToString();
                        }
                    }
                }
            }
            return login;
        }
    }
}
