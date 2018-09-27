using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortableAlgorithms.BubbleSort;
using SortableAlgorithms.BucketSort;

namespace UnitTests
{
    [TestClass]
    public class TestBucketSort
    {
        [TestMethod]
        public void SimpleBucketSort()
        {
            SimpleBucketSort sort = new SimpleBucketSort(4);
            int[] test1 = SortData.SimpleExample1Input;
            sort.Sort(test1);
            Assert.IsTrue(Helpers.Equals(SortData.SimpleExample1Output, test1));

            int[] test2 = SortData.SimpleExample2Input;
            sort.Sort(test2);
            Assert.IsTrue(Helpers.Equals(SortData.SimpleExample2Output, test2));
        }

        [TestMethod]
        public void StringBucketSort()
        {
            StringBucketSort sort = new StringBucketSort(new BubbleSort());
            string[] test = SortData.Example1StringsInput;
            sort.Sort(test);
            for (int index = 0; index < SortData.Example1StringsOutput.Length; index++)
            {
                Assert.AreEqual(SortData.Example1StringsOutput[index], test[index]);
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