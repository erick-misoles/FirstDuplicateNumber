using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirstDuplicateNumber.Helpers;
using System;

namespace FirstDuplicateNumber.Tests
{
    [TestClass]
    public class DuplicateFinderTests
    {
        [TestMethod]
        public void FindFirstDuplicate_WithDuplicates_ReturnsFirstDuplicate()
        {
            int[] numbers = { 2, 1, 3, 5, 3, 2 };
            var result = DuplicateFinder.FindFirstDuplicate(numbers);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FindFirstDuplicate_NoDuplicates_ReturnsNull()
        {
            int[] numbers = { 1, 2, 3, 4 };
            var result = DuplicateFinder.FindFirstDuplicate(numbers);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindFirstDuplicate_EmptyArray_ReturnsNull()
        {
            int[] numbers = { };
            var result = DuplicateFinder.FindFirstDuplicate(numbers);
            Assert.IsNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindFirstDuplicate_NullArray_ThrowsArgumentNullException()
        {
            int[] numbers = null;
            DuplicateFinder.FindFirstDuplicate(numbers);
        }
    }
}
