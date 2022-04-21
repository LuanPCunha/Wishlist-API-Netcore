using System;
using AutoFixture;

namespace Wishlist.Tests.Core
{
    public class BaseTests
    {
        public Fixture Fixture { get; set; }

        public BaseTests()
        {
            Fixture = FixtureSettings.CreateFixture();
            //Container = new WebHostBuilder().UseStartup<StartupTest>().Build().Services;
        }
    }
}
