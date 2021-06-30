using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
   public class Thongke
    {
        public Guid evalutionId { get; set; }

        public string evalutionName { get; set; }
        public int Satisfied1 { get; set; }

        /// <summary>
        /// Không hài lòng
        /// </summary>
        public int Unsatisfied1 { get; set; }

        /// <summary>
        /// Rẩ hài lòng
        /// </summary>
        public int VerySatisfied1 { get; set; } 

        /// <summary>
        /// Rất không hài lòng
        /// </summary>
        public int VeryUnsatisfied1 { get; set; }
        /// <summary>
        /// Bình thường
        /// </summary>
        public int Normal1 { get; set; }
    }
}
