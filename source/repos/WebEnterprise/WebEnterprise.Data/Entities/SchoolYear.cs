using System;
using System.Collections.Generic;
using System.Text;

namespace WebEnterprise.Data.Entities
{
    public class SchoolYear
    {
        public int ID { set; get; }
        public DateTime StartDayYear { set; get; }
        public DateTime EndDayYear { set; get; }
        public User User { get; set; }

    }
}
