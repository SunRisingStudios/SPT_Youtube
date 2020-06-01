
using SPTEntities.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.Models
{
    public class ManagerViewModel
    {
        public List<Employee> ManagersEmployees { get; set; }
        public List<DistributionGuideline> DistributionGuidelines { get; set; }
        public List<PctIncrease> PctIncreaseGuidelines { get; set; }
    }
}
