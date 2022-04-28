namespace Wishlist.Domain.Core
{
    public static class ExceptionCodes
    {
        
        public const string UserIdNotInformed = "User Id Not Informed";
        public const string UserNameNotInformed = "User Name Not Informed";
        public const string UserEmailNotInformed = "User Email Not Informed";
        public const string UserPasswordSaltNotInformed = "User PasswordSalt NotInformed";
        public const string UserPasswordHashNotInformed = "User PasswordHash NotInformed";

        public const string ProductIdNotInformed = "Product Id Not Informed";
        public const string ProductTitleNotInformed = "ProductTitleNotInformed";
        public const string ProductImageNotInformed = "ProductImageNotInformed";
        public const string ProductPriceNotInformed = "Product Price Not Informed";
        public const string ProductReviewScoreNotInformed = "Product Review Score Not Informed";

    }
}