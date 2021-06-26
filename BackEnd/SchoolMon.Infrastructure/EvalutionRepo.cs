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
   public class EvalutionRepo : BaseReponsitory<Evalution>, IEvalutionRepo
    {
        public EvalutionRepo(IConfiguration configuration) : base(configuration)
        {

        }

        public EvaluParam GetDetailEvalution(Guid entityId)
        {
                var parameter = new DynamicParameters();
                parameter.Add("@EvalutionID", entityId, DbType.Guid);
                var entitie = _dbConnection.Query<EvaluParam>("Proc_GetDetailEvalution", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
                return entitie;
        }
    }
}
