using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MatveevaAA.Sprint0.Task2.V0.Lib;


namespace Tyuiu.MatveevaAA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Настя";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Настя", res);
        }
    }
}
