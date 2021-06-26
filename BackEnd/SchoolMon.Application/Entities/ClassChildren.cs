using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
   public class ClassChildren:BaseEntity
    {
        public Guid ClassID { get; set; }

        public string ClassName { get; set; }

        public string TeacherName { get; set; }
    }
}
