using System;
namespace Wishlist.API.DTO
{
    [Serializable]
    public class ProductDTO
    {
        public decimal Price { get; set; }
        public string Image { get; set; }
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public decimal? ReviewScore { get; set; }

    }
}
