using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using DAL;
using ENTITIES;

namespace BOL
{
    public class Persona
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarPersonas()
        {
            DataTable persona = new DataTable();

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("", acceso.getConexion());
            adapter.Fill(persona);
            acceso.desconectar();

            return persona;
        }

        public void registrarPersona(string apellidos, string nombres, string dni, string direccion, char telefono, string email)
        {
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            
            acceso.conectar();
            command.Parameters.AddWithValue("", apellidos);
            command.Parameters.AddWithValue("", nombres);
            command.Parameters.AddWithValue("", dni);
            command.Parameters.AddWithValue("", direccion);
            command.Parameters.AddWithValue("", telefono);
            command.Parameters.AddWithValue("", email);

            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public void editarPersona(int idpersona, string apellidos, string nombres, string dni, string direccion, char telefono, string email)
        {
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            command.Parameters.AddWithValue("", idpersona);
            command.Parameters.AddWithValue("", apellidos);
            command.Parameters.AddWithValue("", nombres);
            command.Parameters.AddWithValue("", dni);
            command.Parameters.AddWithValue("", direccion);
            command.Parameters.AddWithValue("", telefono);
            command.Parameters.AddWithValue("", email);

            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public DataTable buscarPersona(string dni)
        {
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("", dni);
            acceso.conectar();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(table);

            acceso.desconectar();
            return table;
        }

        public int eliminarPersona(int idpersona)
        {
            int filasAfectadas = 0;

            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("", idpersona);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int activarPersona(int idpersona)
        {
            int filasAfectadas = 0;

            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("", idpersona);
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
