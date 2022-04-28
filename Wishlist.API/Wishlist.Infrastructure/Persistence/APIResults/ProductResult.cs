namespace Wishlist.Infrastructure.Persistence.APIResults
{
    [Serializable]
    public class ProductResult
    {
        public float? reviewScore { get; set; }
        public string title { get; set; }
        public float price { get; set; }
        public string brand { get; set; }
        public string id { get; set; }
        public string image { get; set; }
    }

}

