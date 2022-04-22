using System.Diagnostics.CodeAnalysis;
using Wishlist.Domain.Core;
using Wishlist.Domain.Extensions;

namespace Wishlist.Domain.Product
{
    public class Product : IEquatable<Product>
    {

        #region Propriedades

        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public string Image { get; private set; }

        public decimal Price { get; private set; }

        public decimal ReviewScore { get; private set; }


        #endregion

        private Product() { }

        public Product(Guid id, string title, string imagem, decimal price, decimal? reviewScore)
        {
            Id = id;
            Title = title;
            Image = imagem;
            Price = price;
            ReviewScore = reviewScore.Value;

            Validate();
        }

        //public void Alterar(string title, string imagem, decimal price, decimal? reviewScore)
        //{
        //    Title = title;
        //    Image = imagem;
        //    Price = price;
        //    ReviewScore = reviewScore.Value;

        //    Validate();
        //}

        private void Validate()
        {
            if (Id == Guid.Empty)
            {
                throw new DomainException(ExceptionCodes.IdDoProdutoNaoInformado);
            }

            if (string.IsNullOrEmpty(Title))
            {
                throw new DomainException(ExceptionCodes.NomeDoProdutoNaoInformado);
            }

            if (string.IsNullOrEmpty(Image))
            {
                throw new DomainException(ExceptionCodes.NomeDoProdutoNaoInformado);
            }

            if (Price <= 0)
            {
                throw new DomainException(ExceptionCodes.ValorDeVendaDoProdutoNegativa);
            }

            if (ReviewScore <= 0)
            {
                throw new DomainException(ExceptionCodes.ValorDeVendaDoProdutoNegativa);
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
