using System;
using System.Collections;
using Xunit;

namespace TypeUtility.Tests.NETCore22
{
    public class TypeExtensionsTests
    {
        [Fact]
        public void IsAssignableFrom_Should_Works()
        {
            // arrange
            var type1 = typeof(IEnumerable);
            var type2 = typeof(Array);

            // act 
            var result = type1.IsAssignableFrom(type2);

            // assert
            Assert.True(result);
        }

        [Fact]
        public void IsAssignableFrom_Should_Fails()
        {
            // arrange
            var type1 = typeof(DateTime);
            var type2 = typeof(Array);

            // act 
            var result = type1.IsAssignableFrom(type2);

            // assert
            Assert.False(result);
        }
    }
}