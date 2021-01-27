namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CommentID")]
    public partial class CommentID
    {
        public long ID { get; set; }

        [Required]
        [StringLength(500)]
        public string CContent { get; set; }

        public long CreateOn { get; set; }

        public long UserID { get; set; }

        public virtual User User { get; set; }
    }
}
