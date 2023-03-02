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
    public class Categoria
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarCategorias()
        {
            DataTable data = new DataTable();

            acceso.conectar();
            SqlDataAdapter command = new SqlDataAdapter("", acceso.getConexion());
            command.Fill(data);
            acceso.desconectar();

            return data;
        }

        public int registrarCategoria(string categoria)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar ();

                command.Parameters.AddWithValue("@categoria", categoria);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int editarCategoria(int idcategoria, string categoria)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idcategoria", idcategoria);
                command.Parameters.AddWithValue("@categoria", categoria);
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
