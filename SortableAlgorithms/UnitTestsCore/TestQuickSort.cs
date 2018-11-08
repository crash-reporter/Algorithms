using SortableAlgorithmsCore.QuickSort;
using Xunit;

namespace UnitTestsCore
{
    public class TestQuickSort
    {
        [Fact]
        public void SimpleQuickSort()
        {
            var sort = new SimpleQuickSort();
            var test1 = SortData.SimpleExample1Input;
            sort.Sort(test1);
            Assert.True(Helpers.Equals(SortData.SimpleExample1Output, test1));

            var test2 = SortData.SimpleExample2Input;
            sort.Sort(test2);
            Assert.True(Helpers.Equals(SortData.SimpleExample2Output, test2));
        }

        [Fact]
        public void QuickSort()
        {
            var sort = new QuickSort();
            var test1 = SortData.Example1Input;
            sort.Sort(test1);
            Assert.True(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}