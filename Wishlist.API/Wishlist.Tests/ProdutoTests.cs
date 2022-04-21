using System;
using Wishlist.Tests.Core;
using NUnit.Framework;
using AutoFixture;
using FluentAssertions;
using Wishlist.Domain.Core;

namespace Wishlist.Tests
{
    public class ProdutoTests : BaseTests
    {
        //[Test]
        //public void Criar_um_produto_com_sucesso()
        //{
        //    // Given
        //    var id = Fixture.Create<Guid>();
        //    var nome = new string('*', 50);
        //    var valor = Fixture.Create<decimal>();

        //    // When
        //    var produto = new Produto(id, nome, valor, null);

        //    // Then
        //    produto.Id.Should().Be(id);
        //    produto.Nome.Should().Be(nome);
        //    produto.ValorDeVenda.Should().Be(valor);
        //    produto.Imagem.Should().BeNull();
        //}

        //[Test]
        //public void Ao_criar_um_produto_sem_informar_o_id_uma_excecao_deve_ser_lancada()
        //{
        //    // Given
        //    var id = Guid.Empty;
        //    var nome = new string('*', 50);
        //    var valor = Fixture.Create<decimal>();

        //    // When
        //    Action act = () => new Produto(id, nome, valor, null);

        //    // Then
        //    act.Should()
        //        .Throw<DomainException>()
        //        .WithMessage(ExceptionCodes.IdDoProdutoNaoInformado);
        //}

        //[Test]
        //public void Ao_criar_um_produto_sem_informar_o_nome_uma_excecao_deve_ser_lancada()
        //{
        //    // Given
        //    var id = Fixture.Create<Guid>();
        //    var nome = string.Empty;
        //    var valor = Fixture.Create<decimal>();

        //    // When
        //    Action act = () => new Produto(id, nome, valor, null);

        //    // Then
        //    act.Should()
        //        .Throw<DomainException>()
        //        .WithMessage(ExceptionCodes.NomeDoProdutoNaoInformado);
        //}

        //[Test]
        //public void Ao_criar_um_produto_informando_um_nome_com_mais_de_300_caracteres_uma_excecao_deve_ser_lancada()
        //{
        //    // Given
        //    var id = Fixture.Create<Guid>();
        //    var nome = new string('*', 500);
        //    var valor = Fixture.Create<decimal>();

        //    // When
        //    Action act = () => new Produto(id, nome, valor, null);

        //    // Then
        //    act.Should()
        //        .Throw<DomainException>()
        //        .WithMessage(ExceptionCodes.NomeDoProdutoComMaisDe300Caracteres);
        //}

        //[Test]
        //public void Ao_criar_um_produto_sem_informar_o_valor_de_venda_uma_excecao_deve_ser_lancada()
        //{
        //    // Given
        //    var id = Fixture.Create<Guid>();
        //    var nome = new string('*', 50);
        //    var valor = 0;

        //    // When
        //    Action act = () => new Produto(id, nome, valor, null);

        //    // Then
        //    act.Should()
        //        .Throw<DomainException>()
        //        .WithMessage(ExceptionCodes.ValorDeVendaDoProdutoNegativa);
        //}

        //[Test]
        //public void Ao_criar_um_produto_informando_um_valor_de_venda_negativo_uma_excecao_deve_ser_lancada()
        //{
        //    // Given
        //    var id = Fixture.Create<Guid>();
        //    var nome = new string('*', 50);
        //    var valor = -3;

        //    // When
        //    Action act = () => new Produto(id, nome, valor, null);

        //    // Then
        //    act.Should()
        //        .Throw<DomainException>()
        //        .WithMessage(ExceptionCodes.ValorDeVendaDoProdutoNegativa);
        //}
        
        //[TestCase(99999999999.00)]
        //[TestCase(99999999999.455)]
        //public void Ao_criar_um_produto_informando_um_valor_de_venda_com_mais_de_10_digitos_uma_excecao_deve_ser_lancada(decimal valor)
        //{
        //    // Given
        //    var id = Fixture.Create<Guid>();
        //    var nome = new string('*', 50);

        //    // When
        //    Action act = () => new Produto(id, nome, valor, null);

        //    // Then
        //    act.Should()
        //        .Throw<DomainException>()
        //        .WithMessage(ExceptionCodes.ValorDeVendaDoProdutoComMaisDe10Digitos);
        //}

        //[TestCase(12, 12)]
        //[TestCase(12.5, 12.50)]
        //[TestCase(12.331, 12.33)]
        //[TestCase(12.999, 13.00)]
        //[TestCase(9999999999.00, 9999999999.00)]
        //[TestCase(9999999999.1111, 9999999999.11)]
        //public void Ao_criar_um_produto_informando_um_valor_de_venda_deve_ser_realizado_com_sucesso(decimal valor, decimal expected)
        //{
        //    // Given
        //    var id = Fixture.Create<Guid>();
        //    var nome = new string('*', 50);

        //    // When
        //    var produto = new Produto(id, nome, valor, null);

        //    // Then
        //    produto.ValorDeVenda.Should().Be(expected);
        //}
    }
}