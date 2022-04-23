using System.Diagnostics.CodeAnalysis;
using Wishlist.Domain.Core;

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

            ValidateObligatoryInformation();
        }

        public void Update(string name, string email)
        {
            Name = name;
            Email = email;

            ValidateObligatoryInformation();
        }

        private void ValidateObligatoryInformation()
        {
            if (Id == Guid.Empty)
            {
                throw new DomainException(ExceptionCodes.UserIdNotInformed);
            }

            if (string.IsNullOrEmpty(Name))
            {
                throw new DomainException(ExceptionCodes.UserNameNotInformed);
            }

            if (string.IsNullOrEmpty(Email))
            {
                throw new DomainException(ExceptionCodes.UserEmailNotInformed);
            }

            if (PasswordSalt == null)
            {
                throw new DomainException(ExceptionCodes.UserPasswordSaltNotInformed);
            }

            if (PasswordHash == null)
            {
                throw new DomainException(ExceptionCodes.UserPasswordHashNotInformed);
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
