namespace Wishlist.Domain.User
{
    public interface IUserRepository
    {
        User GetLogedUserByEmail();

        User GetUserByEmail(string email);

        bool EmailInUse(string email);

        User GetUserById(Guid id);

        void CreateUser(Guid id, string name, string email, string password);

        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);

        string CreateToken(User user);

        void Update(User user);

        void Remove(User user);

    }
}
