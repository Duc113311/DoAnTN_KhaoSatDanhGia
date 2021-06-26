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
    public class QuestionsController : BaseController<Question>
    {
        IQuestionService _questionService;

         public QuestionsController(IQuestionService questionService):base(questionService)
        {
            _questionService = questionService;
        }

        [HttpDelete("Question")]
        public int DeleteQuestion(Guid questionId)
        {
            var value = _questionService.DeleteQuestion(questionId);
            return value;
        }

        [HttpDelete("DeleteAll")]
        public IActionResult DeleteAssets([FromBody] string[] array)
        {
            var result = _questionService.DeleteAssets(array);
            return StatusCode(201, result);
        }

    }
}
