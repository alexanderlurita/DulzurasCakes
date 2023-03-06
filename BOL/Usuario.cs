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
    public class Usuario
    {
        DBAccess acceso = new DBAccess();
        EntUsuario entUsuario = new EntUsuario();

        public DataTable iniciarSesion(EntUsuario login)
        {
            DataTable data = new DataTable(); acceso.conectar();
            SqlCommand command = new SqlCommand("SPU_USUARIOS_LOGIN", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure; command.Parameters.AddWithValue("@nombreusuario", login.nombreusuario); data.Load(command.ExecuteReader());
            acceso.desconectar(); return data;
        }

        public DataTable listarUsuarios(int estado)
        {
            return acceso.getDataFrom("SPU_USUARIOS_LISTAR", estado);
        }

        public int registrarUsuario(EntUsuario entUsuario)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_USUARIOS_INSERTAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            
                acceso.conectar();
                command.Parameters.AddWithValue("@idpersona", entUsuario.idpersona);
                command.Parameters.AddWithValue("@idrol", entUsuario.idrol);
                command.Parameters.AddWithValue("@nombreusuario", entUsuario.nombreusuario);
                command.Parameters.AddWithValue("@claveacceso", entUsuario.claveacceso);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
           
        }

        public int editarUsuario(EntUsuario entUsuario)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_USUARIOS_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("@idusuario", entUsuario.idusuario);
                command.Parameters.AddWithValue("@idpersona", entUsuario.idpersona);
                command.Parameters.AddWithValue("@idrol", entUsuario.idrol);
                command.Parameters.AddWithValue("@nombreusuario", entUsuario.nombreusuario);
                command.Parameters.AddWithValue("@claveacceso", entUsuario.claveacceso);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public DataTable buscarUsuario(EntUsuario entUsuario)
        {
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SPU_USUARIOS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idusuario", entUsuario.idusuario);
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            acceso.desconectar();
            return table;
        }

        public int eliminarUsuario(EntUsuario entUsuario)
        {
            int filasAfectadas = 0;

            try
            {
                SqlCommand command = new SqlCommand("SPU_USUARIOS_ELIMINAR", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;
                acceso.conectar();

                command.Parameters.AddWithValue("@idusuario", entUsuario.idusuario);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
            }
            catch
            {
                filasAfectadas = -1;
            }
            return filasAfectadas;
        }

        public int activarUsuario(EntUsuario entUsuario)
        {
            int filasAfectadas = 0;

            try
            {
                SqlCommand command = new SqlCommand("SPU_USUARIOS_ACTIVAR", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;

                acceso.conectar();
                command.Parameters.AddWithValue("@idusuario", entUsuario.idusuario);
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
