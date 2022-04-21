using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using AutoFixture.Kernel;

namespace Wishlist.Tests.Core
{
    public class RegisterBuilders : ICustomization
    {
        private static ISpecimenBuilder _customBuilders;

        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(CreateBuilder());
        }

        protected virtual IEnumerable<ISpecimenBuilder> AdditionalBuilders => Enumerable.Empty<ISpecimenBuilder>();

        protected virtual ISpecimenBuilder CreateBuilder()
        {
            if (_customBuilders == null)
            {
                var builders =
                    typeof(RegisterBuilders).Assembly.GetTypes()
                        .Where(t =>
                            typeof(BaseBuilder).IsAssignableFrom(t) && t.IsAbstract == false).Select(builder =>
                            Activator.CreateInstance(builder) as ISpecimenBuilder).ToList();

                foreach (var specimenBuilder in AdditionalBuilders)
                {
                    builders.Add(specimenBuilder);
                }

                _customBuilders = new CompositeSpecimenBuilder(builders);
            }

            return _customBuilders;
        }
    }
}
