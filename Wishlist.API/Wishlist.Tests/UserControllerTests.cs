using System;
using NSubstitute;
using NUnit.Framework;
using Wishlist.API.DTO;
using Wishlist.Domain.User;
using Wishlist.API.Controllers;

namespace Wishlist.Tests
{
    public class UserControllerTests
    {
        private UserController _sut;
        private IUserRepository _repository;

        public UserControllerTests()
        {
            _repository = Substitute.For<IUserRepository>();
            _sut = new UserController(_repository);
        }

        [Test]
        public void get_user()
        {
            //Given
            string email = new string('*', 50);

            //When
            _sut.Get(email);

            //Then
            _repository.Received(1).GetUserByEmail(Arg.Is<string>(x => x == email));
        }

        [Test]
        public void update_user()
        {
            //Given
            var dto = new UserDto
            {
                Id = Guid.NewGuid(),
                Name = new string('*', 50),
                Email = new string('*', 50),
                Password = new string('*', 50)
            };

            byte[] passwordSalt = new byte[32];

            byte[] passwordHash = new byte[32];

            _repository.GetUserById(dto.Id).Returns(
                new User(dto.Id, dto.Name, dto.Email, passwordSalt, passwordHash));

            //When
            _sut.Update(dto);

            //Then
            _repository.Received(1).Update(Arg.Is<User>(x =>
                x.Id == dto.Id &&
                x.Name == dto.Name &&
                x.Email == dto.Email &&
                x.PasswordSalt == passwordSalt &&
                x.PasswordHash == passwordHash));
        }

        [Test]
        public void remove_user()
        {
            //Given
            var dto = new UserDto
            {
                Id = Guid.NewGuid(),
                Name = new string('*', 50),
                Email = new string('*', 50),
                Password = new string('*', 50)
            };

            byte[] passwordSalt = new byte[32];

            byte[] passwordHash = new byte[32];

            _repository.GetUserById(dto.Id).Returns(
                new User(dto.Id, dto.Name, dto.Email, passwordSalt, passwordHash));

            //When
            _sut.Remove(dto.Id);

            //Then
            _repository.Received(1).Remove(Arg.Is<User>(x =>
                x.Id == dto.Id &&
                x.Name == dto.Name &&
                x.Email == dto.Email &&
                x.PasswordSalt == passwordSalt &&
                x.PasswordHash == passwordHash));
        }
    }
}
