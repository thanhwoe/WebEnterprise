using System;
using System.Collections.Generic;
using System.Text;

namespace WebEnterprise.Data.Entities
{
    public class DepartmentCatelogory
    {
        public long ID { set; get; }
        public long UserID { set; get; }
        public string Name { set; get; }
        public User User { get; set; }

    }
}
