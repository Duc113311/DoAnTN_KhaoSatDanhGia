using Dapper;
using Microsoft.Extensions.Configuration;
using SchoolMon.Application.Entities;
using SchoolMon.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Infrastructure
{
   public class AccountRepo:BaseReponsitory<Account>,IAccountRepo
    {
        public AccountRepo(IConfiguration configuration) : base(configuration)
    {

    }

    public List<Children> GetFilter(string childrenName, string className)
    {
        var param = new DynamicParameters();
        param.Add("@ChildrenName", childrenName, DbType.String);
        param.Add("@ClassName", className, DbType.String);

        var values = _dbConnection.Query<Children>("Proc_GetFilter", param, commandType: CommandType.StoredProcedure).ToList();

        return values;
    }

        public Account Login(string userName, string password)
        {
            var param = new DynamicParameters();

            param.Add("@UserName", userName, DbType.String);
            param.Add("@PassWork", password, DbType.String);

            var values = _dbConnection.Query<Account>("Proc_Login", param, commandType: CommandType.StoredProcedure).FirstOrDefault();

            return values;
        }


    }
}
