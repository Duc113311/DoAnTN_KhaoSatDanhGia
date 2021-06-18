using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
    public class QuestionTypeService : BaseService<QuestionType>, IQuestionTypeService
    {
        #region DECLARE
        IQuestionTypeRepo _questionTypeRepo ;
        #endregion

        #region CONSTRUCTOR
        public QuestionTypeService(IQuestionTypeRepo questionTypeRepo, IBaseRepository<QuestionType> baseRepository) : base(baseRepository)
        {
            _questionTypeRepo = questionTypeRepo;
        }

        #endregion
    }
}
