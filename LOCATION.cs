namespace SPTDataLayer.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOCATION")]
    public partial class LOCATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOCATION()
        {
            EMPL = new HashSet<EMPL>();
        }

        [Key]
        public int LOCATION_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string LOCATION_NM { get; set; }

        [Column(TypeName = "date")]
        public DateTime EFFECTIVE_DT { get; set; }

        public int DIST_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DELETE_DT { get; set; }

        public virtual DIST_GUIDELINES DIST_GUIDELINES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPL> EMPL { get; set; }
    }
}
