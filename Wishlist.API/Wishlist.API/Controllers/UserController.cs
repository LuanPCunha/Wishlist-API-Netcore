using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wishlist.API.DTO;
using Wishlist.Domain.User;

namespace Wishlist.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetUser")]
        public ActionResult<UserDto> Get(string email)
        {
            var user = _repository.GetUserByEmail(email);

            if (user == null) return NotFound();

            return Ok(user);

        }

        [HttpPut("Update")]
        public ActionResult Update(UserDto request)
        {
            var emailInUse = _repository.EmailInUse(request.Email);

            if (emailInUse)
            {
                return BadRequest("Email alread in use.");
            }

            var user = _repository.GetUserById(request.Id);

            if (user == null) return NotFound();

            user.Update(request.Name, request.Email);

            _repository.Update(user);

            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult Remove(Guid id)
        {
            var user = _repository.GetUserById(id);

            if (user == null) return NotFound();

            _repository.Remove(user);

            return Ok();
        }

    }
}
