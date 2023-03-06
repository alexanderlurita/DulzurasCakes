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
    public class Categoria
    {
        DBAccess acceso = new DBAccess();

        public DataTable listar()
        {
            DataTable data = new DataTable();

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_CATEGORIAS_LISTAR", acceso.getConexion());
            adapter.Fill(data);
            acceso.desconectar();

            return data;
        }

        public DataTable buscar(EntCategoria entidad)
        {
            DataTable data = new DataTable();
            acceso.conectar();

            SqlCommand command = new SqlCommand("SPU_CATEGORIAS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
            data.Load(command.ExecuteReader());

            acceso.desconectar();
            return data;
        }

        public int registrar(EntCategoria entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_CATEGORIAS_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            
            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@categoria", entidad.categoria);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int editar(EntCategoria entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_CATEGORIAS_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
                command.Parameters.AddWithValue("@categoria", entidad.categoria);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

    }
}
