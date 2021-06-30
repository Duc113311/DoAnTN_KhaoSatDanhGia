using Dapper;
using Microsoft.Extensions.Configuration;
using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Infrastructure
{
   public class EvalutionCardRepo: BaseReponsitory<EvalutionCard>,IEvalutionCardRepository
    {
        public EvalutionCardRepo(IConfiguration configuration):base(configuration)
        {

        }

        public List<EvalutionCard> InsertEvalutionCard(string evalutionName,string describe, string listEvalution)
        {
            var param = new DynamicParameters();
            
            param.Add("@EvalutionName", evalutionName,  DbType.String);
            param.Add("@Describe", describe, DbType.String);
            param.Add("@ListQuestion", listEvalution, DbType.String);
            var fees = _dbConnection.Query<EvalutionCard>("Proc_InsertEvalutionCard", param, commandType: CommandType.StoredProcedure).ToList();
            return fees;

        }

        public int Delete(int entityId)
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
    }

   
}
