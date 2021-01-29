using System;
using System.Collections.Generic;
using System.Text;

namespace WebEnterprise.Data.Entities
{
    public class Comment
    {
        public long ID { set; get; }
        public long UserID { set; get; }
        public long DocumentID { set; get; }
        public long CreateOn { set; get; }
        public User User { get; set; }
    }
}
