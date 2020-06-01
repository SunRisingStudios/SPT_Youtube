namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPL_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPL_TYPE()
        {
            DIST_GUIDELINES = new HashSet<DIST_GUIDELINES>();
            EMPL = new HashSet<EMPL>();
        }

        [Key]
        public int EMPL_TYPE_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EMPL_TYPE_CD { get; set; }

        [Required]
        [StringLength(100)]
        public string EMPL_TYPE_NM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIST_GUIDELINES> DIST_GUIDELINES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPL> EMPL { get; set; }
    }
}
