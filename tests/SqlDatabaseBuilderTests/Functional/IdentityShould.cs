using System;
using System.Data.SqlClient;
using Xtrimmer.SqlDatabaseBuilder;
using Xunit;

namespace Xtrimmer.SqlDatabaseBuilderTests.Functional
{
    public class IdentityShould
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData(2, null)]
        [InlineData(2, 0)]
        [InlineData(2, -1)]
        [InlineData(2, -5)]
        [InlineData(2, -100)]
        [InlineData(2, int.MinValue)]
        public void AddIdentityWithSomeInvalidValues(int seed, int increment)
        {
            Assert.Throws<InvalidIdentityException>(() => new Identity(seed, increment));
        }
    }
}
