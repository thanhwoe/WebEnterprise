using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebEnterprise.Data.Entities;

namespace WebEnterprise.Data.Configurations
{
    public class SchoolYearConfigurations : IEntityTypeConfiguration<SchoolYear>
    {
        public void Configure(EntityTypeBuilder<SchoolYear> builder)
        {
            builder.ToTable("SchoolYears");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.StartDayYear).IsRequired(true);
            builder.Property(x => x.EndDayYear).IsRequired(true);
            builder.HasOne(x => x.User).WithOne(x => x.SchoolYear).HasForeignKey<User>(x => x.SchoolYearID);
        }
    }
}
