using SchoolMon.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
    /// <summary>
    /// Đối tượng để chứa các kết quả trả về từ Service
    /// CreateBy: NVDuc 13.05.2021
    /// </summary>
    public class ServiceResult
    {
        /// <summary>
        /// Đối tượng chứa các thay đổi trong quá trình thực hiện nghiệp vụ hoặc các thông báo lỗi
        /// CreateBy: NVDuc 13.05.2021
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// Thông báo
        /// </summary>
        public string Messenger { get; set; }
        /// <summary>
        /// Mã lỗi tự định nghĩa
        /// </summary>
        public SchoolCode SchoolCode { get; set; }
    }
}
