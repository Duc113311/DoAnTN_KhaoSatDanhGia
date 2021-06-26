using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{
    public interface IEvalutionSubmitService:IBaseService<EvalutionSubmit>
    {
        List<EvalutionSubmit> InsertEvalutionCard(Guid EvalutionID, string ListChildrenID);

        List<EvaluParam> GetAllEvalutiobSubmit();

        EvaluParam GetDetailEvaluSubmit(Guid entityId);

    }
}
