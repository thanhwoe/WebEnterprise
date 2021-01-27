namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepartmentCategolory")]
    public partial class DepartmentCategolory
    {
        public long ID { get; set; }

        public long UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual User User { get; set; }
    }
}
