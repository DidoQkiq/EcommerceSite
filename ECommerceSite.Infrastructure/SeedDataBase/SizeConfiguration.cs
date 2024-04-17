using ECommerceSite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSite.Infrastructure.SeedDataBase
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            var data = new SeedData();

            builder.HasData(new Size[]
            {
                data.FirstSize,
                data.SecondSize,
                data.ThirdSize,
            });
        }
    }
}
