namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIST_GUIDELINES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIST_GUIDELINES()
        {
            LOCATION = new HashSet<LOCATION>();
            PCT_INCREASE = new HashSet<PCT_INCREASE>();
            QUINTILE = new HashSet<QUINTILE>();
            SALARY_RANGE = new HashSet<SALARY_RANGE>();
        }

        [Key]
        public int DIST_GUIDE_ID { get; set; }

        public int COMPANY_CO { get; set; }

        public int OPERATION { get; set; }

        public int EMP_TYPE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AMOUNT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        public virtual COMPANY COMPANY { get; set; }

        public virtual EMPL_TYPE EMPL_TYPE { get; set; }

        public virtual OPERATION OPERATION1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOCATION> LOCATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PCT_INCREASE> PCT_INCREASE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUINTILE> QUINTILE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALARY_RANGE> SALARY_RANGE { get; set; }
    }
}
