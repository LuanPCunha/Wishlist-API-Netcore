using System;
using AutoFixture;

namespace Wishlist.Tests.Core
{
    public static class FixtureSettings
    {
        public static Fixture CreateFixture()
        {
            var fixture = new Fixture();
            fixture.Behaviors.Clear();
            fixture.Behaviors.Add(new NullRecursionBehavior());
            fixture.Customize(new RegisterBuilders());

            return fixture;
        }
    }
}
