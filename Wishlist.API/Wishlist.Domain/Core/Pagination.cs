namespace Wishlist.Domain.Core
{
    public class Pagination<T>
    {
        public Pagination()
        {
            Items = new List<T>();
        }

        public int Total { get; set; }
        public int? Page { get; set; }
        public int? Limit { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
