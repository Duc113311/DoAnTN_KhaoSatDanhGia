using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
   public class EvalutionCard: BaseEntity
    {
        public int EvalutionCardID { get; set; }

        public Guid EvalutionID { get; set; }

        public Guid QuestionID { get; set; }

        public string QuestionName { get; set; }

        public int Satisfied { get; set; }

        public int Unsatisfied { get; set; }
        public int VerySatisfied { get; set; }

        public int VeryUnsatisfied { get; set; }
        public int Normal { get; set; }

        public string Paragraph { get; set; }

    }
}
