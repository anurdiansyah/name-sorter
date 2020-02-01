using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorting;

namespace UnitTestNameSorting
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void LearnUnitTest()
        {
            List<string> lstExpected = RDFile.ReadAllLine("sorted-names-list.txt");
            List<string> lstActual = RDString.SortByLastWord(RDFile.ReadAllLine("unsorted-names-list.txt"), ' ');

            CollectionAssert.AreEqual(lstExpected, lstActual);
        }
    }
}
