namespace Wishlist.Domain.User
{
    public interface IUserRepository
    {
        string GetName();

        User GetUserByEmail(string email);

        void CreateUser(Guid id, string name, string email, string password);

        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);

        string CreateToken(User user);

    }
}
