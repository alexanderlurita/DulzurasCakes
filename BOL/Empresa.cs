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
    public class Empresa
    {
        //instanciar la conexion a la BD
        DBAccess acceso = new DBAccess();

        public DataTable listarEmpresa()
        {
            //utilizando metodo de DAL(conexion) 
            return acceso.getDataFrom("SPU_EMPRESAS_LISTAR", 1);
        }

        public int registrarEmpresa(EntEmpresa registrar)
        {
            
            int filasAfectadas = 0;
            acceso.conectar();
            // objeto que permite la insercion del registro
            SqlCommand command = new SqlCommand("SPU_EMPRESAS_INSERTAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@razonSocial", registrar.razonSocial);
            command.Parameters.AddWithValue("@ruc", registrar.ruc);
            command.Parameters.AddWithValue("@direccion", registrar.direccion);
            command.Parameters.AddWithValue("@telefono", registrar.telefono);
            command.Parameters.AddWithValue("@email", registrar.email);
            filasAfectadas = command.ExecuteNonQuery();
            acceso.desconectar();
            return filasAfectadas;
        }

        public int editarEmpresa(EntEmpresa editar)
        {
            int filasAfectadas = 0;
            SqlCommand command = new SqlCommand("SPU_EMPRESAS_EDITAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            acceso.conectar();
            command.Parameters.AddWithValue("@idempresa", editar.idempresa);
            command.Parameters.AddWithValue("@razonSocial", editar.razonSocial);
            command.Parameters.AddWithValue("@ruc", editar.ruc);
            command.Parameters.AddWithValue("@direccion", editar.direccion);
            command.Parameters.AddWithValue("@telefono", editar.telefono);
            command.Parameters.AddWithValue("@email", editar.email);

            filasAfectadas = command.ExecuteNonQuery();
            acceso.desconectar();

            return filasAfectadas;
        }

        public DataTable buscarEmpresa(EntEmpresa buscar)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SPU_EMPRESAS_BUSCAR", acceso.getConexion());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ruc", buscar.ruc);
            acceso.conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            acceso.desconectar();
            return table;
        }
        

    }
}
