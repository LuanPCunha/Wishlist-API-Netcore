using Microsoft.EntityFrameworkCore;
using Wishlist.Infrastructure.Persistence.Core;
using Wishlist.Domain.Client;
using Wishlist.Domain.Core;
using Wishlist.Infrastructure.Persistence.Extensions;
using Wishlist.Domain.Product;

namespace Wishlist.Infrastructure.Persistence.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;
        private readonly IProductRepository _productRepository;

        public ClientRepository(Context context, IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public void Save(Guid userId, Guid productId)
        {
            var client = new Client(userId, productId);

            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public Client GetProductByUser(Guid userId, Guid productId)
        {
            return _context.Clients.AsNoTracking().FirstOrDefault(p => p.Id == userId && p.ProductId == productId);
        }

        public void Remove(Client client)
        {
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }

        public Pagination<Product> GetWishList(Guid userId, int page = 0, int limit = 100)
        {
            var wishList = new List<Product>();

            var query = _context.Clients.AsNoTracking();

            if (userId != Guid.Empty)
            {
                query = query.Where(p => p.Id == userId);
            }

            foreach (var product in query.ToList())
            {
                wishList.Add(_productRepository.GetProduct(product.ProductId));
            }

            var queryable = wishList.AsQueryable();
            return queryable.Paginate(page, limit);
        }

    }
}
