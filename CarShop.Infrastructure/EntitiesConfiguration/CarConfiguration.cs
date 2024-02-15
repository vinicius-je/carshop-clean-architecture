using CarShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Infrastructure.EntitiesConfiguration
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder) 
        {
            builder.HasKey(c => c.CarId);
            builder.Property(c => c.ImageLink).IsRequired();
            builder.Property(c => c.Name).HasMaxLength(150).IsRequired();
            builder.Property(c => c.Price).IsRequired();
            builder.Property(p => p.Category).IsRequired();
            builder.Property(p => p.Brand).IsRequired();

        }
    }
}
