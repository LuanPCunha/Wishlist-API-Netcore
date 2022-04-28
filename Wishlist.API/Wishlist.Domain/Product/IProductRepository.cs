namespace Wishlist.Domain.Product
{
    public interface IProductRepository
    {
        public Product? GetProduct(Guid id);
    }
}
