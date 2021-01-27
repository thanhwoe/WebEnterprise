namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Document")]
    public partial class Document
    {
        public long ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string FileType { get; set; }

        [Required]
        [StringLength(100)]
        public string DataFile { get; set; }

        public DateTime CreateOn { get; set; }

        public long UserID { get; set; }

        public virtual User User { get; set; }
    }
}
