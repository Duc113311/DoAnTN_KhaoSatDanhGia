using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{
   public interface IQuestionTypeRepo:IBaseRepository<QuestionType>
    {
        int AddQuestionType(QuestionType questionType);


    }
}
