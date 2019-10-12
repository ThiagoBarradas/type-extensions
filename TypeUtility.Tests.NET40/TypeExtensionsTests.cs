using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace TypeUtility.Tests.NET40
{
    [TestClass]
    public class TypeExtensionsTests
    {
        [TestMethod]
        public void IsAssignableFrom_Should_Works()
        {
            // arrange
            var type1 = typeof(IEnumerable);
            var type2 = typeof(Array);

            // act 
            var result = type1.IsAssignableFrom(type2);

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAssignableFrom_Should_Fails()
        {
            // arrange
            var type1 = typeof(DateTime);
            var type2 = typeof(Array);

            // act 
            var result = type1.IsAssignableFrom(type2);

            // assert
            Assert.IsFalse(result);
        }
    }
}
