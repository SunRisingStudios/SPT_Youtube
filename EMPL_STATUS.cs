namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPL_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPL_STATUS()
        {
            EMPL = new HashSet<EMPL>();
            PCT_INCREASE = new HashSet<PCT_INCREASE>();
            QUINTILE = new HashSet<QUINTILE>();
            SALARY_RANGE = new HashSet<SALARY_RANGE>();
        }

        [Key]
        public int EMPL_STATUS_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EMPL_STATUS_NM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPL> EMPL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PCT_INCREASE> PCT_INCREASE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUINTILE> QUINTILE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SALARY_RANGE> SALARY_RANGE { get; set; }
    }
}
