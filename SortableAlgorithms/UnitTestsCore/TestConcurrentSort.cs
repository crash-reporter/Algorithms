using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SortableAlgorithmsCore.BubbleSort;
using SortableAlgorithmsCore.ConcurrencySort;
using Xunit;

namespace UnitTestsCore
{
    public class TestConcurrentSort
    {
        [Fact]
        public async Task ConcurrentStringBucketSort()
        {
            var sort = new StringBucketSort(new BubbleSort());
            var test = SortData.Example1StringsInput;
            var result = await sort.Sort(test, CancellationToken.None);
           
            for (var index = 0; index < SortData.Example1StringsOutput.Length; index++)
            {
                Assert.Equal(SortData.Example1StringsOutput[index], result[index]);
            }
        }

        [Fact]
        public async Task ConcurrentQuickSort()
        {
            var test1 = SortData.Example1Input;
            await QuickSort.Sort(test1, CancellationToken.None);
            Assert.True(Helpers.Equals(SortData.Example1Output, test1));
        }
    }
}
