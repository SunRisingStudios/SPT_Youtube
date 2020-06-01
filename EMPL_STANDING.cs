namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPL_STANDING
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPL_STANDING()
        {
            EMPL = new HashSet<EMPL>();
        }

        [Key]
        public int EMPL_STANDING_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string EMPL_STANDING_NM { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPL> EMPL { get; set; }
    }
}
