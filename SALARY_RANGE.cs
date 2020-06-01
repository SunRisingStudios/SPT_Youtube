namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SALARY_RANGE
    {
        [Key]
        public int SALARY_RANGE_ID { get; set; }

        public int GRADE { get; set; }

        public int STATUS { get; set; }

        public int DIST_KEY { get; set; }

        public int QUINTILE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MIN_VAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MAX_VAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        public virtual DIST_GUIDELINES DIST_GUIDELINES { get; set; }

        public virtual EMPL_STATUS EMPL_STATUS { get; set; }
    }
}
