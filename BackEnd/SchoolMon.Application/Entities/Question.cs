using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
    /// <summary>
    /// Đối tượng Câu hỏi
    /// CreateBy: NVDuc 12.05.2021
    /// </summary>
    public class Question:BaseEntity
    {
        #region Property
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid QuestionID { get; set; }

        /// <summary>
        /// Khóa phụ: Mã loại câu hỏi
        /// </summary>
        public Guid QuestionTypeID { get; set; }

        /// <summary>
        /// Tên câu hỏi
        /// </summary>
        public string QuestionName { get; set; }

        public string QuestionTypeName { get; set; }
        /// <summary>
        /// Mô tả
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// Hài lòng    
        /// </summary>
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

        /// <summary>
        /// Trạng thái
        /// </summary>
        public int QuestionSatus { get; set; }

        
        #endregion
    }
}
