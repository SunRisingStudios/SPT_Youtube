using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.DatabaseEntities
{
    public class EmployeeStatus
    {
        public int EmployeeStatusId { get; set; }
        public string EmployeeStatusName { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
