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
    public class TipoPago
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarTipoPagos()
        {
            DataTable data = new DataTable();

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("", acceso.getConexion());
            adapter.Fill(data);
            acceso.desconectar();

            return data;
        }

        public int registrarTipoPago(string tipopago)
        {
            int filasAfectadas = 0;

            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("", tipopago);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();

                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int editarTipoPago(int idTipoPago, string tipopago)
        {
            int filasAfectadas = 0;

            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("", idTipoPago);
                command.Parameters.AddWithValue("", tipopago);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();

                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public DataTable buscarTipoPago(int idTipoPago)
        {
            DataTable data = new DataTable();

            SqlCommand command = new SqlCommand("", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("", idTipoPago);

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            acceso.desconectar();

            return data;
        }

    }
}
