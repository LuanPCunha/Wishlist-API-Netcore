using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Wishlist.Domain.User;
using Wishlist.Infrastructure.Persistence.Core;
using Wishlist.Infrastructure.Persistence.Repositories;
using Microsoft.AspNetCore.Http;

namespace Wishlist.Tests
{
    public class UserRepositoryTests
    {
        private IUserRepository _sut;
        private Context _context;
        private IConfiguration _configuration;
        private IHttpContextAccessor _httpContextAccessor;

        public UserRepositoryTests()
        {
            var options = new DbContextOptionsBuilder<Context>()
                .UseInMemoryDatabase(databaseName: "Database")
                .Options;

            _context = new Context(options);

            _context.Users.Add(new User(Guid.NewGuid(), "Luan", "luan@email.com", new byte[32], new byte[32]));
            _context.SaveChanges();

            _sut = new UserRepository(_configuration, _context, _httpContextAccessor);
        }
    }
}
