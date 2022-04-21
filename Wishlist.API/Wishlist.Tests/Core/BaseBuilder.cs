using System;
using AutoFixture.Kernel;

namespace Wishlist.Tests.Core
{
    public abstract class BaseBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {

            if (request is Type && ((Type)request) == AppliableTo())
            {
                return CreateNew(context);
            }
            return new NoSpecimen();
        }

        protected abstract Type AppliableTo();

        protected abstract object CreateNew(ISpecimenContext context);

        protected string GenerateString(int length)
        {
            if (length >= 0)
            {
                var retval = string.Empty;

                while (retval.Length < length)
                {
                    retval += Guid.NewGuid().ToString();
                }

                return retval;
            }

            return null;
        }
    }
}
