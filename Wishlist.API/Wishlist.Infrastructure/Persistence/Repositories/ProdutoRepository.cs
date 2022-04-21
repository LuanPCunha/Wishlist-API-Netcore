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

        public Product ObterPorId(Guid id)
        {
            return _context.Products.AsNoTracking().FirstOrDefault(p => p.Id == id);
        }

        public Pagination<Product> Pesquisar(string nome, int pagina = 1, int limite = 100)
        {
            var query = _context.Products.AsNoTracking();

            if (!string.IsNullOrEmpty(nome))
            {
                query = query.Where(p => p.Nome.ToUpper().Contains(nome.ToUpper()));
            }

            return query.OrderBy(p => p.Nome).Paginate<Product>(pagina, limite);
        }

        public void Adicionar(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Alterar(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void Remover(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
