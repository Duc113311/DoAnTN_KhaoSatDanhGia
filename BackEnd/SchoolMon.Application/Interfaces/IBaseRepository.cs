using SchoolMon.Application.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Interfaces
{
    /// <summary>
    /// Interface chứa các phương thức tương tác với cơ sở dữ liệu
    /// CreateBy:NVDuc 12.05.2021
    /// </summary>
    public interface IBaseRepository<Entity>
    {
        /// <summary>
        /// Lấy toàn bộ danh sách entity
        /// </summary>
        /// <returns></returns>
        IEnumerable<Entity> GetEntities();

        /// <summary>
        /// Lấy entity theo id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        Entity GetEntityById(Guid entityId);

        /// <summary>
        /// Thêm mới entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Add(Entity entity);

        /// <summary>
        /// Cập nhật entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update(Entity entity);

        /// <summary>
        /// Xóa entity theo id
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        int Delete(Guid entityId);
    }
}
