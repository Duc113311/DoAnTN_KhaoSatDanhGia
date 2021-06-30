using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMon.Web.Controllers
{
 
    public class AccountController : BaseController<Account>
    {
        IAccountService _accountService;

        public AccountController(IAccountService accountService) : base(accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("filter")]
        
        public IActionResult Login([FromQuery] string userName, [FromQuery] string passWord)
        {
            var value = _accountService.Login(userName, passWord);
            
            return Ok(value);
          
        }
    }
}
