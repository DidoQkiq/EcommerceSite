using ECommerceSite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceSite.Infrastructure.SeedDataBase
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            SeedData data = new SeedData();

            builder.HasData(new Product[]
            {
                data.FirstProduct,
                data.SecondProduct,
                data.ThirdProduct,
            });
        }
    }
}
