using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
   public class Children:BaseEntity
    {
        public Guid ChildrenID { get; set; }

        public Guid IDClassChildren { get; set; }

        public string ChildrenName { get; set; }

        public int ChildrenAge { get; set; }

        public string NickName { get; set; }

        public string Interest { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string ParentName { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }

        public string ImageChildren { get; set; }

        public string ImageParent { get; set; }
    }
}
