using System;
using System.Threading.Tasks;
using Wishlist.Domain.Core;

namespace Wishlist.Domain.Product
{
    public interface IProductRepository : IDisposable
    {
        Product ObterPorId(Guid id);

        Pagination<Product> Pesquisar(string nome, int page = 0, int limit = 100);

        void Adicionar(Product product);

        void Alterar(Product product);

        void Remover(Product product);

    }
}
