using EcommerceSite.Core.Contracts.Product;
using EcommerceSite.Core.Models.Home;

namespace EcommerceSite.Core.Services.Product
{
    public class ProductService : IProductService
    {
        public Task<IEnumerable<ProductIndexServiceModel>> ShowProducts()
        {
            throw new NotImplementedException();
        }
    }
}
