using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMon.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entity> : ControllerBase
    {
        #region DECLARE
        IBaseService<Entity> _baseService;
        #endregion

        #region CONSTRUCTOR
        public BaseController(IBaseService<Entity> baseService)
        {
            _baseService = baseService;
        }
        #endregion

        /// <summary>
        /// Lấy danh sách đối tượng
        /// </summary>
        /// <returns>Danh sách</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _baseService.GetEntities();
            return Ok(entities);
        }

        /// <summary>
        /// Lấy danh sách đối tượng theo khóa chính
        /// </summary>
        /// <param name="id">Khóa chính của đối tượng</param>
        /// <returns>Đối tượng</returns>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var entity = _baseService.GetEntityById(id);
            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return StatusCode(204);
            }
        }

        /// <summary>
        /// Thêm đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng</param>
        /// <returns>Đối tượng mà service trả về</returns>
        [HttpPost]
        public IActionResult Post(Entity entity)
        {
            var serviceResult = _baseService.Add(entity);
            if (serviceResult.SchoolCode == Application.Enums.SchoolCode.IsValid)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }

        /// <summary>
        /// Sửa đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng</param>
        /// <returns>Đối tượng mà service trả về</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Entity entity)
        {
            var serviceResult = _baseService.Update(entity);
            if (serviceResult.SchoolCode == Application.Enums.SchoolCode.IsValid)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }

        /// <summary>
        /// Xóa đối tượng theo khóa chính
        /// </summary>
        /// <param name="id">Khóa chính của đối tượng</param>
        /// CreatedBy: nmhung(23/3/2021)
        /// <returns>Đối tượng mà service trả về</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var serviceResult = _baseService.Delete(id);
            if (serviceResult.SchoolCode == Application.Enums.SchoolCode.IsValid)
            {
                return Ok(serviceResult);
            }
            else
            {
                return BadRequest(serviceResult);
            }
        }
    }
}
