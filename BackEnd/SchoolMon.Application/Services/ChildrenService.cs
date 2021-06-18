﻿using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
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
        #endregion

        #region fun
        public List<Children> GetFilter(string childrenName, string className)
        {
            var values = _childrenRepo.GetFilter(childrenName, className);
            return values;
        }

        #endregion

    }
}
