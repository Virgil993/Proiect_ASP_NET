using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Configurations
{
    public class DeveloperConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.Property(x => x.FirstName)
                .HasColumnType("nvarchar(70)")
                .HasMaxLength(70);
            builder.Property(x => x.LastName)
                .HasColumnType("nvarchar(70)")
                .HasMaxLength(70);
            builder.Property(x => x.Email)
                .HasColumnType("nvarchar(150)")
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
