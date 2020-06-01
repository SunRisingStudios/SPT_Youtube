using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.DatabaseEntities
{
    public class PctIncrease
    {
        public int PctIncreaseId { get; set; }
        public int Rating { get; set; }
        public int EmployeeStatus { get; set; }
        public int DistKey { get; set; }
        public int Quintile { get; set; }
        public decimal Minval { get; set; }
        public decimal MaxVal { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
