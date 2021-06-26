using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Services
{
    public class AccountService : BaseService<Account>, IAccountService
    {

        #region DECLARE
        IAccountRepo _accountRepo;
        #endregion

        #region CONSTRUCTOR
        public AccountService(IAccountRepo accountRepo, IBaseRepository<Account> baseRepository) : base(baseRepository)
        {
            _accountRepo = accountRepo;
        }
        #endregion

        #region fun

        public int Login(string userName, string passWord)
        {
            var value = _accountRepo.Login(userName, passWord);
            return value;
        }
        #endregion
    }
}
