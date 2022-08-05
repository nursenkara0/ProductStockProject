using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Entities.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.TotalPrice).IsRequired();
            entity.Property(e => e.ProductId).IsRequired();
            entity.Property(e => e.UserId).IsRequired();
        }
    }
}
