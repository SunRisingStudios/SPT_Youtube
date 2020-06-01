namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPL")]
    public partial class EMPL
    {
        [Key]
        public int EMPL_ID { get; set; }

        [Required]
        [StringLength(11)]
        public string EMPL_NO { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [Column(TypeName = "date")]
        public DateTime BIRTHDATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime HIRE_DT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? REHIRE_DT { get; set; }

        public int OPERATION { get; set; }

        [StringLength(100)]
        public string JOB_TITLE { get; set; }

        public int FULL_PART_TIME { get; set; }

        public int COMPANY_CO { get; set; }

        public int LOCATION { get; set; }

        public int STD_HOURS { get; set; }

        public int GRADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ANNUAL_RT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HOURLY_RT { get; set; }

        [Required]
        [StringLength(11)]
        public string REPORTS_TO_ID { get; set; }

        public int? LAST_RATING { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_REVIEW_DT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NEXT_REVIEW_DT { get; set; }

        public int? NEW_RATING { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? INCREASE_AMT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LAST_UPDATED_DT { get; set; }

        public int EMPL_STANDING { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        public int EMPL_TYPE { get; set; }

        public virtual COMPANY COMPANY { get; set; }

        public virtual EMPL_STANDING EMPL_STANDING1 { get; set; }

        public virtual EMPL_STATUS EMPL_STATUS { get; set; }

        public virtual EMPL_TYPE EMPL_TYPE1 { get; set; }

        public virtual LOCATION LOCATION1 { get; set; }

        public virtual OPERATION OPERATION1 { get; set; }
    }
}
