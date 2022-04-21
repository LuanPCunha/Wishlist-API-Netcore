using Microsoft.AspNetCore.Mvc;
using Wishlist.API.DTO;
using Wishlist.Domain.Product;

namespace Wishlist.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WishlistController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public WishlistController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_repository.ObterPorId(id));
        }


        [HttpPost, DisableRequestSizeLimit]
        public IActionResult AddToWishlist(ProductDTO dto)
        {
            var aggregate = new Product(dto.Id, dto.Title, dto.Image, dto.Price, dto.ReviewScore);

            _repository.Adicionar(aggregate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveFromWishlist(Guid id)
        {
            var aggregate = _repository.ObterPorId(id);

            if (aggregate == null) return NotFound();

            _repository.Remover(aggregate);

            return Ok();
        }
    }
}
