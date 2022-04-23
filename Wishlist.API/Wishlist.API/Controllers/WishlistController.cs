using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wishlist.Domain.Client;
using Wishlist.Domain.Product;
using Wishlist.Domain.User;

namespace Wishlist.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WishlistController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IUserRepository _userRepository;

        public WishlistController(IProductRepository productRepository, IClientRepository clientRepository, IUserRepository userRepository)
        {
            _productRepository = productRepository;
            _clientRepository = clientRepository;
            _userRepository = userRepository;
        }


        [HttpGet("GetWishList")]
        public ActionResult GetWishList(string email, int page = 0, int limit = 100)
        {
            //var userId = _userRepository.GetLogedUserByEmail().Id;
            var userId = _userRepository.GetUserByEmail(email).Id;
            if (userId == Guid.Empty) return NotFound();

            return Ok(_clientRepository.GetWishList(userId, page, limit));
        }

        [HttpPost("Favorite")]
        public ActionResult Favorite(string email, Guid productId)
        {
            //var userId = _userRepository.GetLogedUserByEmail().Id;
            var userId = _userRepository.GetUserByEmail(email).Id;

            if (userId == Guid.Empty) return NotFound();

            _clientRepository.Save(userId, productId);

            return Ok();
        }

        [HttpDelete("Unfavorite")]
        public ActionResult Unfavorite(string email, Guid productId)
        {
            //var userId = _userRepository.GetLogedUserByEmail().Id;
            var userId = _userRepository.GetUserByEmail(email).Id;

            var wishlistItem = _clientRepository.GetProductByUser(userId, productId);

            if (wishlistItem == null) return NotFound();

            _clientRepository.Remove(wishlistItem);

            return Ok();
        }

    }
}
