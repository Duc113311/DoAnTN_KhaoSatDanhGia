using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
   public class ChildrenService: BaseService<Children>, IChildrenService
    {

        #region DECLARE
        IChildrenRepo _childrenRepo;
        #endregion

        #region CONSTRUCTOR
        public ChildrenService(IChildrenRepo childrenRepo, IBaseRepository<Children> baseRepository) : base(baseRepository)
        {
            _childrenRepo = childrenRepo;
        }

        public IEnumerable<EvaluParam> GetAllChilEvalutionChil()
        {
            var values = _childrenRepo.GetAllChilEvalutionChil();
            return values;
        }
        #endregion

        #region fun
        public List<Children> GetFilter(string childrenName, string className)
        {
            var values = _childrenRepo.GetFilter(childrenName, className);
            return values;
        }

       

        IEnumerable<Children> IChildrenService.GetChildrenById(Guid childrenId)
        {
            return _childrenRepo.GetChildrenById(childrenId);
        }





        #endregion

    }
}
