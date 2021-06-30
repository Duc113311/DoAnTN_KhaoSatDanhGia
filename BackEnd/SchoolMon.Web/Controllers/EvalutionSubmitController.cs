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

    public class EvalutionSubmitController : BaseController<EvalutionSubmit>
    {
        IEvalutionSubmitService _evalutionSubmitService;

        public EvalutionSubmitController(IEvalutionSubmitService evalutionSubmitService):base (evalutionSubmitService)
        {
            _evalutionSubmitService = evalutionSubmitService;
        }

        [HttpPost("evalutionsubmit")]
        public IActionResult InsertEvalutionSubmit([FromBody] EvaluParam evaluParam)
        {
            var entity = _evalutionSubmitService.InsertEvalutionCard(evaluParam.evalutionId, evaluParam.listChil);
            return Ok(entity);

        }
        [HttpGet("getAllSub")]
        public IActionResult GetAllEvalutiobSubmit()
        {
            var entity = _evalutionSubmitService.GetAllEvalutiobSubmit();
            return Ok(entity);
        }

        [HttpGet("IdEvaluSub")]
        public IActionResult GetDetailEvaluSubmit(Guid id)
        {
            var entity = _evalutionSubmitService.GetDetailEvaluSubmit(id);
            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return StatusCode(204);
            }
        }

        [HttpPut("updaEvaChi")]
        public IActionResult UpdateEvaluChi([FromQuery] Guid evalutionID, [FromBody] List<Answer> aw)
        {
            var entity = _evalutionSubmitService.UpdateEvaluChi(evalutionID, aw);
            return Ok(entity);
        }

        [HttpGet("thongke")]
        public IActionResult thongke()
        {
            var entity = _evalutionSubmitService.Thongke();
            return Ok(entity);
        }

        [HttpGet("AllChil")]
        public IActionResult FillterAllEvChi([FromQuery] Guid classID,[FromQuery] string childrenName)
        {
            var entity = _evalutionSubmitService.FillterEvalChil(classID,childrenName);
            return Ok(entity);
        }
    }
}

