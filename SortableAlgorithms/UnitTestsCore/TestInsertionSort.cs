using SortableAlgorithms.InsertionSort;
using Xunit;

namespace UnitTestsCore
{
    public class TestInsertionSort
    {
        [Fact]
        public void SimpleInsertionSort()
        {
            var sort = new SimpleInsertionSort();
            var test1 = SortData.SimpleExample1Input;
            sort.Sort(test1);
            Assert.True(Helpers.Equals(SortData.SimpleExample1Output, test1));

            var test2 = SortData.SimpleExample2Input;
            sort.Sort(test2);
            Assert.True(Helpers.Equals(SortData.SimpleExample2Output, test2));
        }

        [Fact]
        public void InsertionSort()
        {
            var sort = new InsertionSort();
            var test1 = SortData.Example1Input;
            sort.Sort(test1);
            Assert.True(Helpers.Equals(SortData.Example1Output, test1));
        }

        [Fact]
        public void InsertionSortOptimized()
        {
            var sort = new InsertionSortOptimized();
            var test1 = SortData.Example1Input;
            sort.Sort(test1);
            Assert.True(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}