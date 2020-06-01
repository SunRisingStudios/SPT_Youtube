using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.DatabaseEntities
{
    public class EmployeeType
    {
        public int EmployeeTypeId { get; set; }
        public string EmployeeTypeCode { get; set; }
        public string EmployeeTypeText { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
