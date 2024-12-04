using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.AntonovVV.Sprint0.Task2.V00.Lib;

namespace Tyuiu.AntonovVV.Sprint0.Task2.V00.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Василий";
            var res = DataService.GetMessage(name);

            // Вызывавем класс Assert  и метод AreEqual
            Assert.AreEqual("Привет, Василий", res);

        }
    }
}
