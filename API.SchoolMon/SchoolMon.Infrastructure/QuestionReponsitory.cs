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
    public class QuestionReponsitory : BaseReponsitory<Question>, IQuestionReponsitory
    {
        public QuestionReponsitory(IConfiguration configuration) : base(configuration)
        {

        }
    }
}
