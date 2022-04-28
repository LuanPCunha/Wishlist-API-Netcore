using Newtonsoft.Json;
using Wishlist.Domain.Product;
using Wishlist.Infrastructure.Persistence.APIResults;

namespace Wishlist.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly HttpClient _httpClient;

        public ProductRepository(HttpClient httpClient)
        {

            _httpClient = httpClient;
        }

        public Product? GetProduct(Guid id)
        {
            var response = _httpClient.GetAsync($"product/{id}/");

            var productResponse = response.GetAwaiter().GetResult().Content.ReadAsStringAsync().GetAwaiter().GetResult();

            var productResult = JsonConvert.DeserializeObject<ProductResult>(productResponse);

            return new Product(Guid.Parse(productResult.id), productResult.title, productResult.image, productResult.price, productResult.reviewScore);

        }

    }
}
