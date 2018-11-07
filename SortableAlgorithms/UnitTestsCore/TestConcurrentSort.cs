using System.Threading;
using System.Threading.Tasks;
using SortableAlgorithms.ConcurrencySort;
using Xunit;

namespace UnitTestsCore
{
    public class TestConcurrentSort
    {
        [Fact]
        public async Task ConcurrentStringBucketSort()
        {
            var sort = new StringBucketSort(new SortableAlgorithms.BubbleSort.BubbleSort());
            var test = SortData.Example1StringsInput;
            await sort.Sort(test, CancellationToken.None);
            for (var index = 0; index < SortData.Example1StringsOutput.Length; index++)
            {
                Assert.Equal(SortData.Example1StringsOutput[index], test[index]);
            }
        }

        [Fact]
        public void ConcurrentQuickSort()
        {
            var sort = new QuickSort();
            var test1 = SortData.Example1Input;
            sort.Sort(test1, CancellationToken.None);
            Assert.True(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}
