using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetaProject;
using System.Diagnostics;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AllElementsInListAreDistinct()
        {
            MetaProgram.List l = new MetaProgram.List(0);
            MetaProgram.List l2  = new MetaProgram.List(1);
            l.next = l2;

            Assert.IsFalse(l.AreAllSame());

        }

        [TestMethod]
        public void AllElementsInListAreNOTDistinct()
        {

            MetaProgram.List l = new MetaProgram.List(1);
            MetaProgram.List l2 = new MetaProgram.List(1);
            l.next = l2;

            Assert.IsTrue(l.AreAllSame());

        }

        [TestMethod]
        public void AllElementsInListAreNOTDistinctWithZeros()
        {

            MetaProgram.List l = new MetaProgram.List(0);
            MetaProgram.List l2 = new MetaProgram.List(0);
            l.next = l2;

            Assert.IsTrue(l.AreAllSame());

        }

        [TestMethod]
        public void AllElementsInListAreNOTDistinctWithLength4()
        {

            MetaProgram.List l = new MetaProgram.List(1);
            MetaProgram.List l2 = new MetaProgram.List(1);
            MetaProgram.List l3 = new MetaProgram.List(1);
            MetaProgram.List l4 = new MetaProgram.List(1);
            l.next = l2;
            l2.next = l3;
            l3.next = l4;

            Assert.IsTrue(l.AreAllSame());

        }

        [TestMethod]
        public void IsInLast()
        {
            MetaProgram.List l = new MetaProgram.List(0);
            MetaProgram.List l2 = new MetaProgram.List(2);
            l.next = l2;
            Assert.IsTrue(l.IsInLast(2));
        }
        [TestMethod]
        public void IsInLastWithZeros()
        {
            MetaProgram.List l = new MetaProgram.List(0);
            MetaProgram.List l2 = new MetaProgram.List(0);
            l.next = l2;
            Assert.IsTrue(l.IsInLast(0));
        }

        [TestMethod]
        public void IsNotInLastWithZeros()
        {
            MetaProgram.List l = new MetaProgram.List(0);
            MetaProgram.List l2 = new MetaProgram.List(0);
            l.next = l2;
            Assert.IsFalse(l.IsInLast(1));
        }
        [TestMethod]
        public void AllElementsInListAreDistinctWithLength4()
        {

            MetaProgram.List l = new MetaProgram.List(1);
            MetaProgram.List l2 = new MetaProgram.List(2);
            MetaProgram.List l3 = new MetaProgram.List(3);
            MetaProgram.List l4 = new MetaProgram.List(4);
            l.next = l2;
            l2.next = l3;
            l3.next = l4;

            Assert.IsFalse(l.AreAllSame());

        }
    }
}
