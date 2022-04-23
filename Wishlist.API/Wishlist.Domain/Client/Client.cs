using System.Diagnostics.CodeAnalysis;
using Wishlist.Domain.Core;

namespace Wishlist.Domain.Client
{
    public class Client : IEquatable<Client>
    {

        #region Propriedades

        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        #endregion

        private Client() { }

        public Client(Guid userId, Guid productId)
        {
            Id = userId;
            ProductId = productId;
        }

        public bool Equals([AllowNull] Client objeto)
        {
            if (objeto is Client || objeto == null)
            {
                return false;
            }

            return objeto.Id == Id;
        }
    }
}
