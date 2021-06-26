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
           
            //Thực hiện validate
            
                _serviceResult.Data = _baseRepository.Add(entity);
                _serviceResult.Messenger = Properties.Resources.msg_add;
                _serviceResult.SchoolCode = Enums.SchoolCode.IsValid;
                return _serviceResult;
            
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
      
                _serviceResult.Data = _baseRepository.Update(entity);
                _serviceResult.Messenger = Properties.Resources.msg_update;
                _serviceResult.SchoolCode = Enums.SchoolCode.IsValid;
                return _serviceResult;
           
        }

    
      
    }
}
