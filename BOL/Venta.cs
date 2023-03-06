using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using ENTITIES;

namespace BOL
{
    public class Venta
    {
        DBAccess acceso = new DBAccess();

        public DataTable listar()
        {
            DataTable data = new DataTable();

            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter("SPU_VENTAS_LISTAR", acceso.getConexion());
            adapter.Fill(data);
            acceso.desconectar();

            return data;
        }
        
        public DataTable buscar(EntVenta entidad)
        {
            DataTable data = new DataTable();
            acceso.conectar();

            SqlCommand command = new SqlCommand("SPU_VENTAS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idventa", entidad.idventa);
            data.Load(command.ExecuteReader());

            acceso.desconectar();
            return data;
        }

        public int registrar(EntVenta entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_VENTAS_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idpersona", entidad.idpersona);
                command.Parameters.AddWithValue("@idempresa", entidad.idempresa);
                command.Parameters.AddWithValue("@idusuario", entidad.idusuario);
                command.Parameters.AddWithValue("@idtipopago", entidad.idtipopago);
                command.Parameters.AddWithValue("@tipodocumento", entidad.tipodocumento);
                command.Parameters.AddWithValue("@nrodocumento", entidad.nrodocumento);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }
        
        public int editar(EntVenta entidad)
        {
            int filasAfectadas = 0;

            SqlCommand command = new SqlCommand("SPU_VENTAS_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idventa", entidad.idventa);
                command.Parameters.AddWithValue("@idpersona", entidad.idpersona);
                command.Parameters.AddWithValue("@idempresa", entidad.idempresa);
                command.Parameters.AddWithValue("@idusuario", entidad.idusuario);
                command.Parameters.AddWithValue("@idtipopago", entidad.idtipopago);
                command.Parameters.AddWithValue("@tipodocumento", entidad.tipodocumento);
                command.Parameters.AddWithValue("@nrodocumento", entidad.nrodocumento);
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
