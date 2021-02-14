using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebLIbrary.DAL.Models;

namespace WebLIbrary.DAL.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.Name, x.Genre });
            builder.Property("Name").HasMaxLength(150).IsRequired();
            builder.Property("Author").HasMaxLength(20).IsRequired();
            builder.HasData(new Book() { Author = "Leha", Genre = "Action", ISBN = "123-123-123-123", Name = "Matesha", PageNumber = 123, CreatedAt = DateTime.UtcNow });

        }
    }
}
