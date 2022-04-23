using AutoFixture;
using FluentAssertions;
using NUnit.Framework;
using System;
using Wishlist.Domain.Core;
using Wishlist.Domain.User;
using Wishlist.Tests.Core;

namespace Wishlist.Tests
{
    internal class UserTests : BaseTests
    {
        [Test]
        public void create_user_successfully()
        {
            // Given
            var id = Fixture.Create<Guid>();
            var name = new string('*', 50);
            var email = new string('*', 50);
            var passwordSalt = new byte[32];
            var passwordHash = new byte[32];

            // When
            var user = new User(id, name, email, passwordSalt, passwordHash);

            //Then
            user.Id.Should().Be(id);
            user.Name.Should().Be(name);
            user.Email.Should().Be(email);
            user.PasswordSalt.Should().NotBeEmpty();
            user.PasswordHash.Should().NotBeEmpty();
        }

        [Test]
        public void when_creating_a_user_without_id_an_exception_must_be_thrown()
        {
            // Given
            var id = Guid.Empty;
            var name = new string('*', 50);
            var email = new string('*', 50);
            var passwordSalt = new byte[32];
            var passwordHash = new byte[32];

            // When
            Action act = () => new User(id, name, email, passwordSalt, passwordHash);

            // Then
            act.Should()
                .Throw<DomainException>()
                .WithMessage(ExceptionCodes.UserIdNotInformed);
        }

        [Test]
        public void when_creating_a_user_without_name_an_exception_must_be_thrown()
        {
            // Given
            var id = Fixture.Create<Guid>();
            var name = string.Empty;
            var email = new string('*', 50);
            var passwordSalt = new byte[32];
            var passwordHash = new byte[32];

            // When
            Action act = () => new User(id, name, email, passwordSalt, passwordHash);

            // Then
            act.Should()
                .Throw<DomainException>()
                .WithMessage(ExceptionCodes.UserNameNotInformed);
        }

        [Test]
        public void when_creating_a_user_without_email_an_exception_must_be_thrown()
        {
            // Given
            var id = Fixture.Create<Guid>();
            var name = new string('*', 50);
            var email = string.Empty;
            var passwordSalt = new byte[32];
            var passwordHash = new byte[32];

            // When
            Action act = () => new User(id, name, email, passwordSalt, passwordHash);

            // Then
            act.Should()
                .Throw<DomainException>()
                .WithMessage(ExceptionCodes.UserEmailNotInformed);
        }

        [Test]
        public void when_creating_a_user_without_password_salt_an_exception_must_be_thrown()
        {
            // Given
            var id = Fixture.Create<Guid>();
            var name = new string('*', 50);
            var email = new string('*', 50);
            var passwordHash = new byte[32];

            // When
            Action act = () => new User(id, name, email, null, passwordHash);

            // Then
            act.Should()
                .Throw<DomainException>()
                .WithMessage(ExceptionCodes.UserPasswordSaltNotInformed);
        }

        [Test]
        public void when_creating_a_user_without_password_hash_an_exception_must_be_thrown()
        {
            // Given
            var id = Fixture.Create<Guid>();
            var name = new string('*', 50);
            var email = new string('*', 50);
            var passwordSalt = new byte[32];

            // When
            Action act = () => new User(id, name, email, passwordSalt, null);

            // Then
            act.Should()
                .Throw<DomainException>()
                .WithMessage(ExceptionCodes.UserPasswordHashNotInformed);
        }
    }
}
