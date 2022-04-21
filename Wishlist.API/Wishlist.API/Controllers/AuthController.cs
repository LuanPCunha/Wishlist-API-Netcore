﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Wishlist.API.DTO;
using Wishlist.Domain.User;

namespace Wishlist.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("register"), AllowAnonymous]
        public async Task<ActionResult> Register(UserDto request)
        {
            _repository.CreateUser(request.Id, request.Name, request.Email, request.Password);

            return Ok();
        }

        [HttpPost("login"), AllowAnonymous]
        public async Task<ActionResult<string>> Login(LoginDto request)
        {
            var user = _repository.GetUserByEmail(request.Email);

            if (user == null)
            {
                return BadRequest("User not found.");
            }

            if (!_repository.VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Wrong password.");
            }

            string token = _repository.CreateToken(user);
            return Ok(token);
        }

    }
}