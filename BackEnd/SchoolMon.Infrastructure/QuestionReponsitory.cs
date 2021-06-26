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
    public class QuestionReponsitory : BaseReponsitory<Question>, IQuestionReponsitory
    {
        public QuestionReponsitory(IConfiguration configuration) : base(configuration)
        {

        }

        public int DeleteQuestion(Guid questionId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@QuestionID", questionId, DbType.Guid);
           var rowAffect = _dbConnection.Execute($"Proc_DeleteQuestions", parameters, commandType: CommandType.StoredProcedure);
            return rowAffect;
        }

        public int DeleteAssets(string[] array)
        {
            var rowAffects = 0;
        
                try
                {
                    foreach (var id in array)
                    {
                        var parameter = new DynamicParameters();
                        parameter.Add($"{_tableName}Id", id, DbType.String);
                        rowAffects += _dbConnection.Execute($"Proc_Delete{_tableName}", parameter, commandType: CommandType.StoredProcedure);
                    }
                }
                catch (Exception ex)
                {
                Console.WriteLine(ex);
                }
            
            return rowAffects;
        }
    }
}
