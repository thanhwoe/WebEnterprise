using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebEnterprise.Data.Entities;

namespace WebEnterprise.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.FirstName).IsRequired(true);
            builder.Property(x => x.LastName).IsRequired(true);
            builder.Property(x => x.DateOfBirth).IsRequired(true);
            builder.Property(x => x.Sex).IsRequired(true);
            builder.Property(x => x.UserName).IsRequired(true);
            builder.Property(x => x.Password).IsRequired(true);
            builder.Property(x => x.ContactID);
            builder.Property(x => x.GroupUserID).IsRequired(true);
            builder.Property(x => x.CreateOn);
            builder.Property(x => x.SchoolYearID);
            builder.HasOne(x => x.DepartmentCatelogory).WithOne(x => x.User).HasForeignKey<DepartmentCatelogory>(x => x.UserID);
        }
    }
}
