using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebEnterprise.Data.Entities;

namespace WebEnterprise.Data.Configurations
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(x => new { x.ID });
            builder.Property(x => x.DocumentID).IsRequired(true);
            builder.Property(x => x.UserID).IsRequired(true);
            builder.Property(x => x.CreateOn).IsRequired(true);
            builder.HasOne(x => x.User).WithMany(x => x.Comments).HasForeignKey(x => x.UserID);
        }
    }
}
