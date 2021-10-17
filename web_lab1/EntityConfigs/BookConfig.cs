using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using web_lab1.Entities;

namespace web_lab1.EntityConfigs
{
    internal class BookConfig: IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id).ValueGeneratedOnAdd();

            builder.HasMany<Sage>(b => b.Sages)
                .WithMany(s => s.Books)
                .UsingEntity(j => j.ToTable("SageBook"));
        }
    }
}
