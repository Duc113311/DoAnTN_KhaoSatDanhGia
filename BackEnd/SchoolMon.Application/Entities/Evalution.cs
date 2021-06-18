using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
    public class Evalution:BaseEntity
    {
        public Guid EvalutionID { get; set; }

        public string EvalutionName { get; set; }

        public DateTime DateBy { get; set; }

        public int QuestionSatus { get; set; }

        public int Type { get; set; }

        public string Describe { get; set; }

    }
}
