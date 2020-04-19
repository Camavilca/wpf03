using System;
using System.Data;
using System.Data.SqlClient;

namespace _03
{
    internal class ClsDatos
    {
        public SqlConnection Conexion()
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-HEC4IM4\\SQLEXPRESS;" +
                "Initial Catalog=Neptuno;Integrated Security=true");
            return connection;
        }

        public DataTable ListaPedidosFechas(DateTime x, DateTime y)
        {
            SqlConnection connection = Conexion();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("USP_ListarPedidosEntreFechas", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@FEC1", x);
            sqlData.SelectCommand.Parameters.AddWithValue("@FEC2", y);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public DataTable ListarDetalle(int x)
        {
            SqlConnection connection = Conexion();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("USP_ListarDetalle", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@IdPedido", x);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public double PedidoTotal(Int32 idPedido)
        {
            SqlConnection connection = Conexion();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("usp_Total", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@IdPedido", idPedido);
            sqlData.SelectCommand.Parameters.Add("@Total", SqlDbType.Money).Direction = ParameterDirection.Output;
            sqlData.SelectCommand.ExecuteScalar();
            Int32 total = Convert.ToInt32(sqlData.SelectCommand.Parameters["@Total"].Value);
            DataTable dataTable = new DataTable();
            connection.Close();
            return total;
        }

    }
}