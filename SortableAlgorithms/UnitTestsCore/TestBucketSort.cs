using SortableAlgorithmsCore.BubbleSort;
using SortableAlgorithmsCore.BucketSort;
using Xunit;

namespace UnitTestsCore
{
    public class TestBucketSort
    {
        [Fact]
        public void SimpleBucketSort()
        {
            var sort = new SimpleBucketSort(4);
            var test1 = SortData.SimpleExample1Input;
            sort.Sort(test1);
            Assert.True(Helpers.Equals(SortData.SimpleExample1Output, test1));

            var test2 = SortData.SimpleExample2Input;
            sort.Sort(test2);
            Assert.True(Helpers.Equals(SortData.SimpleExample2Output, test2));
        }

        [Fact]
        public void StringBucketSort()
        {
            var sort = new StringBucketSort(new BubbleSort());
            var test = SortData.Example1StringsInput;
            sort.Sort(test);
            for (var index = 0; index < SortData.Example1StringsOutput.Length; index++)
            {
                Assert.Equal(SortData.Example1StringsOutput[index], test[index]);
            }
        }

        //[TestMethod]
        //public void BubbleSort()
        //{
        //    BubbleSort bubble = new BubbleSort();
        //    ComparableInt[] test1 = SortData.Example1Input;
        //    bubble.Sort(test1);
        //    Assert.IsTrue(Helpers.Equals(SortData.Example1Output, test1));
        //}
    }
}