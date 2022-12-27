using NUnit.Framework;
using SomeConsoleApplication;
using System.IO;
using System;

namespace SomeConsoleApplicationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var actual = Program.AlwaysReturnsTrue();

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void Passthrough_ReturnsTheGivenValue()
        {
            // Arrange
            var value = 42;

            // Act
            var actual = Program.Passthrough(value);

            // Assert
            Assert.AreEqual(actual, value);
        }

    }
}
