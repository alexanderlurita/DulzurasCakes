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
    public class TipoPago
    {
        DBAccess acceso = new DBAccess();
        EntTipoPago tipoPago = new EntTipoPago();

        public DataTable listarTipoPagos()
        {
            DataTable data = new DataTable();

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_TIPOPAGOS_LISTAR", acceso.getConexion());
            adapter.Fill(data);

            acceso.desconectar();
            return data;
        }

        public int registrarTipoPago(EntTipoPago registrar)
        {
            int filasAfectadas = 0;

            SqlCommand command = new SqlCommand("SPU_TIPOPAGOS_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("@tipopago", registrar.tipoPago);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();

                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int editarTipoPago(EntTipoPago editar)
        {
            int filasAfectadas = 0;

            SqlCommand command = new SqlCommand("SPU_TIPOPAGOS_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();
                command.Parameters.AddWithValue("@ID", editar.idTipopago);
                command.Parameters.AddWithValue("@tipopago", editar.tipoPago);
                filasAfectadas = command.ExecuteNonQuery();
                acceso.desconectar();

                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public DataTable buscarTipoPago(EntTipoPago buscar)
        {
            DataTable data = new DataTable();

            SqlCommand command = new SqlCommand("SPU_TIPOPAGOS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", buscar.idTipopago);

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            acceso.desconectar();

            return data;
        }

    }
}
