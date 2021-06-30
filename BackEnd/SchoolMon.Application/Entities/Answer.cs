using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMon.Application.Entities
{
    public class Answer
    {
        public Guid id { get; set; }
        public int answer { get; set; }
        public string paragraph { get; set; }
        
    }
}
