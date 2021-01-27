namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Comment")]
    public partial class Comment
    {
        public long ID { get; set; }

        public long? UserID { get; set; }

        public long? DocumentID { get; set; }

        public DateTime? CreateOn { get; set; }

        public virtual User User { get; set; }
    }
}
