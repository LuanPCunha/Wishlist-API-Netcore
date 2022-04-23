using System;

namespace Wishlist.Domain.Core
{
    public static class ExceptionCodes
    {
        //Remover Depois
        public const string IdDoProdutoNaoInformado = "É obrigatório informar um Id para o produto";
        public const string NomeDoProdutoNaoInformado = "É obrigatório informar um Nome para o produto";
        public const string ValorDeVendaDoProdutoNegativa = "É necessário informar um Valor de Venda maior que zero";
        public const string ValorDeVendaDoProdutoComMaisDe10Digitos = "É necessário informar um número com no máximo 10 dígitos";
        public const string NomeDoProdutoComMaisDe300Caracteres = "O nome do produto deve ter no máximo 300 caracteres";

        //Novos
        public const string UserIdNotInformed = "User Id Not Informed";
        public const string UserNameNotInformed = "User Name Not Informed";
        public const string UserEmailNotInformed = "User Email Not Informed";
        public const string UserPasswordSaltNotInformed = "User PasswordSalt NotInformed";
        public const string UserPasswordHashNotInformed = "User PasswordHash NotInformed";
    }
}