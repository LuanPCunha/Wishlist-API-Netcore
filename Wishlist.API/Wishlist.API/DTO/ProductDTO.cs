namespace Wishlist.API.DTO
{
    [Serializable]
    public class ProductDTO
    {
        public float Price { get; set; } = float.MinValue;
        public string Image { get; set; } = string.Empty;
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Brand { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public float? ReviewScore { get; set; } = float.MinValue;

    }

}
