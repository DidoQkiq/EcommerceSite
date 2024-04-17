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
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            var data = new SeedData();

            builder.HasData(new Brand[]
            {
                data.NikeBrand,
                data.AdidasBrand,
                data.AirJordanBrand,
                data.AsicsBrand,
                data.ConverseBrand,
                data.PumaBrand,
                data.ReebokBrand,
                data.VansBrand
            });
        }
    }
}
