using Microsoft.Extensions.Configuration;
using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Infrastructure
{
    public class QuestionTypeReponsitory : BaseReponsitory<QuestionType>, IQuestionTypeRepo
    {
        public QuestionTypeReponsitory(IConfiguration configuration) : base(configuration)
        {

        }

        public int AddQuestionType(QuestionType questionType)
        {
            throw new NotImplementedException();
        }
    }
}
