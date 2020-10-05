using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 1, 3, 5, 5, 5, 6, 7, 9, 11, 11 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
