using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class TestListInt
    {
        [TestMethod]
        public void ListInt_Ctors()
        {
            Assert.AreEqual(0, new ListInt().Count);
            Assert.AreEqual(2, new ListInt(new int[] { 1, 2 }).Count);
        }

        [TestMethod]
        public void ListInt_Index()
        {
            ListInt list = new ListInt(new int[] { 1, 2 });
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            list[0] = 3;
            list[1] = 4;
            Assert.AreEqual(3, list[0]);
            Assert.AreEqual(4, list[1]);
        }

        [TestMethod]
        public void ListInt_Add()
        {
            ListInt list = new ListInt();
            list.Add(1);
            list.Add(2);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
        }

        [TestMethod]
        public void ListInt_Insert()
        {
            ListInt list = new ListInt(new int[] { 1 });
            list.Insert(2, 0);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(2, list[0]);
            Assert.AreEqual(1, list[1]);
        }

        [TestMethod]
        public void ListInt_Contains()
        {
            ListInt list = new ListInt(new int[] { 1, 2 });
            Assert.IsTrue(list.Contains(1));
            Assert.IsTrue(list.Contains(2));
            Assert.IsFalse(list.Contains(3));
        }

        [TestMethod]
        public void ListInt_IndexOf()
        {
            ListInt list = new ListInt(new int[] { 1, 2 });
            Assert.AreEqual(0, list.IndexOf(1));
            Assert.AreEqual(1, list.IndexOf(2));
        }

        [TestMethod]
        public void ListInt_Remove()
        {
            ListInt list = new ListInt(new int[] { 1, 2 });
            list.Remove(1);
            list.Remove(2);
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void ListInt_RemoveAt()
        {
            ListInt list = new ListInt(new int[] { 1, 2 });
            list.RemoveAt(1);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(1, list[0]);
        }

        [TestMethod]
        public void ListInt_Resize()
        {
            ListInt list = new ListInt();
            for (int i = 0; i < 1024; i++)
            {
                list.Add(i);
            }
            Assert.AreEqual(1024, list.Count);
        }
    }
}