using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
   public class QuestionService:BaseService<Question>,IQuestionService
    {
        #region DECLARE
        IQuestionReponsitory _questionReponsitory;
        #endregion

        #region CONSTRUCTOR
        public QuestionService(IQuestionReponsitory questionReponsitory, IBaseRepository<Question> baseRepository):base(baseRepository) 
        {
            _questionReponsitory = questionReponsitory;
        }

        #endregion
    }
}
