using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using SchoolMon.Application.Entities;
using SchoolMon.Application.Enums;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Infrastructure
{
    public class BaseReponsitory<Entity> : IBaseRepository<Entity>, IDisposable where Entity : BaseEntity
    {
        #region DECLARE
        IConfiguration _configuration;
        string _connectionString = string.Empty;
        protected IDbConnection _dbConnection = null;
        protected string _tableName;
        #endregion

        #region CONSTRUCTOR
        public BaseReponsitory(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration["SQLServer:ConnectionString"];
            _dbConnection = new SqlConnection(_connectionString);
            _tableName = typeof(Entity).Name;
        }
        //Đóng kết nối
        public void Dispose()
        {
            if (_dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
            }
        }

        public IEnumerable<Entity> GetEntities()
        {
            var entities = _dbConnection.Query<Entity>($"Proc_Get{_tableName}", commandType: CommandType.StoredProcedure);
            return entities;
        }

        public Entity GetEntityById(Guid entityId)
        {
            var parameter = new DynamicParameters();
            parameter.Add($@"{_tableName}Id", entityId, DbType.Guid);
            var entitie = _dbConnection.Query<Entity>($"Proc_Get{_tableName}ById", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return entitie;
        }

        public int Add(Entity entity)
        {
            var rowAffects = 0;
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                try
                {

                    var parameters = MappingDbType(entity);
                    //Thực hiện thêm khách hàng:
                    rowAffects = _dbConnection.Execute($"Proc_Insert{_tableName}", parameters, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    transaction.Rollback();
                }

            }
            return rowAffects;
        }

        public int Update(Entity entity)
        {
            var rowAffect = 0;
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                try
                {
                    var parameters = MappingDbType(entity);
                    rowAffect = _dbConnection.Execute($"Proc_Update{_tableName}", parameters, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    transaction.Rollback();
                }
            }
            return rowAffect;
        }

        public int Delete(Guid entityId)
        {
            var rowAffect = 0;
            _dbConnection.Open();
            using (var transaction = _dbConnection.BeginTransaction())
            {
                try
                {
                    var parameters = new DynamicParameters();
                    parameters.Add($@"{_tableName}Id", entityId, DbType.Guid);
                    rowAffect = _dbConnection.Execute($"Proc_Delete{_tableName}s", parameters, transaction, commandType: CommandType.StoredProcedure);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    transaction.Rollback();
                }
            }
            return rowAffect;
        }

       

        /// <summary>
        /// Chuyển kiểu guid sang string
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>DynamicParameters</returns>
        public DynamicParameters MappingDbType(Entity entity)
        {
            var properties = entity.GetType().GetProperties();
            var parameters = new DynamicParameters();
            foreach (var property in properties)
            {
                var propertyName = property.Name;
                var propertyValue = property.GetValue(entity);
                var propertyType = property.PropertyType;
                //if (propertyType == typeof(Guid) || propertyType == typeof(Guid?))
                //{
                //    parameters.Add($"@{propertyName}", propertyValue, DbType.String);
                //}
                 if (propertyType == typeof(bool) || propertyType == typeof(bool?))
                {
                    //Nếu không thành công thì comment dòng dưới và mở comment propertyType
                    var dbValue = ((bool)propertyValue == true ? 1 : 0);
                    parameters.Add($"@{propertyName}", /*propertyType*/ dbValue, DbType.Int32);
                }
                else
                {
                    parameters.Add($"@{propertyName}", propertyValue);
                }
            }
            return parameters;
        }
      
        #endregion
    }
}
