using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.DatabaseEntities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
