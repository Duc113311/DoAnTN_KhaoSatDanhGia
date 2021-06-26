using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
   public class EvalutionService : BaseService<Evalution>, IEvalutionService
    {
        #region DECLARE
        IEvalutionRepo _evalutionRepo;
        #endregion

        #region CONSTRUCTOR
        public EvalutionService(IEvalutionRepo evalutionRepo, IBaseRepository<Evalution> baseRepository) : base(baseRepository)
        {
            _evalutionRepo = evalutionRepo;
        }

        public EvaluParam GetDetailEvalution(Guid entityId)
        {
            return _evalutionRepo.GetDetailEvalution(entityId);
        }

        #endregion
    }
}
