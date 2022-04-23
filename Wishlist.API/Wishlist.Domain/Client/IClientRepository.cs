namespace Wishlist.Domain.Client
{
    public interface IClientRepository
    {
        void Save(Guid id);
    }
}
