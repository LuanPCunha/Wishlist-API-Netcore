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

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_productRepository.GetProduct(id));
        }

        [HttpGet]
        public ActionResult GetWishList(int page = 0, int limit = 100)
        {
            //var userId = _userRepository.GetLogedUserByEmail().Id;
            var userId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");
            if (userId == Guid.Empty) return NotFound();

            return Ok(_clientRepository.GetWishList(userId, page, limit));
        }

        [HttpPost]
        public ActionResult Favorite(Guid productId)
        {
            //var userId = _userRepository.GetLogedUserByEmail().Id;
            var userId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");
            if (userId == Guid.Empty) return NotFound();

            _clientRepository.Save(userId, productId);

            return Ok();
        }

        [HttpDelete]
        public ActionResult Unfavorite(Guid productId)
        {
            var userId = _userRepository.GetLogedUserByEmail().Id;

            var wishlistItem = _clientRepository.GetProductByUser(userId, productId);

            if (wishlistItem == null) return NotFound();

            _clientRepository.Remove(wishlistItem);

            return Ok();
        }

    }
}
