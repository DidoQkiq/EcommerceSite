using ECommerceSite.Infrastructure.Data.Models;

namespace ECommerceSite.Infrastructure.SeedDataBase
{
    public class SeedData
    {
        public Brand NikeBrand { get; set; }
        public Brand AdidasBrand { get; set; }
        public Brand PumaBrand { get; set; }
        public Brand AirJordanBrand { get; set; }
        public Brand ReebokBrand { get; set; }
        public Brand AsicsBrand { get; set; }
        public Brand ConverseBrand { get; set; }
        public Brand VansBrand { get; set; }

        public Category SneakersCategory { get; set; }
        public Category WinterShoesCategory { get; set; }
        public Category RunningShoesCategory { get; set; }
        public Category BasketballShoesCategory { get; set; }
        public Category SlippersCategory { get; set; }

        public Color RedColor { get; set; }
        public Color BlueColor { get; set; }
        public Color GreenColor { get; set; }

        public Size FirstSize { get; set; }
        public Size SecondSize { get; set; }
        public Size ThirdSize { get; set; }

        public Product FirstProduct { get; set; }
        public Product SecondProduct { get; set; }
        public Product ThirdProduct { get; set; }

        public SeedData()
        {
            SeedCategories();
            SeedBrands();
            SeedColors();
            SeedSizes();
            SeedProducts();
        }


        public void SeedCategories()
        {
            SneakersCategory = new Category()
            {
                Id = 1,
                Name = "Sneakers"
            };

            WinterShoesCategory = new Category()
            {
                Id = 2,
                Name = "Winter Shoes"
            };

            RunningShoesCategory = new Category()
            {
                Id = 3,
                Name = "Running Shoes"
            };

            BasketballShoesCategory = new Category()
            {
                Id = 4,
                Name = "Basketball Shoes"
            };

            SlippersCategory = new Category()
            {
                Id = 5,
                Name = "Slippers"
            };

        }

        public void SeedBrands()
        {
            NikeBrand = new Brand()
            {
                Id = 1,
                Name = "Nike"
            };
            AdidasBrand = new Brand()
            {
                Id = 2,
                Name = "Adidas"
            };
            PumaBrand = new Brand()
            {
                Id = 3,
                Name = "Puma"
            };
            AirJordanBrand = new Brand()
            {
                Id = 4,
                Name = "Air Jordan"
            };
            ReebokBrand = new Brand()
            {
                Id = 5,
                Name = "Reebok"
            };
            AsicsBrand = new Brand()
            {
                Id = 6,
                Name = "Asics"
            };
            ConverseBrand = new Brand()
            {
                Id = 7,
                Name = "Converse"
            };
            VansBrand = new Brand()
            {
                Id = 8,
                Name = "Vans"
            };
        }

        public void SeedColors()
        {
            RedColor = new Color()
            {
                Id = 1,
                ShoeColor = "Red"
            };

            BlueColor = new Color()
            {
                Id = 2,
                ShoeColor = "Blue"
            };

            GreenColor = new Color()
            {
                Id = 3,
                ShoeColor = "Green"
            };
        }

        public void SeedSizes()
        {
            FirstSize = new Size()
            {
                Id = 1,
                ShoeSize = 42
            };
            SecondSize = new Size()
            {
                Id = 2,
                ShoeSize = 43
            };
            ThirdSize = new Size()
            {
                Id = 3,
                ShoeSize = 44
            };
        }

        public void SeedProducts()
        {
            FirstProduct = new Product()
            {
                Id = 1,
                Title = "Nike Air Force 1",
                Price = 219,
                Description = "Nike Air Force Low is one of the best shoesh to be made",
                Quantity = 7,
                CategoryId = SneakersCategory.Id,
                ColorId = RedColor.Id,
                SizeId = ThirdSize.Id,
                BrandId = NikeBrand.Id,
            };

            SecondProduct = new Product()
            {
                Id = 2,
                Title = "Adidas Gazelle",
                Price = 259,
                Description = "Adidas Gazelle keeps the simple design more than 30 years",
                Quantity = 4,
                CategoryId = SneakersCategory.Id,
                ColorId = BlueColor.Id,
                SizeId = FirstSize.Id,
                BrandId = AdidasBrand.Id,
            };

            ThirdProduct = new Product()
            {
                Id = 3,
                Title = "Puma x RIPNDIP Tuff Plus",
                Price = 84,
                Description = "Puma x RIPNDIP Tuff Plus is a new design for slippers very light and cool",
                Quantity = 20,
                CategoryId = SneakersCategory.Id,
                ColorId = GreenColor.Id,
                SizeId = SecondSize.Id,
                BrandId = PumaBrand.Id,
            };
        }
    }
}
