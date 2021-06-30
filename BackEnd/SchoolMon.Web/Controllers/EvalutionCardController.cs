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

    public class EvalutionCardController : BaseController<EvalutionCard>
    {
        IEvalutionCardService _evalutionCardService;

        public EvalutionCardController(IEvalutionCardService evalutionCardService) : base(evalutionCardService)
        {
            _evalutionCardService = evalutionCardService;
        }

        [HttpPost("evalutionCard")]
        public IActionResult InsetEvalutinCare([FromBody] EvaluParam evaluParam)
        {
            var emtity = _evalutionCardService.InsertEvalutionCard(evaluParam.evalutionName, evaluParam.describe, evaluParam.listEvalution);
            return Ok(emtity);
        }

        [HttpDelete("evaluCard/{id}")]
        public IActionResult DeleteCả(int id)
        {
            var serviceResult = _evalutionCardService.Delete(id);
            return StatusCode(201, serviceResult);
        }
    }
}
