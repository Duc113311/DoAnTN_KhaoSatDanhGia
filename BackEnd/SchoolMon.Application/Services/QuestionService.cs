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
        ServiceResult _serviceResult;
        #endregion

        #region CONSTRUCTOR
        public QuestionService(IQuestionReponsitory questionReponsitory, IBaseRepository<Question> baseRepository):base(baseRepository) 
        {
            _questionReponsitory = questionReponsitory;
        }

        #endregion

        public int DeleteQuestion(Guid questionId)
        {
            var value = _questionReponsitory.DeleteQuestion(questionId);
            return value;
        }

        public ServiceResult DeleteAssets(string[] array)
        {
            var rowEffect = _questionReponsitory.DeleteAssets(array);
            if (rowEffect > 0)
            {
                _serviceResult.Messenger = Properties.Resources.msg_delete;
                _serviceResult.Data = rowEffect;
                _serviceResult.SchoolCode = Enums.SchoolCode.IsValid;
                return _serviceResult;
                
            }
            else
            {
                _serviceResult.Messenger = Properties.Resources.msg_isNot;
                _serviceResult.Data = rowEffect;
                _serviceResult.SchoolCode = Enums.SchoolCode.NotValid;
                return _serviceResult;
            }
        }
    }
}
