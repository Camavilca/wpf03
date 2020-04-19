using System;
using System.Data;
using System.Data.SqlClient;

namespace _03
{
    internal class DB
    {
        public SqlConnection Conexion()
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-HEC4IM4\\SQLEXPRESS;" +
                "Initial Catalog=Neptuno;Integrated Security=true");
            return connection;
        }
    }
}