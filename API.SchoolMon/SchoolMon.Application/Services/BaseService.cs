using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
    public class BaseService<Entity> : IBaseService<Entity> where Entity : BaseEntity
    {
        #region DECLARE
        IBaseRepository<Entity> _baseRepository;
        ServiceResult _serviceResult;
        #endregion

        #region Contructor
        public BaseService(IBaseRepository<Entity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult();
        }
        #endregion

        public IEnumerable<Entity> GetEntities()
        {
            return _baseRepository.GetEntities();
        }

        public Entity GetEntityById(Guid entityId)
        {
            return _baseRepository.GetEntityById(entityId);
        }

        public ServiceResult Add(Entity entity)
        {
            entity.EntityState = Enums.EntityState.AddNew;
            //Thực hiện validate
            var isValidate = Validate(entity);
            if (isValidate == true)
            {
                _serviceResult.Data = _baseRepository.Add(entity);
                _serviceResult.Messenger = Properties.Resources.msg_add;
                _serviceResult.SchoolCode = Enums.SchoolCode.IsValid;
                return _serviceResult;
            }
            else
            {
                return _serviceResult;
            }
        }

        public ServiceResult Delete(Guid entityId)
        {
            var rowAffect = _baseRepository.Delete(entityId);
            if (rowAffect > 0)
            {
                _serviceResult.Messenger = Properties.Resources.msg_delete;
                _serviceResult.Data = rowAffect;
                _serviceResult.SchoolCode = Enums.SchoolCode.IsValid;
                return _serviceResult;
            }
            else
            {
                _serviceResult.Messenger = Properties.Resources.msg_isNot;
                _serviceResult.Data = rowAffect;
                _serviceResult.SchoolCode = Enums.SchoolCode.NotValid;
                return _serviceResult;
            }
        }

        public ServiceResult Update(Entity entity)
        {
            entity.EntityState = Enums.EntityState.Update;
            var isValidate = Validate(entity);
            if (isValidate == true)
            {
                _serviceResult.Data = _baseRepository.Update(entity);
                _serviceResult.Messenger = Properties.Resources.msg_update;
                _serviceResult.SchoolCode = Enums.SchoolCode.IsValid;
                return _serviceResult;
            }
            else
            {
                return _serviceResult;
            }
        }

        /// <summary>
        /// Validate dữ liệu thuộc tính của entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private bool Validate(Entity entity)
        {
            //Khởi tạo mảng danh sách lỗi nếu có
            var mesArrayError = new List<string>();
            var isValidate = true;
            //Đọc các Property
            var properties = entity.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propertyValue = property.GetValue(entity);
                var displayName = string.Empty;
                var displayNameAttributes = property.GetCustomAttributes(typeof(DisplayName), true);
                if (displayNameAttributes.Length > 0)
                {
                    displayName = (displayNameAttributes[0] as DisplayName).Name;
                }
                //Kiểm tra xem có Attribute cần phải validate không:
                if (property.IsDefined(typeof(Required), false))
                {
                    //Check bắt buộc nhập:
                    if (propertyValue.ToString() == "")
                    {

                        isValidate = false;
                        mesArrayError.Add(string.Format(Properties.Resources.Msg_IsNO, displayName));
                        _serviceResult.SchoolCode = Enums.SchoolCode.NotValid;
                        _serviceResult.Messenger = Properties.Resources.Msg_IsNotValid;
                    }
                }
                if (property.IsDefined(typeof(CheckDuplicate), false))
                {
                    //Check trùng dữ liệu:
                    var propertyName = property.Name;
                    var entityDuplicate = _baseRepository.GetEntityByProperty(entity, property);
                    if (entityDuplicate != null)
                    {
                        isValidate = false;
                        mesArrayError.Add(string.Format(Properties.Resources.Msg_Duplicated, displayName));
                        _serviceResult.SchoolCode = Enums.SchoolCode.NotValid;
                        _serviceResult.Messenger = Properties.Resources.Msg_IsNotValid;
                    }
                }
                if (property.IsDefined(typeof(MaxLength), false))
                {
                    //Lấy độ dài đã khai báo
                    var attributeMaxLength = property.GetCustomAttributes(typeof(MaxLength), true)[0];
                    var length = (attributeMaxLength as MaxLength).Value;
                    var msg = (attributeMaxLength as MaxLength).ErrorMsg;
                    if (propertyValue.ToString().Trim().Length > length)
                    {
                        isValidate = false;
                        mesArrayError.Add(msg ?? string.Format(Properties.Resources.Msg_MaxLength, displayName, length));
                        _serviceResult.SchoolCode = Enums.SchoolCode.NotValid;
                        _serviceResult.Messenger = Properties.Resources.Msg_IsNotValid;
                    }
                }
            }
            _serviceResult.Data = mesArrayError;
            if (isValidate == true)
            {
                isValidate = ValidateEntity(entity);
            }
            return isValidate;
        }

        /// <summary>
        /// Hàm thực hiện kiểm tra dữ liệu/ Nghiệp vụ tùy chỉnh
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected virtual bool ValidateEntity(Entity entity)
        {
            return true;
        }
    }
}
