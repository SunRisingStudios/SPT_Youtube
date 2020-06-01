namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMPANY")]
    public partial class COMPANY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPANY()
        {
            DIST_GUIDELINES = new HashSet<DIST_GUIDELINES>();
            EMPL = new HashSet<EMPL>();
        }

        [Key]
        public int COMPANY_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string COMPANY_NM { get; set; }

        [Column(TypeName = "date")]
        public DateTime EFFECTIVE_DT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIST_GUIDELINES> DIST_GUIDELINES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPL> EMPL { get; set; }
    }
}
