using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Wishlist.Domain.Core;
using Wishlist.Domain.Product;
using Wishlist.Infrastructure.Persistence.Core;
using Wishlist.Infrastructure.Persistence.Extensions;

namespace Wishlist.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }


    }
}
