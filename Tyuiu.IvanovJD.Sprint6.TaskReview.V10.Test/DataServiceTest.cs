using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovJD.Sprint6.TaskReview.V10.Lib;

namespace Tyuiu.IvanovJD.Sprint6.TaskReview.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int k = 1;
            int l = 4;
            int c = 4;



            int[,] mas = new int[5, 5] { { 27, 15, 14, 2, 27 },
                                         { 8, 14, 10, 33, 13 },
                                         { 1, 7, 11, 11, 23 },
                                         { 13, 20, 15, 16, 34 },
                                         { 3, 1, 1, 5, 1 } };
            int res = ds.GetMatrix(mas, c, k, l);
            int wait = 23;
            Assert.AreEqual(wait, res);
        }
    }
}