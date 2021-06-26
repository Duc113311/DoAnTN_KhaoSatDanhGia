using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
   public class EvalutionSubmitService : BaseService<EvalutionSubmit>, IEvalutionSubmitService
    {
        #region DECLARE
        IEvalutionSubmitRepo _evalutionSubmitRepo1;
        #endregion

        #region CONSTRUCTOR
        public EvalutionSubmitService(IEvalutionSubmitRepo evalutionSubmitRepo, IBaseRepository<EvalutionSubmit> baseRepository) : base(baseRepository)
        {
            _evalutionSubmitRepo1 = evalutionSubmitRepo;
        }

        public List<EvaluParam> GetAllEvalutiobSubmit()
        {
            var value = _evalutionSubmitRepo1.GetAllEvalutiobSubmit();
            return value;
        }

        public EvaluParam GetDetailEvaluSubmit(Guid entityId)
        {
          
                return _evalutionSubmitRepo1.GetDetailEvaluSubmit(entityId);
         
        }

        #endregion

        #region fun

        public List<EvalutionSubmit> InsertEvalutionCard(Guid EvalutionID, string ListChildrenID)
        {
            var values = _evalutionSubmitRepo1.InsertEvalutionCard(EvalutionID, ListChildrenID);
            return values;
        }


        #endregion

    }
}
