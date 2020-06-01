namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUINTILE")]
    public partial class QUINTILE
    {
        [Key]
        public int QUINTILE_ID { get; set; }

        public int GRADE { get; set; }

        public int EMPL_STATUS { get; set; }

        public int DIST_KEY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Q1_VAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Q2_VAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Q3_VAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Q4_VAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Q5_VAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        public virtual DIST_GUIDELINES DIST_GUIDELINES { get; set; }

        public virtual EMPL_STATUS EMPL_STATUS1 { get; set; }
    }
}
