using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortableAlgorithms.QuickSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class TestQuickSort
    {
        [TestMethod]
        public void SimpleQuickSort()
        {
            SimpleQuickSort sort = new SimpleQuickSort();
            int[] test1 = SortData.SimpleExample1Input;
            sort.Sort(test1);
            Assert.IsTrue(Helpers.Equals(SortData.SimpleExample1Output, test1));

            int[] test2 = SortData.SimpleExample2Input;
            sort.Sort(test2);
            Assert.IsTrue(Helpers.Equals(SortData.SimpleExample2Output, test2));
        }

        [TestMethod]
        public void QuickSort()
        {
            QuickSort sort = new QuickSort();
            ComparableInt[] test1 = SortData.Example1Input;
            sort.Sort(test1);
            Assert.IsTrue(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}