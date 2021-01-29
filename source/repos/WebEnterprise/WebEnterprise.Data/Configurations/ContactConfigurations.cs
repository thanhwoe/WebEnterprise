using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebEnterprise.Data.Entities;

namespace WebEnterprise.Data.Configurations
{
    public class ContactConfigurations : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ApartmentNumber).IsRequired(true);
            builder.Property(x => x.NameStreet).IsRequired(true);
            builder.Property(x => x.Email).IsRequired(true);
            builder.Property(x => x.Image);
            builder.Property(x => x.NumberPhone);
            builder.HasOne(x => x.User).WithOne(x => x.Contact).HasForeignKey<User>(x => x.ContactID);
        }
    }
}
