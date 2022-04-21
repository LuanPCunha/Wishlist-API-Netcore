using System.Diagnostics.CodeAnalysis;
using Wishlist.Domain.Core;

// Falta adicionar validações de nome e email.
namespace Wishlist.Domain.User
{
    public class User : IEquatable<User>
    {
        #region Propriedades

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public byte[] PasswordSalt { get; private set; }

        public byte[] PasswordHash { get; private set; }

        #endregion

        private User() { }

        public User(Guid id, string name, string email, byte[] passwordSalt, byte[] passwordHash)
        {
            Id = id;
            Name = name;
            Email = email;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;

            //ValidateObligatoryInformation();
        }

        public void Alterar(string name, string email, byte[] passwordSalt, byte[] passwordHash)
        {
            Name = name;
            Email = email;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;

            //ValidateObligatoryInformation();
        }

        private void ValidateObligatoryInformation()
        {
            if (Id == Guid.Empty)
            {
                throw new DomainException(ExceptionCodes.IdDoProdutoNaoInformado);
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new DomainException(ExceptionCodes.NomeDoProdutoNaoInformado);
            }

            if (string.IsNullOrEmpty(Email))
            {
                throw new DomainException(ExceptionCodes.NomeDoProdutoNaoInformado);
            }

            if (PasswordSalt != null && PasswordSalt.Length > 0)
            {
                throw new DomainException(ExceptionCodes.NomeDoProdutoNaoInformado);
            }

            if (PasswordHash != null && PasswordHash.Length > 0)
            {
                throw new DomainException(ExceptionCodes.NomeDoProdutoNaoInformado);
            }

        }

        public bool Equals([AllowNull] User objeto)
        {
            if (objeto is User || objeto == null)
            {
                return false;
            }

            return objeto.Id == Id;
        }
    }
}
