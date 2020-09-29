using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWithLoginAPI.Models
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Set configuration for entity
            builder.ToTable("Users", "dbo");

            // Set key for entity
            builder.HasKey(p => p.Id);

            // Set configuration for columns

            builder.Property(p => p.Id).HasColumnType("bigint").IsRequired();
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            builder.Property(p => p.EmailAddress).HasColumnType("nvarchar(50)");
            builder.Property(p => p.PasswordHash).HasColumnType("nvarchar(50)");

            // Columns with default value

            //builder
            //    .Property(p => p.Id)
            //    .HasColumnType("bigint")
            //    .IsRequired()
            //.HasDefaultValueSql("NEXT VALUE FOR [Sequences].[Id]");
            builder
    .Property(p => p.Id)
    .HasColumnType("bigint")
    .IsRequired()
    .ValueGeneratedNever()
    .UseSqlServerIdentityColumn()
    .Metadata.BeforeSaveBehavior = PropertySaveBehavior.Ignore;



        }
    }
}
