using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BOL
{
    public class Rol
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarRoles()
        {
            DataTable rol = new DataTable();

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("", acceso.getConexion());
            adapter.Fill(rol);
            
            acceso.desconectar();
            return rol;
        }

        public int registrarRol(string nombrerol)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("", nombrerol);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public void editarRol(int idrol, string nombrerol)
        {
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            acceso.conectar();
            command.Parameters.AddWithValue("", idrol);
            command.Parameters.AddWithValue("", nombrerol);
            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public DataTable buscarRol(int idrol)
        {
            DataTable buscar = new DataTable();
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("", idrol);
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(buscar);
            acceso.desconectar();
            return buscar;
        }

    }
}
