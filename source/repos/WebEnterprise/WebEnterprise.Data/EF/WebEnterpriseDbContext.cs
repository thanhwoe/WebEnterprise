using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebEnterprise.Data.Configurations;
using WebEnterprise.Data.Entities;

namespace WebEnterprise.Data.EF
{
    public class WebEnterpriseDbContext : DbContext
    {
        public WebEnterpriseDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactConfigurations());
            modelBuilder.ApplyConfiguration(new CommentConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentCatelogoryConfigurations());
            modelBuilder.ApplyConfiguration(new DocumentConfigurations());
            modelBuilder.ApplyConfiguration(new GroupUserConfigurations());
            modelBuilder.ApplyConfiguration(new MagazineConfigurations());
            modelBuilder.ApplyConfiguration(new SchoolYearConfigurations());
            modelBuilder.ApplyConfiguration(new UserConfigurations());


            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Contact> Addresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<DepartmentCatelogory> DepartmentCatelogories { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<Megazine> Magazines { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }

    }
}
