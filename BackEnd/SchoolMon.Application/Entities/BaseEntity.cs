using SchoolMon.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
    /// <summary>
    /// Hiển thị tên thuộc tính
    /// CreateBy: NVDuc 29.03.2021
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DisplayName : Attribute
    {
        public string Name { get; set; }

        public DisplayName(string name = null)
        {
            this.Name = name;
        }
    }

    /// <summary>
    /// Check khóa chính
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKey : Attribute
    {

    }

    /// <summary>
    /// Bắt buộc nhập
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]

    public class Required : Attribute
    {

    }

    /// <summary>
    /// Check trùng dữ liệu
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CheckDuplicate : Attribute
    {

    }

    /// <summary>
    /// Lớp xác định độ dài tối đa của thuộc tính đối tượng
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class MaxLength : Attribute
    {
        public int Value { get; set; }
        public string ErrorMsg { get; set; }
        public MaxLength(int length, string erroMsg = null)
        {
            this.Value = length;
            this.ErrorMsg = erroMsg;
        }
    }

    /// <summary>
    /// Class chứa các thuộc tính chung nhất mà mọi đối tượng kế thừa
    /// </summary>
    public class BaseEntity
    {
        #region Properties

        /// <summary>
        /// Trạng thái của đối tượng
        /// </summary>

        /// <summary>
        /// Người tạo
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Ngày tạo
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người sửa
        /// </summary>
        public string? ModifiledBy { get; set; }

        /// <summary>
        /// Ngày sửa
        /// </summary>
        public DateTime? ModifiledDate { get; set; }

        #endregion 
    }
}
