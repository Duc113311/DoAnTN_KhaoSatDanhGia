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
            for(int i=0; i< listEv.Count(); i++)
            {
                listEv[i].questions = _dbConnection.Query<EvalutionSubmit>("Select * from EvalutionSubmit where EvalutionID='"+listEv[i].evalutionId+"' and ChildrenID= '"+listEv[i].ChildrenID+"'" , commandType: CommandType.Text).ToList();
            }
            return listEv;
        }

        public EvaluParam GetDetailEvaluSubmit(Guid entityId)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@EvalutionID", entityId, DbType.Guid);
            var entitie = _dbConnection.Query<EvaluParam>("Proc_GetDetailEvalutionSubmit", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();

            entitie.questions = _dbConnection.Query<EvalutionSubmit>("Select * from EvalutionSubmit where EvalutionID='" + entitie.evalutionId + "' and ChildrenID= '" + entitie.ChildrenID + "'", commandType: CommandType.Text).ToList();
            
            return entitie;
        }

        public bool UpdateEvaluChi(Guid evalutionID, List<Answer> aw)
        {
            try
            {
                for (int i = 0; i < aw.Count(); i++)
                {
                    var parameter = new DynamicParameters();
                    var element = aw[i];
                    parameter.Add("@EvalutionID", evalutionID, DbType.Guid);
                    parameter.Add("@QuestionID", element.id, DbType.Guid);
                    parameter.Add("@Normal", element.answer, DbType.Int32);
                    parameter.Add("@Paragraph", element.paragraph, DbType.String);
                    var entitie2 = _dbConnection.Query<EvaluParam>("Proc_PostEvaluSubmit", parameter, commandType: CommandType.StoredProcedure);
                }

                return true;
            }
            catch(Exception ms)
            {
                return false;
            }

           
        }


        public List<Thongke> Thongke()
        {
            var param = new DynamicParameters();
            var listEv = _dbConnection.Query<Thongke>("Proc_ThongKe", param, commandType: CommandType.StoredProcedure).ToList();
            return listEv;
        }
        public List<EvaluParam> FillterEvalChil(Guid classID, string childrenName)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@ClassID", classID, DbType.Guid);
            parameter.Add("@ChildrenName", childrenName, DbType.String);
            var entitie = _dbConnection.Query<EvaluParam>("Proc_FillterEvaluChil", parameter, commandType: CommandType.StoredProcedure).ToList();

            for (int i = 0; i < entitie.Count(); i++)
            {
                entitie[i].questions = _dbConnection.Query<EvalutionSubmit>("Select * from EvalutionSubmit where EvalutionID='" + entitie[i].evalutionId + "' and ChildrenID= '" + entitie[i].ChildrenID + "'", commandType: CommandType.Text).ToList();
            }
            return entitie;
        }
    }
}
