using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using ENTITIES;

namespace BOL
{
    public class Empresa
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarEmpresa()
        {
            DataTable empresa = new DataTable();
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("", acceso.getConexion());
            adapter.Fill(empresa);
            acceso.desconectar();
            return empresa;
        }

        public void registrarEmpresa(string razonSocial, char ruc, string direccion, char telefono, string email)
        {
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            command.Parameters.AddWithValue("", razonSocial);
            command.Parameters.AddWithValue("", ruc);
            command.Parameters.AddWithValue("", direccion);
            command.Parameters.AddWithValue("", telefono);
            command.Parameters.AddWithValue("", email);
            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public void editarEmpresa(int idempresa, string razonSocial, string ruc, string direccion, char telefono, string email)
        {
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            command.Parameters.AddWithValue("", idempresa);
            command.Parameters.AddWithValue("", razonSocial);
            command.Parameters.AddWithValue("", ruc);
            command.Parameters.AddWithValue("", direccion);
            command.Parameters.AddWithValue("", telefono);
            command.Parameters.AddWithValue("", email);

            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public DataTable buscarEmpresa(string ruc)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("", ruc);
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            acceso.desconectar();
            return table;
        }
        public int eliminarEmpresa(int idempresa)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("", idempresa);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int activarEmpresa(int idempresa)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("", idempresa);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
            }
            catch
            {
                filasAfectadas = -1;
            }
            return filasAfectadas;
        }

    }
}
