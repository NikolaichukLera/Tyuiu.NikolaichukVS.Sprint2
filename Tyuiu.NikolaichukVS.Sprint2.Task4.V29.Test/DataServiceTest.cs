using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint2.Task4.V29.Lib;

namespace Tyuiu.NikolaichukVS.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 19;
            double res = ds.Calculate(x, y);
            double wait = 228;
            Assert.AreEqual(wait, res);

        }

        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 2;
            Assert.AreEqual(wait, res);

        }
    }
}
