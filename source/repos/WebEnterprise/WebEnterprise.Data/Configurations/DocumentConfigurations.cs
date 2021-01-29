using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebEnterprise.Data.Entities;

namespace WebEnterprise.Data.Configurations
{
    public class DocumentConfigurations : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Documents");
            builder.HasKey(x => new { x.ID });
            builder.Property(x => x.Name).IsRequired(true);
            builder.Property(x => x.UserID).IsRequired(true);
            builder.Property(x => x.DateFile).IsRequired(true);
            builder.Property(x => x.FileType).IsRequired(true);
            builder.Property(x => x.CreateOn).IsRequired(true);
            builder.HasOne(x => x.User).WithMany(x => x.Documents).HasForeignKey(x => x.UserID);
            builder.HasOne(x => x.Megazine).WithMany(x => x.Documents).HasForeignKey(x => x.ID);
        }
    }
}
