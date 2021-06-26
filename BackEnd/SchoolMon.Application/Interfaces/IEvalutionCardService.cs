using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{
    public interface IEvalutionCardService : IBaseService<EvalutionCard>
    {
        List<EvalutionCard> InsertEvalutionCard(string EvalutionName,string Describe, string listEvalution);

    }
}
