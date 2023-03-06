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
    public class Rol
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarRoles()
        {
            DataTable rol = new DataTable();

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_ROLES_LISTAR", acceso.getConexion());
            adapter.Fill(rol);
            
            acceso.desconectar();
            return rol;
        }

        public int registrarRol(EntRol entRol)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_ROLES_INSERTAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("@rol", entRol.nombreRol);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int editarRol(EntRol entRol)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_ROLES_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("@idrol", entRol.idrol);
                command.Parameters.AddWithValue("@rol", entRol.nombreRol);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();

                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public DataTable buscarRol(EntRol entRol)
        {
            DataTable buscar = new DataTable();

            SqlCommand command = new SqlCommand("SPU_ROL_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idrol",entRol.idrol);
            acceso.conectar();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(buscar);
            acceso.desconectar();

            return buscar;
        }

    }
}
