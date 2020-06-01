using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.DatabaseEntities
{
    public class DistributionGuideline
    {
        public int DistributionGuideLineId { get; set; }
        public int CompmanyCode { get; set; }
        public int OperationId { get; set; }
        public int EmployeeType { get; set; }
        public string EmployeeTypeText { get; set; }
        public decimal? DistGuideAmt { get; set; }
        public decimal DistGuideTotal { get; set; }
        public decimal? AmtRemaning { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
