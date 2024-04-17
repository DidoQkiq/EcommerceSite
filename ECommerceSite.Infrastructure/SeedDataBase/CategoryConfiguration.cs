using ECommerceSite.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceSite.Infrastructure.SeedDataBase
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[] 
            {
                data.SneakersCategory,
                data.BasketballShoesCategory,
                data.RunningShoesCategory,
                data.SlippersCategory,
                data.WinterShoesCategory
            });
        }
    }
}
