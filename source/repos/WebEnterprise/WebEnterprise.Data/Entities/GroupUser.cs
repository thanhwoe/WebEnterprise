using System;
using System.Collections.Generic;
using System.Text;

namespace WebEnterprise.Data.Entities
{
    public class GroupUser
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public User User { get; set; }

    }
}
