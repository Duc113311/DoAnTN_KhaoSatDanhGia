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
    
    public class EvalutionController : BaseController<Evalution>
    {
        IEvalutionService _evalutionService;

        public EvalutionController(IEvalutionService evalutionService) : base(evalutionService)
        {
            _evalutionService = evalutionService;
        }

        [HttpGet("detaiEvaluion")]
        public IActionResult GetDetailEvalution(Guid id)
        {
            var entity = _evalutionService.GetDetailEvalution(id);
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
