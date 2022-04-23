using System;
using System.Threading.Tasks;
using Wishlist.Domain.Core;

namespace Wishlist.Domain.Product
{
    public interface IProductRepository
    {
        public Product ? GetProduct(Guid id);
    }
}
