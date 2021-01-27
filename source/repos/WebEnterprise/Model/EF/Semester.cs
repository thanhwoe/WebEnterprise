namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Semester")]
    public partial class Semester
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Semester()
        {
            SchoolYears = new HashSet<SchoolYear>();
        }

        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long DayTImeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolYear> SchoolYears { get; set; }

        public virtual SemesterDayTime SemesterDayTime { get; set; }
    }
}
