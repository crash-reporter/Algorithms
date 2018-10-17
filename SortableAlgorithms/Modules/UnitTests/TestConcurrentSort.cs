using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortableAlgorithms.ConcurrencySort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class TestConcurrentSort
    {
        [TestMethod]
        public void ConcurrentStringBucketSort()
        {
            StringBucketSort sort = new StringBucketSort(new SortableAlgorithms.BubbleSort.BubbleSort());
            string[] test = SortData.Example1StringsInput;
            sort.Sort(test, CancellationToken.None);
            for (int index = 0; index < SortData.Example1StringsOutput.Length; index++)
            {
                Assert.AreEqual(SortData.Example1StringsOutput[index], test[index]);
            }
        }

        [TestMethod]
        public void ConcurrentQuickSort()
        {
            QuickSort sort = new QuickSort();
            ComparableInt[] test1 = SortData.Example1Input;
            sort.Sort(test1, CancellationToken.None);
            Assert.IsTrue(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}
