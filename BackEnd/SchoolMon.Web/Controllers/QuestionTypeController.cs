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
    public class QuestionTypeController : BaseController<QuestionType>
    {
        IQuestionTypeService _questionTypeService;

        public QuestionTypeController(IQuestionTypeService questionTypeService) : base(questionTypeService)
        {
            _questionTypeService = questionTypeService;
        }
    }
}
