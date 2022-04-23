using Microsoft.AspNetCore.Mvc;
using Wishlist.API.DTO;
using Wishlist.Domain.Client;
using Wishlist.Domain.Product;
using Wishlist.Domain.User;
using Wishlist.Domain.UserProductList;

namespace Wishlist.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class WishlistController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IClientRepository _clientRepository;

        public WishlistController(IProductRepository productRepository,IClientRepository clientRepository)
        { 
            _productRepository = productRepository;
            _clientRepository = clientRepository;

        }

        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_productRepository.GetProduct(id));
        }

        [HttpPost()]
        public ActionResult Favorite(Guid id)
        {
            _clientRepository.Save(id);
            return Ok();
        }


    }
}
