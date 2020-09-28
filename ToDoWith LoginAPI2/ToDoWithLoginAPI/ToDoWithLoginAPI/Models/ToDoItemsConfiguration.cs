using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoWithLoginAPI.Models
{
    public class ToDoItemsConfiguration :  IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
    {
        // Set configuration for entity
        builder.ToTable("TodoItems", "dbo");

        // Set key for entity
        builder.HasKey(p => p.Id);

        // Set configuration for columns

        builder.Property(p => p.Id).HasColumnType("bigint").IsRequired();
            builder.Property(p => p.Name).HasColumnType("nvarchar(50)");
            builder.Property(p => p.IsCompleted).HasColumnType("bit");
            // Columns with default value

            builder
                .Property(p => p.Id)
                .HasColumnType("bigint")
                .IsRequired()
                .ValueGeneratedNever();

            //.HasDefaultValueSql("NEXT VALUE FOR [Sequences].[Id]")


        }
    }
}
