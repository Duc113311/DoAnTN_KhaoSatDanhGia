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
    public class EvalutionSubmitRepo : BaseReponsitory<EvalutionSubmit>, IEvalutionSubmitRepo
    {
        public EvalutionSubmitRepo(IConfiguration configuration) : base(configuration)
        {

        }

        public List<EvalutionSubmit> InsertEvalutionCard(Guid EvalutionID, string ListChildrenID)
        {
            var param = new DynamicParameters();
            param.Add("@EvalutionID", EvalutionID, DbType.Guid);
            param.Add("@ListChildrenID", ListChildrenID, DbType.String);
            var listEv = _dbConnection.Query<EvalutionSubmit>("Proc_InsertEvalutionsubmit", param, commandType: CommandType.StoredProcedure).ToList();
            return listEv;
        }

        public List<EvaluParam> GetAllEvalutiobSubmit()
        {
            var listEv = _dbConnection.Query<EvaluParam>("Proc_GetAllEvalutionSubmit", commandType: CommandType.StoredProcedure).ToList();
            return listEv;
        }

        public EvaluParam GetDetailEvaluSubmit(Guid entityId)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@EvalutionID", entityId, DbType.Guid);
            var entitie = _dbConnection.Query<EvaluParam>("Proc_GetDetailEvalutionSubmit", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return entitie;
        }
    }
}
