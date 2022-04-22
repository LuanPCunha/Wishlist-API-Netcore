using System.Diagnostics.CodeAnalysis;

namespace Wishlist.Domain.UserProductList
{
    public class UserProductList : IEquatable<UserProductList>
    {
        #region Propriedades

        public Guid UserId { get; private set; }

        public Guid ProductId { get; private set; }


        #endregion

        private UserProductList() { }

        public UserProductList(Guid userId, Guid productId)
        {
            UserId = userId;
            ProductId = productId;
        }

        public bool Equals([AllowNull] UserProductList objeto)
        {
            if (objeto is UserProductList || objeto == null)
            {
                return false;
            }

            return objeto.UserId == UserId && objeto.ProductId == ProductId;
        }
    }
}
