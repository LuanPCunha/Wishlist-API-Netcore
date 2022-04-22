using Microsoft.AspNetCore.Mvc;
using Wishlist.API.DTO;
using Wishlist.Domain.Product;
using Wishlist.Domain.User;
using Wishlist.Domain.UserProductList;

namespace Wishlist.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WishlistController : ControllerBase
    {
        private readonly IUserRepository _userrepository;
        private readonly IUserProductListRepository _userProductListRepository;

        public WishlistController(IUserRepository userrepository, IUserProductListRepository userProductListRepository)
        {
            _userrepository = userrepository;
            _userProductListRepository = userProductListRepository;


        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            //return Ok(_repository.ObterPorId(id));
            return Ok();
        }


        [HttpPost, DisableRequestSizeLimit]
        public IActionResult AddToWishlist(ProductDTO dto)
        {
            var aggregate = new Product(dto.Id, dto.Title, dto.Image, dto.Price, dto.ReviewScore);

            //_repository.Adicionar(aggregate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveFromWishlist(Guid id)
        {
            //var aggregate = _repository.ObterPorId(id);

            //if (aggregate == null) return NotFound();

            //_repository.Remover(aggregate);

            return Ok();
        }
    }
}
