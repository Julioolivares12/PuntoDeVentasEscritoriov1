﻿using System;
using System.Collections.Generic;
using System.Text;


namespace ViewModels
{
   public class Conexion
    {
        private static string con = ConfigurationManager.ConnectionStrings["conexionSQL2"].ConnectionString;

        /// <summary>
        /// se conecta a la bd de forma sincrona
        /// </summary>
        /// <returns></returns>
        public static SqlConnection conectar()
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
