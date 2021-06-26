using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
   public class ClassChildrenService : BaseService<ClassChildren>, IClassChildrenService
    {

        #region DECLARE
        IClassChildrenRepo _classChildrenRepo;
        #endregion

        #region CONSTRUCTOR
        public ClassChildrenService(IClassChildrenRepo classChildrenRepo, IBaseRepository<ClassChildren> baseRepository) : base(baseRepository)
        {
            _classChildrenRepo = classChildrenRepo;
        }
        #endregion

        #region fun
       

        #endregion

    }
}
