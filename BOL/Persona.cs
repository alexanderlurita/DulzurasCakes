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

        public DataTable listarPersonas(int estado)
        {
            return acceso.getDataFrom("SPU_PERSONAS_LISTAR",estado);
        }

        public int registrarPersona(EntPersona entPersona)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_PERSONAS_INSERTAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("@apellidos", entPersona.apellidos);
                command.Parameters.AddWithValue("@nombres", entPersona.nombres);
                command.Parameters.AddWithValue("@dni", entPersona.dni);
                command.Parameters.AddWithValue("@direccion", entPersona.direccion);
                command.Parameters.AddWithValue("@telefono", entPersona.telefono);
                command.Parameters.AddWithValue("@email", entPersona.email);

                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();

                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int editarPersona(EntPersona entPersona)
        {

            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_PERSONAS_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("@idpersona", entPersona.idpersona);
                command.Parameters.AddWithValue("@apellidos", entPersona.apellidos);
                command.Parameters.AddWithValue("@nombres", entPersona.nombres);
                command.Parameters.AddWithValue("@dni", entPersona.dni);
                command.Parameters.AddWithValue("@direccion", entPersona.direccion);
                command.Parameters.AddWithValue("@telefono", entPersona.telefono);
                command.Parameters.AddWithValue("@email", entPersona.email);

                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();

                return filasAfectadas;
            }
            catch
            {
                return -1;
            }


        }

        public DataTable buscarPersona(EntPersona entPersona)
        {
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SPU_PERSONAS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idpersona", entPersona.idpersona);
            acceso.conectar();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(table);

            acceso.desconectar();
            return table;
        }

        public DataTable buscarPersonaDni(EntPersona entPersona)
        {
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SPU_PERSONAS_BUSCARDNI", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@dni", entPersona.dni);
            acceso.conectar();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(table);

            acceso.desconectar();
            return table;
        }

        public int eliminarPersona(EntPersona entPersona)
        {
            int filasAfectadas = 0;
            try
            {

                SqlCommand command = new SqlCommand("SPU_PERSONAS_ELIMINAR", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;
                acceso.conectar();
                command.Parameters.AddWithValue("@idpersona", entPersona.idpersona);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int activarPersona(EntPersona entPersona)
        {
            int filasAfectadas = 0;

            try
            {
                SqlCommand command = new SqlCommand("SPU_PERSONAS_ACTIVAR", acceso.getConexion());
                command.CommandType = CommandType.StoredProcedure;
                acceso.conectar();
                command.Parameters.AddWithValue("@idpersona", entPersona.idpersona);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return  -1;
            }
        }

    }
}
