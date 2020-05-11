using Dapper;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using prueba2ApiMaipo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace prueba2ApiMaipo.Repositories
{
    public class RolRepository : IRolRepository
    {
        IConfiguration configuration;

        public RolRepository(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public object DeleteRol(int id)
        {
            object result = null;

            try
            {
                var dyParam = new OracleDynamicParameters();///agrega los datos para consultar o insert al sp


                ///son los campos que tiene el sp ////ojo con el tipo de dato del sp y con el que envio
                dyParam.Add("r_id", OracleDbType.Int32, ParameterDirection.Input, id);
               
                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var query = "SP_DELETE_ROL";

                    result = SqlMapper.Query(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public object EditRol(Rol rol, int id)
        {
            object result = null;

            try
            {
                var dyParam = new OracleDynamicParameters();///agrega los datos para consultar o insert al sp


                ///son los campos que tiene el sp ////ojo con el tipo de dato del sp y con el que envio
                dyParam.Add("r_id", OracleDbType.Int32, ParameterDirection.Input, id);
                dyParam.Add("r_nombre", OracleDbType.Varchar2, ParameterDirection.Input, rol.rol_nombre);
                dyParam.Add("r_activo", OracleDbType.Int32, ParameterDirection.Input, rol.rol_activo);

                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var query = "SP_EDIT_ROL";

                    result = SqlMapper.Query(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rol;
        }

        public object GetRol()
        {
            object result = null;

            try
            {
                var dyParam = new OracleDynamicParameters();
                dyParam.Add("EMPCURSOR", OracleDbType.RefCursor, ParameterDirection.Output);

                var conn = this.GetConnection();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var query = "SP_GET_ROL";

                    result = SqlMapper.Query(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public object InsertRol(Rol rol)
        {
            object result = null;

            try
            {
                var dyParam = new OracleDynamicParameters();

                dyParam.Add("r_nombre", OracleDbType.Varchar2, ParameterDirection.Input, rol.rol_nombre);
                dyParam.Add("r_activo", OracleDbType.Int32, ParameterDirection.Input, rol.rol_activo);

                var conn = this.GetConnection();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var query = "SP_INSERT_ROL";

                    result = SqlMapper.Query(conn, query, param: dyParam, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return rol;
        }

        private IDbConnection GetConnection()
        {
            var conectionString = configuration.GetSection("ConnectionStrings").GetSection("MapioConnection").Value;
            var conn = new OracleConnection(conectionString);
            return conn;
        }
    }
}
