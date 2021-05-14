using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{
    /// <summary>
    /// Interface kế thừa IBaseRepository có các phương thức riêng của câu hỏi
    /// </summary>
    public interface IQuestionReponsitory : IBaseRepository<Question>
    {

    }
}
