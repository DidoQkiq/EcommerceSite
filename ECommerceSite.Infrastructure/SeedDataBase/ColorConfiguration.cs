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
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            var data = new SeedData();

            builder.HasData(new Color[]
            {
                data.BlueColor,
                data.GreenColor,
                data.RedColor,
            });
        }
    }
}
