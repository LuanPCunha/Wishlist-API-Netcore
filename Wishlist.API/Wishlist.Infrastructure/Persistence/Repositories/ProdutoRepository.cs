using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Wishlist.Domain.Core;
using Wishlist.Domain.Product;
using Wishlist.Infrastructure.Persistence.APIResults;
using Wishlist.Infrastructure.Persistence.Core;
using Wishlist.Infrastructure.Persistence.Extensions;

namespace Wishlist.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;
        private readonly HttpClient _httpClient;

        public ProductRepository(Context context, HttpClient httpClient)
        {
            _context = context;
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
