using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using DAL;

namespace BOL
{
    public class Usuario
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarUsuarios()
        {
            DataTable usuario = new DataTable();
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("", acceso.getConexion());
            adapter.Fill(usuario);
            acceso.desconectar();
            return usuario;
        }

        public void registrarUsuario(int idpersona, int idrol, string nombreusuario, string claveacceso, DateTime fechabaja)
        {
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            command.Parameters.AddWithValue("", idpersona);
            command.Parameters.AddWithValue("", idrol);
            command.Parameters.AddWithValue("", nombreusuario);
            command.Parameters.AddWithValue("", claveacceso);
            command.Parameters.AddWithValue("", fechabaja);
            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public void editarUsuario(int idusuario, int idpersona, int idrol, string nombreusuario, string claveacceso, DateTime fechabaja)
        {
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            command.Parameters.AddWithValue("", idusuario);
            command.Parameters.AddWithValue("", idpersona);
            command.Parameters.AddWithValue("", idrol);
            command.Parameters.AddWithValue("", nombreusuario);
            command.Parameters.AddWithValue("", claveacceso);
            command.Parameters.AddWithValue("", fechabaja);
            command.ExecuteNonQuery();
            acceso.desconectar();
        }

        public DataTable buscarUsuario(int idusua)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("", idusua);
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            acceso.desconectar();
            return table;
        }

        public int eliminarUsuario(int idusuario)
        {
            int filasAfectadas = 0;

            try
            {
                SqlCommand command = new SqlCommand("", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;
                acceso.conectar();

                command.Parameters.AddWithValue("", idusuario);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
            }
            catch
            {
                filasAfectadas = -1;
            }
            return filasAfectadas;
        }

        public int activarUsuario(int idusuario)
        {
            int filasAfectadas = 0;

            try
            {
                SqlCommand command = new SqlCommand("", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;

                acceso.conectar();
                command.Parameters.AddWithValue("", idusuario);
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
