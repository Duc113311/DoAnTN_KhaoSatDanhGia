using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
    public class EvalutionCardService : BaseService<EvalutionCard>, IEvalutionCardService
    {
        #region DECLARE
        IEvalutionCardRepository _evalutionCardRepository;
        #endregion

        #region CONSTRUCTOR
        public EvalutionCardService(IEvalutionCardRepository evalutionCardRepository, IBaseRepository<EvalutionCard> baseRepository) : base(baseRepository)
        {
            _evalutionCardRepository = evalutionCardRepository;
        }

        #endregion

        #region fun
        public List<EvalutionCard> InsertEvalutionCard (string evalutionName,string listevalution)
        {
            var values = _evalutionCardRepository.InsertEvalutionCard(evalutionName, listevalution);
            return values;
        }
        #endregion

    }
}
