using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTEntities.DatabaseEntities
{
    public class Quintile
    {
        public int QuintileId { get; set; }
        public int Grade { get; set; }
        public int EmplStatus { get; set; }
        public int DistKey { get; set; }
        public decimal Q1Val { get; set; }
        public decimal Q2Val { get; set; }
        public decimal Q3Val { get; set; }
        public decimal Q4Val { get; set; }
        public decimal Q5Val { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
