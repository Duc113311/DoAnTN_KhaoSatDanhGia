using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMon.Web.Controllers
{

    public class ClassChildrenController : BaseController<ClassChildren>
    {
        IClassChildrenService _classChildrenService;
        public ClassChildrenController(IClassChildrenService classChildrenService) : base(classChildrenService)
        {
            _classChildrenService = classChildrenService;
        }
    }
}
