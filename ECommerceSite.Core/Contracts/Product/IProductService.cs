using EcommerceSite.Core.Models.Home;

namespace EcommerceSite.Core.Contracts.Product
{
    public interface IProductService
    {
        Task<IEnumerable<ProductIndexServiceModel>> ShowProducts();
    }
}
