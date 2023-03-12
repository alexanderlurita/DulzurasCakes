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
    public class Producto
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("SPU_PRODUCTOS_LISTAR", 1);
        }
        
        public DataTable listarInactivos()
        {
            return acceso.getDataFrom("SPU_PRODUCTOS_LISTAR", 0);
        }

        public DataTable buscar(EntProducto entidad)
        {
            DataTable data = new DataTable();
            acceso.conectar();

            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idproducto", entidad.idproducto);
            data.Load(command.ExecuteReader());

            acceso.desconectar();
            return data;
        }

        public int registrar(EntProducto entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_REGISTRAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
                command.Parameters.AddWithValue("@nombreproducto", entidad.nombreproducto);
                command.Parameters.AddWithValue("@descripcion", entidad.descripcion);
                command.Parameters.AddWithValue("@fechaelaboracion", entidad.fechaelaboracion);
                command.Parameters.AddWithValue("@precio", entidad.precio);
                command.Parameters.AddWithValue("@stock", entidad.stock);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }

        }

        public int editar(EntProducto entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idproducto", entidad.idproducto);
                command.Parameters.AddWithValue("@idcategoria", entidad.idcategoria);
                command.Parameters.AddWithValue("@nombreproducto", entidad.nombreproducto);
                command.Parameters.AddWithValue("@descripcion", entidad.descripcion);
                command.Parameters.AddWithValue("@fechaelaboracion", entidad.fechaelaboracion);
                command.Parameters.AddWithValue("@precio", entidad.precio);
                command.Parameters.AddWithValue("@stock", entidad.stock);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }

        }

        public int eliminar(EntProducto entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_ELIMINAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idproducto", entidad.idproducto);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }
        
        public int activar(EntProducto entidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_ACTIVAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idproducto", entidad.idproducto);
                filasAfectadas = command.ExecuteNonQuery();

                acceso.desconectar();
                return filasAfectadas;
            }
            catch
            {
                return -1;
            }
        }

        public int descontarStock(int idproducto, int cantidad)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_PRODUCTOS_DESCONTAR_STOCK", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;

            try
            {
                acceso.conectar();

                command.Parameters.AddWithValue("@idproducto", idproducto);
                command.Parameters.AddWithValue("@cantidad", cantidad);
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
