using System;
using System.Collections.Generic;
using System.Text;

namespace WebEnterprise.Data.Entities
{
    public class User
    {
        public long ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public bool Sex { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public long ContactID { set; get; }
        public int GroupUserID { set; get; }
        public DateTime CreateOn { set; get; }
        public int SchoolYearID { set; get; }
        public List<Comment> Comments { get; set; }
        public List<Document> Documents { get; set; }
        public Contact Contact { get; set; }
        public GroupUser GroupUser { get; set; }
        public SchoolYear SchoolYear { get; set; }
        public DepartmentCatelogory DepartmentCatelogory { get; set; }

    }
}
