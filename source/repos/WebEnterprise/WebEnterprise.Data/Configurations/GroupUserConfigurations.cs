using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebEnterprise.Data.Entities;

namespace WebEnterprise.Data.Configurations
{
    public class GroupUserConfigurations : IEntityTypeConfiguration<GroupUser>
    {
        public void Configure(EntityTypeBuilder<GroupUser> builder)
        {
            builder.ToTable("GroupUsers");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired(true);
            builder.HasOne(x => x.User).WithOne(x => x.GroupUser).HasForeignKey<User>(x => x.GroupUserID);
        }
    }
}
