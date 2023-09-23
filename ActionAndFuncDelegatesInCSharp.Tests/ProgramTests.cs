using System;
using System.Collections.Generic;
using ActionAndFuncDelegatesInCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActionAndFuncDelegatesInCSharp.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestIntroduction()
        {

            // Arrange
            string expectedIntroduction = "Jane is a Female";
            var person = new Person { Name = "Jane", Gender = "Female", Country = "Australia" };

            // Act
            string actualIntroduction = Program.IntroducePerson(person);

            // Assert
            Assert.AreEqual(expectedIntroduction, actualIntroduction);
        }

        [TestMethod]
        public void TestFullIntroduction()
        {
            // Arrange
            string expectedFullIntroduction = "Mark is a Male from Germany";
            var person = new Person { Name = "Mark", Gender = "Male", Country = "Germany" };

            // Act
            string actualFullIntroduction = Program.FullIntroducePerson(person);

            // Assert
            Assert.AreEqual(expectedFullIntroduction, actualFullIntroduction);
        }

        [TestMethod()]
        public void MainTest()
        {

            Assert.Fail();
        }
    }

}
