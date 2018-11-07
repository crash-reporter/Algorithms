using DataStructuresCore;
using Xunit;

namespace TestsCore
{
    public class TestListInt
    {
        [Fact]
        public void ListInt_Ctors()
        {
            Assert.Equal(0, new ListInt().Count);
            Assert.Equal(2, new ListInt(new[] { 1, 2 }).Count);
        }

        [Fact]
        public void ListInt_Index()
        {
            var list = new ListInt(new[] { 1, 2 });
            Assert.Equal(1, list[0]);
            Assert.Equal(2, list[1]);
            list[0] = 3;
            list[1] = 4;
            Assert.Equal(3, list[0]);
            Assert.Equal(4, list[1]);
        }

        [Fact]
        public void ListInt_Add()
        {
            var list = new ListInt();
            list.Add(1);
            list.Add(2);
            Assert.Equal(2, list.Count);
            Assert.Equal(1, list[0]);
            Assert.Equal(2, list[1]);
        }

        [Fact]
        public void ListInt_Insert()
        {
            var list = new ListInt(new[] { 1 });
            list.Insert(2, 0);
            Assert.Equal(2, list.Count);
            Assert.Equal(2, list[0]);
            Assert.Equal(1, list[1]);
        }

        [Fact]
        public void ListInt_Contains()
        {
            var list = new ListInt(new[] { 1, 2 });
            Assert.True(list.Contains(1));
            Assert.True(list.Contains(2));
            Assert.False(list.Contains(3));
        }

        [Fact]
        public void ListInt_IndexOf()
        {
            var list = new ListInt(new[] { 1, 2 });
            Assert.Equal(0, list.IndexOf(1));
            Assert.Equal(1, list.IndexOf(2));
        }

        [Fact]
        public void ListInt_Remove()
        {
            var list = new ListInt(new[] { 1, 2 });
            list.Remove(1);
            list.Remove(2);
            Assert.Equal(0, list.Count);
        }

        [Fact]
        public void ListInt_RemoveAt()
        {
            var list = new ListInt(new[] { 1, 2 });
            list.RemoveAt(1);
            Assert.Equal(1, list.Count);
            Assert.Equal(1, list[0]);
        }

        [Fact]
        public void ListInt_Resize()
        {
            var list = new ListInt();
            for (var i = 0; i < 1024; i++)
            {
                list.Add(i);
            }
            Assert.Equal(1024, list.Count);
        }
    }
}