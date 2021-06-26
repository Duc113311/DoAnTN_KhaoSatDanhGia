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
    public class ChildrenController : BaseController<Children>
    {
        IChildrenService _childrenService;

        public ChildrenController(IChildrenService childrenService) : base(childrenService)
        {
            _childrenService = childrenService;
        }

        [HttpGet("filter")]
        public IActionResult GetFilter([FromQuery] string childrenName,[FromQuery] string className)
        {
            var listentity = _childrenService.GetFilter(childrenName, className);
            return Ok(listentity);
        }

        [HttpGet("Id")]
        public IActionResult GetChildrenId(Guid childrenId)
        {
            var entity = _childrenService.GetChildrenById(childrenId);
            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return StatusCode(204);
            }
        }
    }
}
