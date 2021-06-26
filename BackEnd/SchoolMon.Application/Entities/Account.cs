using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
   public class Account: BaseEntity
    {
        public Guid AccountID { get; set; }

        public string UserName { get; set; }

        public string PassWork { get; set; }

        public string AccountName { get; set; }

        public int Role { get; set; }
    }
}
