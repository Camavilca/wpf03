using _03.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace _03
{
    internal class Datos
    {
        public SqlConnection LeerCadena()
        {
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-HEC4IM4\\SQLEXPRESS;" +
                "Initial Catalog=Neptuno;Integrated Security=true");
            return connection;
        }

        public Boolean existUser(Usuario usu)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlCommand cmd = new SqlCommand("UpsUsuario");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@username", usu.Username);
            cmd.Parameters.AddWithValue("@password", usu.Password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable ListarClientes()
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("UspListaClientes", connection);
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public List<Pais> ListarPaises()
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            List<Pais> paises = new List<Pais>();
            Pais pais;
            SqlDataReader reader;

            try
            {
                SqlCommand cmd = new SqlCommand("UspListaClientes");
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pais = new Pais();
                    pais.Nombre = (string)(reader[8]);
                    paises.Add(pais);
                }

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }

            connection.Close();
            return paises;

        }

        public List<Proveedor> ListarProveedores()
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            List<Proveedor> proveedores = new List<Proveedor>();
            Proveedor proveedor;
            SqlDataReader reader;

            try
            {
                SqlCommand cmd = new SqlCommand("UpsListProveedores");
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    proveedor = new Proveedor();
                    proveedor.Codigo = (int)(reader[0]);
                    proveedor.Nombre = (string)(reader[2]);
                    proveedor.Pais = (string)(reader[8]);
                    proveedor.Ciudad = (string)(reader[5]);
                    proveedor.Direccion = (string)(reader[4]);
                    proveedores.Add(proveedor);
                }

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }

            connection.Close();
            return proveedores;

        }

        public List<Empleado> ListarEmpleado()
        {
            SqlConnection connection = LeerCadena();
            connection.Open();

            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado;
            SqlDataReader reader;

            try
            {
                SqlCommand cmd = new SqlCommand("UspListaEmpleados");
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empleado = new Empleado();
                    empleado.IdEmpleado = (int)(reader[0]);
                    empleado.Apellido = (string)(reader[1]);
                    empleado.Nombre = (string)(reader[2]);
                    empleado.Nacimiento = (DateTime)(reader[3]);
                    empleado.Direccion = (string)(reader[4]);
                    empleados.Add(empleado);
                }

            }
            catch (Exception ex)
            {

                System.Console.Write(ex.Message);
            }

            connection.Close();
            return empleados;


        }

        public List<Pedido> ListarPedidoFecha()
        {

            SqlConnection connection = LeerCadena();
            connection.Open();

            List<Pedido> pedidos = new List<Pedido>();
            Pedido pedido;
            SqlDataReader reader;

            try
            {
                SqlCommand cmd = new SqlCommand("USP_ListarPedidosAnio");
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pedido = new Pedido();
                    pedido.Anio = (string)(reader[0]);
                    pedidos.Add(pedido);
                }

            }
            catch (Exception ex)
            {

                System.Console.Write(ex.Message);
            }

            connection.Close();
            return pedidos;

        }

        public List<Pedido> ListarPedidoFecha(string x)
        {

            SqlConnection connection = LeerCadena();
            connection.Open();

            List<Pedido> pedidos = new List<Pedido>();
            Pedido pedido;
            SqlDataReader reader;

            try
            {
                SqlCommand cmd = new SqlCommand("USP_ListarPedidosMes");
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Anio", x);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pedido = new Pedido();
                    pedido.Mes = (string)(reader[0]);
                    pedidos.Add(pedido);
                }

            }
            catch (Exception ex)
            {

                System.Console.Write(ex.Message);
            }

            connection.Close();
            return pedidos;

        }

        public List<Empleado> ListarEmpleados(string mm, string yyyy)
        {
            SqlConnection connection = LeerCadena();
            connection.Open();
            List<Empleado> empleados = new List<Empleado>();
            Empleado empleado;
            SqlDataReader reader;

            try
            {
                SqlCommand cmd = new SqlCommand("USP_ListarEmpleados");
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Mes", mm);
                cmd.Parameters.AddWithValue("@Anio", yyyy);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    empleado = new Empleado();
                    empleado.IdEmpleado = (int)(reader[0]);
                    empleado.Apellidos = (string)(reader[1]);
                    empleado.Nombre = (string)(reader[2]);
                    empleado.Cargo = (string)(reader[3]);

                    empleados.Add(empleado);

                }

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }

            connection.Close();
            return empleados;

        }
    }
}
