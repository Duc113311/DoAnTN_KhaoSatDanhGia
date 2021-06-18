using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
   public class QuestionType:BaseEntity
    {
        public Guid QuestionTypeID { get; set; }

        public string QuestionTypeName { get; set; }

        public string Describe { get; set; }


    }
}
