using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Wishlist.Infrastructure.Persistence.Core;
using Wishlist.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using NSubstitute;
using NUnit.Framework;
using Wishlist.Domain.Product;

namespace Wishlist.Tests
{
    public class QueryTests 
    {
        private IProductRepository _sut;
        private Context _context;

        //public QueryTests()
        //{
        //    var options = new DbContextOptionsBuilder<Context>()
        //        .UseInMemoryDatabase(databaseName: "Database")
        //        .Options;

        //    _context = new Context(options);
            
        //    _context.Produtos.Add(new Produto(Guid.NewGuid(), "Chocolate", 3, null));
        //    _context.Produtos.Add(new Produto(Guid.NewGuid(), "Cebola", 2, null));
        //    _context.SaveChanges();

        //    _sut = new ProdutoRepository(_context); 
        //}

        //[Test]
        //public void Retornar_todos_os_registros()
        //{
        //    // When
        //    var resultado = _sut.Pesquisar(null);

        //    // Then
        //    resultado.Itens.Count().Should().Be(2);
        //}
        
        //[Test]
        //public void Retornar_um_determinado_registro_filtrando_por_parte_do_nome()
        //{
        //    // When
        //    var resultado = _sut.Pesquisar("Ce");

        //    // Then
        //    resultado.Itens.Count().Should().Be(1);
        //    resultado.Itens.ElementAt(0).Nome.Should().Be("Cebola");
        //}
        
        //[Test]
        //public void Retornar_um_determinado_registro_filtrando_por_parte_do_nome_porem_ignorando_as_letras_maiusculas()
        //{
        //    // When
        //    var resultado = _sut.Pesquisar("ce");

        //    // Then
        //    resultado.Itens.Count().Should().Be(1);
        //    resultado.Itens.ElementAt(0).Nome.Should().Be("Cebola");
        //}
        
        //[Test]
        //public void Retornar_um_determinado_registro_filtrando_por_parte_do_interna_do_nome()
        //{
        //    // When
        //    var resultado = _sut.Pesquisar("co");

        //    // Then
        //    resultado.Itens.Count().Should().Be(1);
        //    resultado.Itens.ElementAt(0).Nome.Should().Be("Chocolate");
        //}
        
        //[Test]
        //public void Retornar_os_registros_ordenados_por_nome_em_ordem_crescente()
        //{
        //    // When
        //    var resultado = _sut.Pesquisar(null);

        //    // Then
        //    resultado.Itens.ElementAt(0).Nome.Should().Be("Cebola");
        //    resultado.Itens.ElementAt(1).Nome.Should().Be("Chocolate");
        //}
    }
}