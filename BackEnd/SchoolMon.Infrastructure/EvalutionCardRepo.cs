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

        public List<EvalutionCard> InsertEvalutionCard(string evalutionName, string listEvalution)
        {
            var param = new DynamicParameters();
            
            param.Add("@EvalutionName", evalutionName,  DbType.String);
            param.Add("@ListQuestion", listEvalution, DbType.String);
            var fees = _dbConnection.Query<EvalutionCard>("Proc_InsertEvalutionCard", param, commandType: CommandType.StoredProcedure).ToList();
            return fees;

        }
    }

   
}
