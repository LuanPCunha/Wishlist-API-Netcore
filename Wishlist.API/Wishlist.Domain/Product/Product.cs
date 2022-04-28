using System.Diagnostics.CodeAnalysis;
using Wishlist.Domain.Core;

namespace Wishlist.Domain.Product
{
    public class Product : IEquatable<Product>
    {
        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public string Image { get; private set; }

        public float Price { get; private set; }

        public float? ReviewScore { get; private set; }


        private Product() { }

        public Product(Guid id, string title, string imagem, float price, float? reviewScore)
        {
            Id = id;
            Title = title;
            Image = imagem;
            Price = price;
            ReviewScore = reviewScore;

            Validate();
        }

        private void Validate()
        {
            if (Id == Guid.Empty)
            {
                throw new DomainException(ExceptionCodes.ProductIdNotInformed);
            }

            if (string.IsNullOrEmpty(Title))
            {
                throw new DomainException(ExceptionCodes.ProductTitleNotInformed);
            }

            if (string.IsNullOrEmpty(Image))
            {
                throw new DomainException(ExceptionCodes.ProductImageNotInformed);
            }

            if (Price <= 0)
            {
                throw new DomainException(ExceptionCodes.ProductPriceNotInformed);
            }

            if (ReviewScore != null && ReviewScore < 0)
            {
                throw new DomainException(ExceptionCodes.ProductReviewScoreNotInformed);
            }
        }

        public bool Equals([AllowNull] Product objeto)
        {
            if (objeto is Product || objeto == null)
            {
                return false;
            }

            return objeto.Id == Id;
        }
    }
}
