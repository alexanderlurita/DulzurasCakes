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
    public class DetalleVenta
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarDetallesVenta(EntDetalleVenta entidad)
        {
            DataTable data = new DataTable();
            acceso.conectar();

            SqlCommand command = new SqlCommand("SPU_DETVENTA_LISTAR_DETALLES_VENTA", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idventa", entidad.idventa);
            data.Load(command.ExecuteReader());

            acceso.desconectar();
            return data;
        }

        public int registrar(EntDetalleVenta entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_DETVENTA_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idventa", entidad.idventa);
                command.Parameters.AddWithValue("@idproducto", entidad.idproducto);
                command.Parameters.AddWithValue("@cantidad", entidad.cantidad);
                command.Parameters.AddWithValue("@precioventa", entidad.precioventa);
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
