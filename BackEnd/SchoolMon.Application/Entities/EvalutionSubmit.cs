using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
   public class EvalutionSubmit:BaseEntity
    {
        public Guid EvalutionSubmitID { get; set; }

        public Guid? ChildrenID { get; set; }

        public Guid? EvalutionID { get; set; }

        public Guid? QuestionID { get; set; }

        public int EvalutionCardID { get; set; }

        public string ChildrenName { get; set; }

        public string ParentName { get; set; }

        public string EvalutionName { get; set; }


        public string QuestionName { get; set; }

        public int Satisfied { get; set; }

        public int Unsatisfied { get; set; }

        public int VerySatisfied { get; set; }

        public int VeryUnsatisfied { get; set; }

        public int Normal { get; set; }

        public string Paragraph { get; set; }

        public int Status { get; set; }
    }
}
