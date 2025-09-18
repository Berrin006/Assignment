using Infrastracture0918.Models;

namespace Infrastracture0918.Interfaces;

public interface IProductService
{
    ProductResult AddProductToList(Product product);

    ProductResult<IEnumerable<Product>> GetAllProducts();
}
