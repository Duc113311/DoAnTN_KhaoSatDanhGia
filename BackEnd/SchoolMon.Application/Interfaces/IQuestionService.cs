using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{
    public interface IQuestionService:IBaseService<Question>
    {
        int DeleteQuestion(Guid questionId);

        /// <summary>
        /// Xóa nhiều
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        ServiceResult DeleteAssets(string[] array);

        List<Question> GetFilter(string spec);

    }
}
