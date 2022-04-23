using Wishlist.Domain.Core;

namespace Wishlist.Domain.Client
{
    public interface IClientRepository
    {
        void Save(Guid userId, Guid productId);
        Client GetProductByUser(Guid userId, Guid productId);
        void Remove(Client client);
        Pagination<Product.Product> GetWishList(Guid userId, int page = 0, int limit = 100);
    }
}
