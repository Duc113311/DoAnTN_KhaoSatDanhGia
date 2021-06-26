using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
    public class EvaluParam
    {
        public string evalutionName { get; set; }

        public string describe { get; set; }

        public string listEvalution { get; set; }

        public Guid evalutionId { get; set; }

        public string listChil { get; set; }

        public string ChildrenName { get; set; }

        public string QuestionName { get; set; }

        public string ChildrenCode { get; set; }

        public string TeacherName { get; set; }

        public string ParentName { get; set; }

        public string ClassName { get; set; }

        public int QuestionSatus { get; set; }

        public int Satisfied { get; set; }

        /// <summary>
        /// Không hài lòng
        /// </summary>
        public int Unsatisfied { get; set; }

        /// <summary>
        /// Rẩ hài lòng
        /// </summary>
        public int VerySatisfied { get; set; }

        /// <summary>
        /// Rất không hài lòng
        /// </summary>
        public int VeryUnsatisfied { get; set; }

        /// <summary>
        /// Bình thường
        /// </summary>
        public int Normal { get; set; }
        public string Paragraph { get; set; }
    }
}
