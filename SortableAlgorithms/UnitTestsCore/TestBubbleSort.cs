using SortableAlgorithms.BubbleSort;
using Xunit;

namespace UnitTestsCore
{
    public class TestBubbleSort
    {
        [Fact]
        public void SimpleBubbleSort()
        {
            var bubble = new SimpleBubbleSort();
            var test1 = SortData.SimpleExample1Input;
            bubble.Sort(test1);
            Assert.True(Helpers.Equals(SortData.SimpleExample1Output, test1));

            var test2 = SortData.SimpleExample2Input;
            bubble.Sort(test2);
            Assert.True(Helpers.Equals(SortData.SimpleExample2Output, test2));
        }

        [Fact]
        public void BubbleSort()
        {
            var bubble = new BubbleSort();
            var test1 = SortData.Example1Input;
            bubble.Sort(test1);
            Assert.True(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}