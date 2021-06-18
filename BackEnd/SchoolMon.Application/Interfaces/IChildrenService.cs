using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{
   public interface IChildrenService:IBaseService<Children>
    {
        List<Children> GetFilter(string childrenName, string className);
    }
}
