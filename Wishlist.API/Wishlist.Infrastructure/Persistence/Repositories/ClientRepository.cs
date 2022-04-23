using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Security.Cryptography;
using Wishlist.Domain.User;
using Wishlist.Infrastructure.Persistence.Core;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using Wishlist.Domain.Client;

namespace Wishlist.Infrastructure.Persistence.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;

        public ClientRepository(IConfiguration configuration, Context context)
        {
            _context = context;
            _configuration = configuration;
        }



        public void Save(Guid id)
        {

            var p1 = Guid.Parse("958ec015-cfcf-258d-c6df-1721de0ab6ea");
            var p2 = Guid.Parse("2b505fab-d865-e164-345d-efbd4c2045b6");
           
            var client = new Client(id,p1);
            _context.Clients.Add(client);

            _context.SaveChanges();
        }


    }
}
