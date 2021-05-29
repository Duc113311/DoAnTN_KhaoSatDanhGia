using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{

    /// <summary>
    /// Interface chứa các phương thức tương tác trong quá trình sử lý nghiệp vụ
    /// </summary>
    /// CreateBy: NVDuc 13.05.2021
    /// <typeparam name="Entity"></typeparam>
    public interface IBaseService<Entity>
    {
        /// <summary>
        /// Lấy danh sách entity
        /// </summary>
        /// CreateBy: NVDuc 13.05.2021
        /// <returns>danh sách entity</returns>
        IEnumerable<Entity> GetEntities();

        /// <summary>
        /// Lấy entity theo id
        /// </summary>
        /// CreateBy: NVDuc 13.05.2021
        /// <param name="entityId">id entity</param>
        /// <returns>entity</returns>
        Entity GetEntityById(Guid entityId);

        /// <summary>
        /// Thêm mới entity
        /// </summary>
        /// CreateBy: NVDuc 13.05.2021
        /// <param name="entity">Đối tượng</param>
        /// <returns>Đối tượng chứa các dữ liệu trả về</returns>
        /// 
        ServiceResult Add(Entity entity);
        /// <summary>
        /// Cập nhật entity
        /// </summary>
        /// CreateBy: NVDuc 13.05.2021
        /// <param name="entity">Đối tượng</param>
        /// <returns>Đối tượng chứa các dữ liệu trả về</returns>
        ServiceResult Update(Entity entity);
        /// <summary>
        /// Xóa bỏ entity
        /// </summary>
        /// CreateBy: NVDuc 13.05.2021
        /// <param name="entityId">mã đối tượng</param>
        /// <returns>Đối tượng chứa các dữ liệu trả về</returns>
        ServiceResult Delete(Guid entityId);
    }
}
