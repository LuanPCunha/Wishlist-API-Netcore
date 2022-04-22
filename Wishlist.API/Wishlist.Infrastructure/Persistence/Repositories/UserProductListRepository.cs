
using Wishlist.Infrastructure.Persistence.Core;

using Wishlist.Domain.UserProductList;

namespace Wishlist.Infrastructure.Persistence.Repositories
{
    public class UserProductListRepository : IUserProductListRepository
    {

        private readonly Context _context;


        public UserProductListRepository(Context context)
        {
            _context = context;
        }



    }
}
