using System.Diagnostics.CodeAnalysis;
using Wishlist.Domain.Core;
using Wishlist.Domain.Extensions;

namespace Wishlist.Domain.Product
{
    public class Product : IEquatable<Product>
    {
        #region Atributos

        private string _nome;
        private decimal _valorDeVenda;

        #endregion

        #region Propriedades

        public Guid Id { get; private set; }

        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (value?.Length > 300)
                {
                    throw new DomainException(ExceptionCodes.NomeDoProdutoComMaisDe300Caracteres);
                }

                _nome = value;
            }
        }

        public decimal ValorDeVenda
        {
            get
            {
                return _valorDeVenda;
            }
            private set
            {
                var newValue = decimal.Round(value, 2, MidpointRounding.AwayFromZero);

                if (newValue.Size() > 12)
                {
                    throw new DomainException(ExceptionCodes.ValorDeVendaDoProdutoComMaisDe10Digitos);
                }

                _valorDeVenda = newValue;
            }

        }

        public string Imagem { get; private set; }

        #endregion

        private Product() { }

        public Product(Guid id, string title, string imagem, decimal price, decimal? reviewScore) 
        {
            Id = id;
           

            ValidarInformacoesObrigatorias();
        }

        public void Alterar(string nome, decimal valor, string imagem)
        {
            Nome = nome;
            ValorDeVenda = valor;
            Imagem = imagem;

            ValidarInformacoesObrigatorias();
        }

        private void ValidarInformacoesObrigatorias()
        {
            if (Id == Guid.Empty)
            {
                throw new DomainException(ExceptionCodes.IdDoProdutoNaoInformado);
            }

            if (string.IsNullOrEmpty(Nome))
            {
                throw new DomainException(ExceptionCodes.NomeDoProdutoNaoInformado);
            }

            if (ValorDeVenda <= 0)
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
