using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortableAlgorithms.BubbleSort;

namespace UnitTests
{
    [TestClass]
    public class TestBubbleSort
    {
        [TestMethod]
        public void SimpleBubbleSort()
        {
            SimpleBubbleSort bubble = new SimpleBubbleSort();
            int[] test1 = SortData.SimpleExample1Input;
            bubble.Sort(test1);
            Assert.IsTrue(Helpers.Equals(SortData.SimpleExample1Output, test1));

            int[] test2 = SortData.SimpleExample2Input;
            bubble.Sort(test2);
            Assert.IsTrue(Helpers.Equals(SortData.SimpleExample2Output, test2));
        }

        [TestMethod]
        public void BubbleSort()
        {
            BubbleSort bubble = new BubbleSort();
            ComparableInt[] test1 = SortData.Example1Input;
            bubble.Sort(test1);
            Assert.IsTrue(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}